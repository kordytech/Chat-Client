namespace UDP_TAPChat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UI_tb_MessageOut = new System.Windows.Forms.TextBox();
            this.UI_btn_SendMessage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UI_btn_AddAddress = new System.Windows.Forms.Button();
            this.UI_tb_IPAddress = new System.Windows.Forms.TextBox();
            this.UI_lb_ChatBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UI_tb_Username = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UI_lb_Addresses = new System.Windows.Forms.ListBox();
            this.UI_btn_ViewAddress = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.UI_ToolBar = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.UI_Toolbar_label = new System.Windows.Forms.Label();
            this.UI_ToolbarExit = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UI_ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_tb_MessageOut
            // 
            this.UI_tb_MessageOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UI_tb_MessageOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_tb_MessageOut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_tb_MessageOut.ForeColor = System.Drawing.Color.Gray;
            this.UI_tb_MessageOut.Location = new System.Drawing.Point(38, 8);
            this.UI_tb_MessageOut.Name = "UI_tb_MessageOut";
            this.UI_tb_MessageOut.Size = new System.Drawing.Size(345, 14);
            this.UI_tb_MessageOut.TabIndex = 1;
            this.UI_tb_MessageOut.Text = "Message";
            // 
            // UI_btn_SendMessage
            // 
            this.UI_btn_SendMessage.BackColor = System.Drawing.Color.Transparent;
            this.UI_btn_SendMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UI_btn_SendMessage.BackgroundImage")));
            this.UI_btn_SendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UI_btn_SendMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UI_btn_SendMessage.FlatAppearance.BorderSize = 0;
            this.UI_btn_SendMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UI_btn_SendMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UI_btn_SendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UI_btn_SendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UI_btn_SendMessage.ForeColor = System.Drawing.Color.Black;
            this.UI_btn_SendMessage.Location = new System.Drawing.Point(354, 673);
            this.UI_btn_SendMessage.Name = "UI_btn_SendMessage";
            this.UI_btn_SendMessage.Size = new System.Drawing.Size(135, 36);
            this.UI_btn_SendMessage.TabIndex = 2;
            this.UI_btn_SendMessage.Text = "Send";
            this.UI_btn_SendMessage.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.UI_tb_MessageOut);
            this.panel2.Location = new System.Drawing.Point(37, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 30);
            this.panel2.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(22, 22);
            this.panel8.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(393, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(22, 22);
            this.panel7.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(423, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 20);
            this.panel6.TabIndex = 12;
            // 
            // UI_btn_AddAddress
            // 
            this.UI_btn_AddAddress.BackColor = System.Drawing.Color.Transparent;
            this.UI_btn_AddAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UI_btn_AddAddress.BackgroundImage")));
            this.UI_btn_AddAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UI_btn_AddAddress.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UI_btn_AddAddress.FlatAppearance.BorderSize = 0;
            this.UI_btn_AddAddress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UI_btn_AddAddress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UI_btn_AddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UI_btn_AddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UI_btn_AddAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UI_btn_AddAddress.Location = new System.Drawing.Point(354, 559);
            this.UI_btn_AddAddress.Name = "UI_btn_AddAddress";
            this.UI_btn_AddAddress.Size = new System.Drawing.Size(135, 36);
            this.UI_btn_AddAddress.TabIndex = 7;
            this.UI_btn_AddAddress.Text = "Add Friend";
            this.UI_btn_AddAddress.UseVisualStyleBackColor = false;
            // 
            // UI_tb_IPAddress
            // 
            this.UI_tb_IPAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UI_tb_IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_tb_IPAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_tb_IPAddress.ForeColor = System.Drawing.Color.Gray;
            this.UI_tb_IPAddress.Location = new System.Drawing.Point(7, 7);
            this.UI_tb_IPAddress.Name = "UI_tb_IPAddress";
            this.UI_tb_IPAddress.Size = new System.Drawing.Size(125, 14);
            this.UI_tb_IPAddress.TabIndex = 2;
            this.UI_tb_IPAddress.Text = "IP Address";
            // 
            // UI_lb_ChatBox
            // 
            this.UI_lb_ChatBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UI_lb_ChatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_lb_ChatBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_lb_ChatBox.FormattingEnabled = true;
            this.UI_lb_ChatBox.ItemHeight = 16;
            this.UI_lb_ChatBox.Location = new System.Drawing.Point(11, 14);
            this.UI_lb_ChatBox.Name = "UI_lb_ChatBox";
            this.UI_lb_ChatBox.Size = new System.Drawing.Size(432, 448);
            this.UI_lb_ChatBox.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.UI_lb_ChatBox);
            this.panel3.Location = new System.Drawing.Point(37, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 475);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.UI_tb_IPAddress);
            this.panel4.Location = new System.Drawing.Point(193, 562);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 30);
            this.panel4.TabIndex = 6;
            // 
            // UI_tb_Username
            // 
            this.UI_tb_Username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UI_tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_tb_Username.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_tb_Username.ForeColor = System.Drawing.Color.Gray;
            this.UI_tb_Username.Location = new System.Drawing.Point(11, 7);
            this.UI_tb_Username.Name = "UI_tb_Username";
            this.UI_tb_Username.Size = new System.Drawing.Size(125, 14);
            this.UI_tb_Username.TabIndex = 2;
            this.UI_tb_Username.Text = "Username";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.UI_tb_Username);
            this.panel5.Location = new System.Drawing.Point(37, 562);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 30);
            this.panel5.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UI_lb_Addresses);
            this.panel1.Location = new System.Drawing.Point(522, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 475);
            this.panel1.TabIndex = 10;
            // 
            // UI_lb_Addresses
            // 
            this.UI_lb_Addresses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UI_lb_Addresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_lb_Addresses.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_lb_Addresses.FormattingEnabled = true;
            this.UI_lb_Addresses.ItemHeight = 16;
            this.UI_lb_Addresses.Location = new System.Drawing.Point(12, 13);
            this.UI_lb_Addresses.Name = "UI_lb_Addresses";
            this.UI_lb_Addresses.Size = new System.Drawing.Size(153, 432);
            this.UI_lb_Addresses.TabIndex = 2;
            // 
            // UI_btn_ViewAddress
            // 
            this.UI_btn_ViewAddress.BackColor = System.Drawing.Color.Transparent;
            this.UI_btn_ViewAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UI_btn_ViewAddress.BackgroundImage")));
            this.UI_btn_ViewAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UI_btn_ViewAddress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UI_btn_ViewAddress.FlatAppearance.BorderSize = 0;
            this.UI_btn_ViewAddress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UI_btn_ViewAddress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UI_btn_ViewAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UI_btn_ViewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UI_btn_ViewAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UI_btn_ViewAddress.Location = new System.Drawing.Point(34, 673);
            this.UI_btn_ViewAddress.Name = "UI_btn_ViewAddress";
            this.UI_btn_ViewAddress.Size = new System.Drawing.Size(135, 36);
            this.UI_btn_ViewAddress.TabIndex = 11;
            this.UI_btn_ViewAddress.Text = "Addresses";
            this.UI_btn_ViewAddress.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 740);
            this.panel10.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(518, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 740);
            this.panel9.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(2, 738);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(516, 2);
            this.panel11.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(2, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(516, 2);
            this.panel13.TabIndex = 14;
            // 
            // UI_ToolBar
            // 
            this.UI_ToolBar.Controls.Add(this.panel12);
            this.UI_ToolBar.Controls.Add(this.UI_Toolbar_label);
            this.UI_ToolBar.Controls.Add(this.UI_ToolbarExit);
            this.UI_ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.UI_ToolBar.Location = new System.Drawing.Point(2, 2);
            this.UI_ToolBar.Name = "UI_ToolBar";
            this.UI_ToolBar.Size = new System.Drawing.Size(516, 29);
            this.UI_ToolBar.TabIndex = 15;
            this.UI_ToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UI_ToolBar_MouseMove);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Location = new System.Drawing.Point(5, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(25, 25);
            this.panel12.TabIndex = 16;
            // 
            // UI_Toolbar_label
            // 
            this.UI_Toolbar_label.AutoSize = true;
            this.UI_Toolbar_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Toolbar_label.Location = new System.Drawing.Point(41, 6);
            this.UI_Toolbar_label.Name = "UI_Toolbar_label";
            this.UI_Toolbar_label.Size = new System.Drawing.Size(70, 16);
            this.UI_Toolbar_label.TabIndex = 16;
            this.UI_Toolbar_label.Text = "Chat Client";
            // 
            // UI_ToolbarExit
            // 
            this.UI_ToolbarExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_ToolbarExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UI_ToolbarExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UI_ToolbarExit.BackgroundImage")));
            this.UI_ToolbarExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UI_ToolbarExit.Location = new System.Drawing.Point(487, 6);
            this.UI_ToolbarExit.Name = "UI_ToolbarExit";
            this.UI_ToolbarExit.Size = new System.Drawing.Size(21, 16);
            this.UI_ToolbarExit.TabIndex = 16;
            this.UI_ToolbarExit.Click += new System.EventHandler(this.UI_ToolbarExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 740);
            this.Controls.Add(this.UI_ToolBar);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.UI_btn_ViewAddress);
            this.Controls.Add(this.UI_btn_SendMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.UI_btn_AddAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(740, 750);
            this.Name = "Form1";
            this.Text = "UDP TAPChat";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.UI_ToolBar.ResumeLayout(false);
            this.UI_ToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UI_tb_MessageOut;
        private System.Windows.Forms.Button UI_btn_SendMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UI_btn_AddAddress;
        private System.Windows.Forms.TextBox UI_tb_IPAddress;
        private System.Windows.Forms.ListBox UI_lb_ChatBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox UI_tb_Username;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UI_btn_ViewAddress;
        private System.Windows.Forms.ListBox UI_lb_Addresses;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel UI_ToolBar;
        private System.Windows.Forms.Panel UI_ToolbarExit;
        private System.Windows.Forms.Label UI_Toolbar_label;
        private System.Windows.Forms.Panel panel12;
    }
}

