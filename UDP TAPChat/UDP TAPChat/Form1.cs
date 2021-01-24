///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///
/// Chat Client
/// Curtis J Kordyban
/// Created: December 10th, 2020
/// 
/// About : -Send and receive message directly to an IP address
///         -Simplified version of what a chat room would be like
///         -Utilizes Udpclient sockets to exchange data
///         -Gained more experience using asynchronous methods
///         -Used regular expressions to parse out embedded username in message
///         -Practiced various aesthetics such as textbox placeholders
///         
/// Updates: 
///         -Built user interface
///         -Successfully sent and received message to/from local host
///         -Successfully sent and received message to/from other IP address
///         -Implemented username functionality
///         -Added view IP addresses button
///         -Added placeholder for textbox improved asthetics
///         -Added 'Enter' press to send messages
///         -Updated user interface to improve asthetics
///         -Added button highlighting on mouse enter/leave
///                
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Needed for REGEX

// User Interface Controls Reference:
//  UI_lb_ChatBox      - Listbox for all messages
//  UI_tb_MessageOut   - Textbox for outgoing message
//  UI_tb_Username     - Textbox for Username 
//  UI_tb_IPAddress    - Textbox for Adding IP Address
//  UI_btn_SendMessage - Button for sending message
//  UI_btn_AddAddress  - Button for adding address

namespace UDP_TAPChat
{
    public partial class Form1 : Form
    {
        // Global Variables
        UdpClient clientSocket = new UdpClient();        // Endpoint for sending information to a destination
        UdpClient listeningSocket = new UdpClient(1666); // Receiving information from a destination

        // User Collection - Dictionary -> Key = IP address, Value = Username 
        // ** By default username will be IP address if one was not supplied
        Dictionary<string, string> users = new Dictionary<string, string>(); 
        
        public Form1()
        {
            // Intialization
            InitializeComponent();
            users.Add("127.0.0.1", "localhost"); // Adding localhost on intitial run time
            UpdateTargets();                     // Update IP addresses collection
            Listening();                         // Set receiver into listening state

            // Event Handlers
            Shown += Form1_Shown;

            // Button Events
            UI_btn_SendMessage.Click += UI_btn_SendMessage_Click;
            UI_btn_AddAddress.Click  += UI_btn_AddAddress_Click;
            UI_btn_ViewAddress.Click += UI_btn_ViewAddress_Click;

            // Placeholder events
            UI_tb_MessageOut.Enter += Textbox_Enter;
            UI_tb_Username.Enter   += Textbox_Enter;
            UI_tb_IPAddress.Enter  += Textbox_Enter;

            UI_tb_MessageOut.Leave += Textbox_Leave;
            UI_tb_Username.Leave   += Textbox_Leave;
            UI_tb_IPAddress.Leave  += Textbox_Leave;

            // Enabling Enter as input
            UI_tb_MessageOut.KeyDown += EnterKeyDown;
            UI_tb_IPAddress.KeyDown  += EnterKeyDown;

            // Button Highlights
            UI_btn_AddAddress.MouseEnter  += Button_MouseEnter;
            UI_btn_SendMessage.MouseEnter += Button_MouseEnter;
            UI_btn_AddAddress.MouseLeave  += Button_MouseLeave;
            UI_btn_SendMessage.MouseLeave += Button_MouseLeave;
            UI_btn_ViewAddress.MouseEnter += Button_MouseEnter;
            UI_btn_ViewAddress.MouseLeave += Button_MouseLeave;
        }

