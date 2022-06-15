
namespace Whatsapp
{
    partial class ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.panelAllFriends = new System.Windows.Forms.Panel();
            this.buttonAddFriend = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonChats = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lineTextBoxSearch = new Whatsapp.LineTextBox();
            this.panelChats = new System.Windows.Forms.Panel();
            this.buttonAddNewFriend = new System.Windows.Forms.Button();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.buttonRemoveFriend = new System.Windows.Forms.Button();
            this.textBoxFriendName = new Whatsapp.LineTextBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.panelChat = new System.Windows.Forms.Panel();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panelChatTitle = new System.Windows.Forms.Panel();
            this.buttonLeaveChat = new System.Windows.Forms.Button();
            this.labelFriendName_ = new System.Windows.Forms.Label();
            this.ovalPictureBoxFriendPicture = new Whatsapp.OvalPictureBox();
            this.panelSendMessage = new System.Windows.Forms.Panel();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.lineTextBoxSendMessage = new Whatsapp.LineTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelAddUser.SuspendLayout();
            this.panelChat.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.panelChatTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxFriendPicture)).BeginInit();
            this.panelSendMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAllFriends
            // 
            this.panelAllFriends.AutoScroll = true;
            this.panelAllFriends.BackgroundImage = global::Whatsapp.Properties.Resources.Background;
            this.panelAllFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAllFriends.Location = new System.Drawing.Point(0, 112);
            this.panelAllFriends.Name = "panelAllFriends";
            this.panelAllFriends.Padding = new System.Windows.Forms.Padding(5);
            this.panelAllFriends.Size = new System.Drawing.Size(349, 433);
            this.panelAllFriends.TabIndex = 1;
            this.panelAllFriends.Visible = false;
            this.panelAllFriends.Click += new System.EventHandler(this.PanelAllFriendsClick);
            // 
            // buttonAddFriend
            // 
            this.buttonAddFriend.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddFriend.BackgroundImage = global::Whatsapp.Properties.Resources.User_Add_Icon;
            this.buttonAddFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddFriend.FlatAppearance.BorderSize = 0;
            this.buttonAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFriend.ForeColor = System.Drawing.Color.White;
            this.buttonAddFriend.Location = new System.Drawing.Point(280, 495);
            this.buttonAddFriend.Name = "buttonAddFriend";
            this.buttonAddFriend.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddFriend.Size = new System.Drawing.Size(35, 35);
            this.buttonAddFriend.TabIndex = 6;
            this.buttonAddFriend.UseVisualStyleBackColor = false;
            this.buttonAddFriend.Visible = false;
            this.buttonAddFriend.Click += new System.EventHandler(this.ButtonAddFriendClick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Whatsapp.Properties.Resources.Whatsapp_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(9, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(53, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.PictureBoxLogoClick);
            // 
            // buttonChats
            // 
            this.buttonChats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.buttonChats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChats.FlatAppearance.BorderSize = 0;
            this.buttonChats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.buttonChats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonChats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChats.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChats.ForeColor = System.Drawing.Color.White;
            this.buttonChats.Location = new System.Drawing.Point(0, 83);
            this.buttonChats.Name = "buttonChats";
            this.buttonChats.Size = new System.Drawing.Size(175, 32);
            this.buttonChats.TabIndex = 4;
            this.buttonChats.Text = "Sohbetler";
            this.buttonChats.UseVisualStyleBackColor = false;
            this.buttonChats.Click += new System.EventHandler(this.ButtonChatsClick);
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriends.FlatAppearance.BorderSize = 0;
            this.buttonFriends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.buttonFriends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriends.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFriends.ForeColor = System.Drawing.Color.White;
            this.buttonFriends.Location = new System.Drawing.Point(174, 83);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(175, 32);
            this.buttonFriends.TabIndex = 5;
            this.buttonFriends.Text = "Kişiler";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.ButtonFriendsClick);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(67)))));
            this.panelHeader.Controls.Add(this.pictureBoxExit);
            this.panelHeader.Controls.Add(this.buttonSearch);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.lineTextBoxSearch);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(349, 83);
            this.panelHeader.TabIndex = 7;
            this.panelHeader.Click += new System.EventHandler(this.PanelHeaderClick);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeaderMouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeaderMouseMove);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(67)))));
            this.pictureBoxExit.BackgroundImage = global::Whatsapp.Properties.Resources.Exit_Icon;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Location = new System.Drawing.Point(317, 2);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxExit.TabIndex = 23;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.PictureBoxExitClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(67)))));
            this.buttonSearch.BackgroundImage = global::Whatsapp.Properties.Resources.Search_Icon;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(242, 30);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Padding = new System.Windows.Forms.Padding(5);
            this.buttonSearch.Size = new System.Drawing.Size(30, 30);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(66, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 29);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "WhatsApp";
            this.labelTitle.Click += new System.EventHandler(this.LabelTitleClick);
            // 
            // lineTextBoxSearch
            // 
            this.lineTextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(67)))));
            this.lineTextBoxSearch.BorderColor = System.Drawing.Color.Lime;
            this.lineTextBoxSearch.BorderFocusColor = System.Drawing.Color.Cyan;
            this.lineTextBoxSearch.BorderSize = 2;
            this.lineTextBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lineTextBoxSearch.ForeColor = System.Drawing.Color.White;
            this.lineTextBoxSearch.Location = new System.Drawing.Point(242, 36);
            this.lineTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.lineTextBoxSearch.MaxLength = 50;
            this.lineTextBoxSearch.Multiline = false;
            this.lineTextBoxSearch.Name = "lineTextBoxSearch";
            this.lineTextBoxSearch.Padding = new System.Windows.Forms.Padding(7);
            this.lineTextBoxSearch.PasswordChar = false;
            this.lineTextBoxSearch.PlaceholderText = "";
            this.lineTextBoxSearch.Size = new System.Drawing.Size(97, 35);
            this.lineTextBoxSearch.TabIndex = 32;
            this.lineTextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lineTextBoxSearch.Texts = "";
            this.lineTextBoxSearch.UnderlinedStyle = true;
            this.lineTextBoxSearch.Visible = false;
            this.lineTextBoxSearch._TextChanged += new System.EventHandler(this.LineTextBoxSearchTextChanged);
            this.lineTextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LineTextBoxSearchKeyPress);
            // 
            // panelChats
            // 
            this.panelChats.AutoScroll = true;
            this.panelChats.BackgroundImage = global::Whatsapp.Properties.Resources.Background;
            this.panelChats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChats.Location = new System.Drawing.Point(383, 11);
            this.panelChats.Name = "panelChats";
            this.panelChats.Padding = new System.Windows.Forms.Padding(5);
            this.panelChats.Size = new System.Drawing.Size(349, 433);
            this.panelChats.TabIndex = 2;
            this.panelChats.Click += new System.EventHandler(this.PanelChatsClick);
            // 
            // buttonAddNewFriend
            // 
            this.buttonAddNewFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.buttonAddNewFriend.FlatAppearance.BorderSize = 0;
            this.buttonAddNewFriend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddNewFriend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonAddNewFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewFriend.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddNewFriend.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewFriend.Location = new System.Drawing.Point(79, 211);
            this.buttonAddNewFriend.Name = "buttonAddNewFriend";
            this.buttonAddNewFriend.Size = new System.Drawing.Size(188, 32);
            this.buttonAddNewFriend.TabIndex = 25;
            this.buttonAddNewFriend.Text = "Kişi Ekle";
            this.buttonAddNewFriend.UseVisualStyleBackColor = false;
            this.buttonAddNewFriend.Click += new System.EventHandler(this.ButtonAddNewFriendClick);
            // 
            // panelAddUser
            // 
            this.panelAddUser.AutoScroll = true;
            this.panelAddUser.BackgroundImage = global::Whatsapp.Properties.Resources.Background;
            this.panelAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAddUser.Controls.Add(this.buttonRemoveFriend);
            this.panelAddUser.Controls.Add(this.textBoxFriendName);
            this.panelAddUser.Controls.Add(this.buttonGoBack);
            this.panelAddUser.Controls.Add(this.buttonAddNewFriend);
            this.panelAddUser.Location = new System.Drawing.Point(749, 11);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Padding = new System.Windows.Forms.Padding(5);
            this.panelAddUser.Size = new System.Drawing.Size(349, 433);
            this.panelAddUser.TabIndex = 3;
            this.panelAddUser.Visible = false;
            this.panelAddUser.Click += new System.EventHandler(this.PanelAddUserClick);
            // 
            // buttonRemoveFriend
            // 
            this.buttonRemoveFriend.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveFriend.BackgroundImage = global::Whatsapp.Properties.Resources.User_Delete_Icon;
            this.buttonRemoveFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemoveFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveFriend.FlatAppearance.BorderSize = 0;
            this.buttonRemoveFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveFriend.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveFriend.Location = new System.Drawing.Point(305, 11);
            this.buttonRemoveFriend.Name = "buttonRemoveFriend";
            this.buttonRemoveFriend.Padding = new System.Windows.Forms.Padding(5);
            this.buttonRemoveFriend.Size = new System.Drawing.Size(35, 35);
            this.buttonRemoveFriend.TabIndex = 8;
            this.buttonRemoveFriend.UseVisualStyleBackColor = false;
            this.buttonRemoveFriend.Click += new System.EventHandler(this.ButtonRemoveFriendClick);
            // 
            // textBoxFriendName
            // 
            this.textBoxFriendName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFriendName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxFriendName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxFriendName.BorderSize = 2;
            this.textBoxFriendName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxFriendName.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxFriendName.Location = new System.Drawing.Point(79, 169);
            this.textBoxFriendName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFriendName.MaxLength = 50;
            this.textBoxFriendName.Multiline = false;
            this.textBoxFriendName.Name = "textBoxFriendName";
            this.textBoxFriendName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxFriendName.PasswordChar = false;
            this.textBoxFriendName.PlaceholderText = "Kullanıcı Adı";
            this.textBoxFriendName.Size = new System.Drawing.Size(188, 35);
            this.textBoxFriendName.TabIndex = 31;
            this.textBoxFriendName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFriendName.Texts = "";
            this.textBoxFriendName.UnderlinedStyle = false;
            this.textBoxFriendName.Click += new System.EventHandler(this.TextBoxFriendNameClick);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGoBack.BackgroundImage")));
            this.buttonGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoBack.FlatAppearance.BorderSize = 0;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.ForeColor = System.Drawing.Color.White;
            this.buttonGoBack.Location = new System.Drawing.Point(8, 8);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Padding = new System.Windows.Forms.Padding(5);
            this.buttonGoBack.Size = new System.Drawing.Size(40, 40);
            this.buttonGoBack.TabIndex = 8;
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.ButtonGoBackClick);
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChat.Controls.Add(this.panelMessages);
            this.panelChat.Controls.Add(this.panelChatTitle);
            this.panelChat.Controls.Add(this.panelSendMessage);
            this.panelChat.Location = new System.Drawing.Point(1113, 12);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(349, 545);
            this.panelChat.TabIndex = 3;
            this.panelChat.Visible = false;
            this.panelChat.Click += new System.EventHandler(this.PanelChatClick);
            // 
            // panelMessages
            // 
            this.panelMessages.AutoScroll = true;
            this.panelMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMessages.Controls.Add(this.richTextBox);
            this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessages.Location = new System.Drawing.Point(0, 66);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(349, 429);
            this.panelMessages.TabIndex = 3;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(349, 429);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // panelChatTitle
            // 
            this.panelChatTitle.AutoScroll = true;
            this.panelChatTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(67)))));
            this.panelChatTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChatTitle.Controls.Add(this.buttonLeaveChat);
            this.panelChatTitle.Controls.Add(this.labelFriendName_);
            this.panelChatTitle.Controls.Add(this.ovalPictureBoxFriendPicture);
            this.panelChatTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatTitle.Location = new System.Drawing.Point(0, 0);
            this.panelChatTitle.Name = "panelChatTitle";
            this.panelChatTitle.Padding = new System.Windows.Forms.Padding(5);
            this.panelChatTitle.Size = new System.Drawing.Size(349, 66);
            this.panelChatTitle.TabIndex = 3;
            this.panelChatTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelChatTitleMouseDown);
            this.panelChatTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelChatTitleMouseMove);
            // 
            // buttonLeaveChat
            // 
            this.buttonLeaveChat.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeaveChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeaveChat.BackgroundImage")));
            this.buttonLeaveChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeaveChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeaveChat.FlatAppearance.BorderSize = 0;
            this.buttonLeaveChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonLeaveChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaveChat.ForeColor = System.Drawing.Color.White;
            this.buttonLeaveChat.Location = new System.Drawing.Point(301, 13);
            this.buttonLeaveChat.Name = "buttonLeaveChat";
            this.buttonLeaveChat.Padding = new System.Windows.Forms.Padding(5);
            this.buttonLeaveChat.Size = new System.Drawing.Size(40, 40);
            this.buttonLeaveChat.TabIndex = 32;
            this.buttonLeaveChat.UseVisualStyleBackColor = false;
            this.buttonLeaveChat.Click += new System.EventHandler(this.ButtonLeaveChatClick);
            // 
            // labelFriendName_
            // 
            this.labelFriendName_.AutoSize = true;
            this.labelFriendName_.BackColor = System.Drawing.Color.Transparent;
            this.labelFriendName_.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFriendName_.ForeColor = System.Drawing.Color.White;
            this.labelFriendName_.Location = new System.Drawing.Point(64, 22);
            this.labelFriendName_.Name = "labelFriendName_";
            this.labelFriendName_.Size = new System.Drawing.Size(111, 22);
            this.labelFriendName_.TabIndex = 33;
            this.labelFriendName_.Text = "Arkadaş Adı";
            // 
            // ovalPictureBoxFriendPicture
            // 
            this.ovalPictureBoxFriendPicture.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBoxFriendPicture.Location = new System.Drawing.Point(8, 8);
            this.ovalPictureBoxFriendPicture.Name = "ovalPictureBoxFriendPicture";
            this.ovalPictureBoxFriendPicture.Size = new System.Drawing.Size(50, 50);
            this.ovalPictureBoxFriendPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBoxFriendPicture.TabIndex = 0;
            this.ovalPictureBoxFriendPicture.TabStop = false;
            // 
            // panelSendMessage
            // 
            this.panelSendMessage.AutoScroll = true;
            this.panelSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(67)))));
            this.panelSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSendMessage.Controls.Add(this.buttonSendMessage);
            this.panelSendMessage.Controls.Add(this.lineTextBoxSendMessage);
            this.panelSendMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSendMessage.Location = new System.Drawing.Point(0, 495);
            this.panelSendMessage.Name = "panelSendMessage";
            this.panelSendMessage.Padding = new System.Windows.Forms.Padding(5);
            this.panelSendMessage.Size = new System.Drawing.Size(349, 50);
            this.panelSendMessage.TabIndex = 3;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.BackColor = System.Drawing.Color.Transparent;
            this.buttonSendMessage.BackgroundImage = global::Whatsapp.Properties.Resources.Send_Message_Button;
            this.buttonSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendMessage.FlatAppearance.BorderSize = 0;
            this.buttonSendMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSendMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMessage.ForeColor = System.Drawing.Color.White;
            this.buttonSendMessage.Location = new System.Drawing.Point(304, 5);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Padding = new System.Windows.Forms.Padding(5);
            this.buttonSendMessage.Size = new System.Drawing.Size(40, 40);
            this.buttonSendMessage.TabIndex = 32;
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.ButtonSendMessageClick);
            // 
            // lineTextBoxSendMessage
            // 
            this.lineTextBoxSendMessage.BackColor = System.Drawing.Color.Gainsboro;
            this.lineTextBoxSendMessage.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.lineTextBoxSendMessage.BorderFocusColor = System.Drawing.Color.Black;
            this.lineTextBoxSendMessage.BorderSize = 2;
            this.lineTextBoxSendMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lineTextBoxSendMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lineTextBoxSendMessage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lineTextBoxSendMessage.Location = new System.Drawing.Point(5, 8);
            this.lineTextBoxSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.lineTextBoxSendMessage.MaxLength = 50;
            this.lineTextBoxSendMessage.Multiline = false;
            this.lineTextBoxSendMessage.Name = "lineTextBoxSendMessage";
            this.lineTextBoxSendMessage.Padding = new System.Windows.Forms.Padding(7);
            this.lineTextBoxSendMessage.PasswordChar = false;
            this.lineTextBoxSendMessage.PlaceholderText = "";
            this.lineTextBoxSendMessage.Size = new System.Drawing.Size(292, 35);
            this.lineTextBoxSendMessage.TabIndex = 33;
            this.lineTextBoxSendMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lineTextBoxSendMessage.Texts = "";
            this.lineTextBoxSendMessage.UnderlinedStyle = false;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 596);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.buttonAddFriend);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonChats);
            this.Controls.Add(this.panelAllFriends);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelChats);
            this.Controls.Add(this.panelAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListFormFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelAddUser.ResumeLayout(false);
            this.panelChat.ResumeLayout(false);
            this.panelMessages.ResumeLayout(false);
            this.panelChatTitle.ResumeLayout(false);
            this.panelChatTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxFriendPicture)).EndInit();
            this.panelSendMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAllFriends;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonChats;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonAddFriend;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelChats;
        private System.Windows.Forms.Button buttonAddNewFriend;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelChat;
        private LineTextBox textBoxFriendName;
        private System.Windows.Forms.Button buttonRemoveFriend;
        private LineTextBox lineTextBoxSearch;
        private System.Windows.Forms.Panel panelChatTitle;
        private System.Windows.Forms.Panel panelSendMessage;
        private System.Windows.Forms.Button buttonSendMessage;
        private LineTextBox lineTextBoxSendMessage;
        private OvalPictureBox ovalPictureBoxFriendPicture;
        private System.Windows.Forms.Label labelFriendName_;
        private System.Windows.Forms.Button buttonLeaveChat;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}