        // Event - Send Message - Click - Asynchronously send message to all the users in collection
        async private void UI_btn_SendMessage_Click(object sender, EventArgs e)
        {
            // Checking if textbox is emtpy or in placeholder state
            if (UI_tb_MessageOut.Text.Length == 0 || UI_tb_MessageOut.ForeColor == Color.Gray)
                return;

            // Grabbing input
            string username = "";
            string message = UI_tb_MessageOut.Text;

            // Check if a username is to be embedded in message
            if (UI_tb_Username.Text.Length != 0 && UI_tb_Username.ForeColor != Color.Gray)
                username = $"<{UI_tb_Username.Text}> ";

            // Converting package into byte array to send out
            byte[] messageOut = Encoding.Unicode.GetBytes(username + message);

            // Asynchronously send message to all the users in collection
            await Task.Run(() =>
              {
                  // Itterate through user collection and grab IP addresses
                  (from i in users select new { i.Key }).ToList().ForEach(x =>
                  {
                     try
                     {
                          // Sending message to isolated IP address 
                          Task<int> send = clientSocket.SendAsync(messageOut, messageOut.Length, x.Key, 1666);
                          Console.WriteLine($"Bytes Sent: {send.Result}");
                     }
                     catch (Exception exception)
                     {
                          Console.WriteLine($"Invalid IP address at {users[x.Key]} : " + exception.Message.ToString());
                      }
                  });
              });

            // After sucessful send, clear message box and regain focus
            UI_tb_MessageOut.Clear();
            UI_tb_MessageOut.Focus();

        }

        // Event - Add Address - Click - Adds IP address to collection
        private void UI_btn_AddAddress_Click(object sender, EventArgs e)
        {
            // Checking if textbox is emtpy or in placeholder state
            if (UI_tb_IPAddress.Text.Length == 0 || UI_tb_IPAddress.ForeColor == Color.Gray)
                return;

            // Add IP/user to collection
            AddUser(UI_tb_IPAddress.Text, UI_tb_IPAddress.Text);

            // Update IP Address listbox   
            UpdateAddressListBox();

            UI_tb_IPAddress.Clear();
            Textbox_Leave(UI_tb_IPAddress, new EventArgs());
            UI_tb_MessageOut.Focus();

        }

        // Event - View Address - Click - Expands UI to display hidden listbox of Address Collection
        private void UI_btn_ViewAddress_Click(object sender, EventArgs e)
        {
            // Standard size width check
            if (this.Width == 520)
            {
                UI_btn_ViewAddress.Text = "Close"; // Changing button text state 
                this.Width = 730;                  // Expand forms width to show hidden listbox
                UpdateAddressListBox();            // Update Listbox to display all available IPs 
            }
            // Go back to standard form state
            else
            {
                UI_btn_ViewAddress.Text = "Addresses"; 
                this.Width = 520;   
            }
        }

        /// <summary>
        /// Sets Receiver into listening state
        /// </summary>
        async private void Listening()
        {
            while (true)
            {
                // Set receiver to listening state
                UdpReceiveResult result = await listeningSocket.ReceiveAsync();

                // Parse message upon recieve
                string message = await Task.Run(() => Receiving(result));

                // Update chatbox
                UI_lb_ChatBox.Items.Add(message);
            }

        }

        /// <summary>
        /// -Receives message package
        /// -Adds IP address from sender 
        /// -Updates username if one was included in message
        /// </summary>
        /// <param name="result"></param>
        /// <returns>string - message to be added to chat box</returns>
        private string Receiving(UdpReceiveResult result)
        {
            // Get IP address and message from result
            string ipAddress = result.RemoteEndPoint.Address.ToString();
            string message = Encoding.Unicode.GetString(result.Buffer);
            string username = ipAddress; // By default all usernames will be IP address

            // A message that contains a username will have message sent like so -> < username > : message
            //  -Using regex to parse out username to display in listbox + add username to collection
            //  -Otherwise the IP address of the sender will be displayed username 
            Regex reg = new Regex(@"(?'user'<.+>)");
            if (reg.IsMatch(message))
            {
                // Begin parsing
                MatchCollection matchCollection = reg.Matches(message);
                foreach (Match grouping in matchCollection)
                {
                    // Check if "user" prefix contains anything
                    if (grouping.Groups["user"].Value.Length >= 1)
                    {
                        // Splice out username
                        username = grouping.Groups["user"].ToString().Split('<', '>')[1];
                        message = message.Split('>')[1];
                    }
                }
            }

            // Adding user/updating username to collection
            AddUser(ipAddress, username);

            // Grabbing username from dictionary
            users.Where(user => user.Key == result.RemoteEndPoint.Address.ToString()).ToList().ForEach(user => username = user.Value);

            // Username and message are now good for chatbox display
            return $"[ {username} ] : {message}";
        }

        /// <summary>
        /// Add user to collection
        /// </summary>
        /// <param name="address"></param>
        /// <param name="username"></param>
        private void AddUser(string address, string username)
        {
            // Adding IP address to collection 
            if (!users.ContainsKey(address))            
                users.Add(address, username);          
            else           
                users[address] = username;

            UpdateTargets();     
        }
        /// <summary>
        /// Updates forms title label with how many users you are communicating with
        /// </summary>
        private void UpdateTargets()
        {
            UI_Toolbar_label.Text = $"Know {users.Count} Targets";       
        }

        /// <summary>
        /// Updates address listbox with all users in collection
        /// </summary>
        private void UpdateAddressListBox()
        {
            UI_lb_Addresses.Items.Clear();
            UI_lb_Addresses.Items.Add("Available IP Addresses");
            UI_lb_Addresses.Items.Add("");
            (from i in users select new { i.Key }).ToList().ForEach(x => UI_lb_Addresses.Items.Add(x.Key));
        }

        #region Aesthetics
        // Event - Form - Shown - Sets starting location of form on load
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
        }

        // Event - 'Enter' - KeyDown - Enables 'Enter' as a replacement for button clicking 
        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            // Enabling Enter press to trigger button press
            if (e.KeyCode == Keys.Enter)
            {
                TextBox t = (TextBox)sender;
                switch (t.Name)
                {
                    case "UI_tb_IPAddress":
                        UI_btn_AddAddress_Click(this, new EventArgs());
                        break;

                    case "UI_tb_MessageOut":
                        UI_btn_SendMessage_Click(this, new EventArgs());
                        break;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Event - Textbox - Enter - Changes textbox format state from placeholder
        private void Textbox_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            // Depending on event sender, changing font color to black and clearing placeholder text
            switch (t.Name)
            {
                case "UI_tb_Username":
                    {
                        if (UI_tb_Username.ForeColor == Color.Gray)
                        {
                            UI_tb_Username.Clear();
                            UI_tb_Username.ForeColor = Color.Black;
                        }
                    }
                    break;

                case "UI_tb_MessageOut":
                    {
                        if (UI_tb_MessageOut.ForeColor == Color.Gray)
                        {
                            UI_tb_MessageOut.Clear();
                            UI_tb_MessageOut.ForeColor = Color.Black;
                        }
                    }
                    break;

                case "UI_tb_IPAddress":
                    {
                        if (UI_tb_IPAddress.ForeColor == Color.Gray)
                        {
                            UI_tb_IPAddress.Clear();
                            UI_tb_IPAddress.ForeColor = Color.Black;
                        }
                    }
                    break;
            }
        }

        // Event - Textbox - Leave - Changes textbox format state into placeholder
        private void Textbox_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            // Depending on event sender, changing font color to gray and replacing placeholder text
            switch (t.Name)
            {
                case "UI_tb_Username":
                    {
                        if (UI_tb_Username.Text == "")
                        {
                            UI_tb_Username.Text = "Username";
                            UI_tb_Username.ForeColor = Color.Gray;
                        }
                    }
                    break;

                case "UI_tb_MessageOut":
                    {
                        if (UI_tb_MessageOut.Text == "")
                        {
                            UI_tb_MessageOut.Text = "Message";
                            UI_tb_MessageOut.ForeColor = Color.Gray;
                        }
                    }
                    break;

                case "UI_tb_IPAddress":
                    {
                        if (UI_tb_IPAddress.Text == "")
                        {
                            UI_tb_IPAddress.Text = "IP Address";
                            UI_tb_IPAddress.ForeColor = Color.Gray;
                        }
                    }
                    break;
            }
        }
        // Event - Button - Mouse Enter - Highlights button
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Font = new Font(b.Font, FontStyle.Underline);
        }

        // Event - Button - Mouse Leave - Removes highlighted button
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Font = new Font(b.Font, FontStyle.Regular);

        }

        // Event - Toolbar - Mouse Move - Enables click and drag functionality on form 
        private void UI_ToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
        }

        // Event - Exit Icon - Click - Closes application
        private void UI_ToolbarExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
