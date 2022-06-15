
namespace Whatsapp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonGetPicture = new System.Windows.Forms.Button();
            this.pictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelGoToRegister = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.textBoxLoginPassword = new Whatsapp.LineTextBox();
            this.textBoxLoginUserName = new Whatsapp.LineTextBox();
            this.labelLoginInfos = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.ovalPictureBoxImage = new Whatsapp.OvalPictureBox();
            this.textBoxPort = new Whatsapp.LineTextBox();
            this.textBoxIP = new Whatsapp.LineTextBox();
            this.labelGoToLogin = new System.Windows.Forms.Label();
            this.textBoxPasswordAgain = new Whatsapp.LineTextBox();
            this.labelRegisterInfos = new System.Windows.Forms.Label();
            this.textBoxPassword = new Whatsapp.LineTextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxUserName = new Whatsapp.LineTextBox();
            this.textBoxName = new Whatsapp.LineTextBox();
            this.textBoxSurname = new Whatsapp.LineTextBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetPicture
            // 
            this.buttonGetPicture.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonGetPicture.FlatAppearance.BorderSize = 0;
            this.buttonGetPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGetPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.buttonGetPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetPicture.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGetPicture.ForeColor = System.Drawing.Color.White;
            this.buttonGetPicture.Location = new System.Drawing.Point(77, 268);
            this.buttonGetPicture.Name = "buttonGetPicture";
            this.buttonGetPicture.Size = new System.Drawing.Size(90, 30);
            this.buttonGetPicture.TabIndex = 18;
            this.buttonGetPicture.Text = "Resim Seç";
            this.buttonGetPicture.UseVisualStyleBackColor = false;
            this.buttonGetPicture.Click += new System.EventHandler(this.ButtonSelectPictureClick);
            // 
            // pictureDialog
            // 
            this.pictureDialog.FileName = "openFileDialog1";
            this.pictureDialog.Filter = "Resim Dosyaları (JPG, JPEG, PNG, BMP) | *.jpg; *.jpeg; *.png; *.bmp;";
            this.pictureDialog.Title = "Resim Seçimi";
            // 
            // labelGoToRegister
            // 
            this.labelGoToRegister.AutoSize = true;
            this.labelGoToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToRegister.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGoToRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.labelGoToRegister.Location = new System.Drawing.Point(67, 248);
            this.labelGoToRegister.Name = "labelGoToRegister";
            this.labelGoToRegister.Size = new System.Drawing.Size(211, 18);
            this.labelGoToRegister.TabIndex = 17;
            this.labelGoToRegister.Text = "Bir hesabınız yok mu? Kayıt olun.";
            this.labelGoToRegister.Click += new System.EventHandler(this.LabelGoToRegisterClick);
            this.labelGoToRegister.MouseEnter += new System.EventHandler(this.LabelGoToRegisterMouseEnter);
            this.labelGoToRegister.MouseLeave += new System.EventHandler(this.LabelGoToRegisterMouseLeave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(67, 206);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(211, 32);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLoginClick);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.pictureBoxExit);
            this.panelTitle.Controls.Add(this.pictureBoxTitle);
            this.panelTitle.Location = new System.Drawing.Point(0, -2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(345, 150);
            this.panelTitle.TabIndex = 2;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.pictureBoxExit.BackgroundImage = global::Whatsapp.Properties.Resources.Exit_Icon;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Location = new System.Drawing.Point(313, 3);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxExit.TabIndex = 22;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.PictureBoxExitClick);
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxTitle.Image = global::Whatsapp.Properties.Resources.Title_Panel;
            this.pictureBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(345, 150);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTitle.TabIndex = 0;
            this.pictureBoxTitle.TabStop = false;
            this.pictureBoxTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxTitleMouseDown);
            this.pictureBoxTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxTitleMouseMove);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.textBoxLoginPassword);
            this.panelLogin.Controls.Add(this.textBoxLoginUserName);
            this.panelLogin.Controls.Add(this.labelGoToRegister);
            this.panelLogin.Controls.Add(this.labelLoginInfos);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Location = new System.Drawing.Point(0, 148);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(345, 303);
            this.panelLogin.TabIndex = 3;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoginPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxLoginPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxLoginPassword.BorderSize = 2;
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginPassword.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxLoginPassword.Location = new System.Drawing.Point(110, 136);
            this.textBoxLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginPassword.MaxLength = 24;
            this.textBoxLoginPassword.Multiline = false;
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxLoginPassword.PasswordChar = true;
            this.textBoxLoginPassword.PlaceholderText = "Şifre";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(124, 35);
            this.textBoxLoginPassword.TabIndex = 21;
            this.textBoxLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginPassword.Texts = "";
            this.textBoxLoginPassword.UnderlinedStyle = true;
            // 
            // textBoxLoginUserName
            // 
            this.textBoxLoginUserName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoginUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.textBoxLoginUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxLoginUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxLoginUserName.BorderSize = 2;
            this.textBoxLoginUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginUserName.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxLoginUserName.Location = new System.Drawing.Point(110, 90);
            this.textBoxLoginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginUserName.MaxLength = 50;
            this.textBoxLoginUserName.Multiline = false;
            this.textBoxLoginUserName.Name = "textBoxLoginUserName";
            this.textBoxLoginUserName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxLoginUserName.PasswordChar = false;
            this.textBoxLoginUserName.PlaceholderText = "Kullanıcı Adı";
            this.textBoxLoginUserName.Size = new System.Drawing.Size(124, 35);
            this.textBoxLoginUserName.TabIndex = 20;
            this.textBoxLoginUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginUserName.Texts = "";
            this.textBoxLoginUserName.UnderlinedStyle = true;
            // 
            // labelLoginInfos
            // 
            this.labelLoginInfos.AutoSize = true;
            this.labelLoginInfos.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoginInfos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoginInfos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.labelLoginInfos.Location = new System.Drawing.Point(106, 43);
            this.labelLoginInfos.Name = "labelLoginInfos";
            this.labelLoginInfos.Size = new System.Drawing.Size(133, 26);
            this.labelLoginInfos.TabIndex = 18;
            this.labelLoginInfos.Text = "Giriş Bilgileri";
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.White;
            this.panelRegister.Controls.Add(this.checkBox);
            this.panelRegister.Controls.Add(this.ovalPictureBoxImage);
            this.panelRegister.Controls.Add(this.textBoxPort);
            this.panelRegister.Controls.Add(this.buttonGetPicture);
            this.panelRegister.Controls.Add(this.textBoxIP);
            this.panelRegister.Controls.Add(this.labelGoToLogin);
            this.panelRegister.Controls.Add(this.textBoxPasswordAgain);
            this.panelRegister.Controls.Add(this.labelRegisterInfos);
            this.panelRegister.Controls.Add(this.textBoxPassword);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.textBoxUserName);
            this.panelRegister.Controls.Add(this.textBoxName);
            this.panelRegister.Controls.Add(this.textBoxSurname);
            this.panelRegister.Location = new System.Drawing.Point(360, -2);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(345, 517);
            this.panelRegister.TabIndex = 19;
            this.panelRegister.Visible = false;
            // 
            // checkBox
            // 
            this.checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox.BackgroundImage = global::Whatsapp.Properties.Resources.Checked_Icon;
            this.checkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox.FlatAppearance.BorderSize = 0;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Location = new System.Drawing.Point(35, 225);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(35, 35);
            this.checkBox.TabIndex = 30;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // ovalPictureBoxImage
            // 
            this.ovalPictureBoxImage.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBoxImage.Image = global::Whatsapp.Properties.Resources.Default;
            this.ovalPictureBoxImage.Location = new System.Drawing.Point(173, 267);
            this.ovalPictureBoxImage.Name = "ovalPictureBoxImage";
            this.ovalPictureBoxImage.Size = new System.Drawing.Size(92, 92);
            this.ovalPictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBoxImage.TabIndex = 29;
            this.ovalPictureBoxImage.TabStop = false;
            // 
            // textBoxPort
            // 
            this.textBoxPort.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPort.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxPort.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxPort.BorderSize = 2;
            this.textBoxPort.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPort.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxPort.Location = new System.Drawing.Point(204, 225);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPort.MaxLength = 6;
            this.textBoxPort.Multiline = false;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPort.PasswordChar = false;
            this.textBoxPort.PlaceholderText = "Port";
            this.textBoxPort.Size = new System.Drawing.Size(61, 35);
            this.textBoxPort.TabIndex = 28;
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPort.Texts = "";
            this.textBoxPort.UnderlinedStyle = false;
            // 
            // textBoxIP
            // 
            this.textBoxIP.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxIP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxIP.BorderSize = 2;
            this.textBoxIP.Enabled = false;
            this.textBoxIP.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIP.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxIP.Location = new System.Drawing.Point(77, 225);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIP.MaxLength = 15;
            this.textBoxIP.Multiline = false;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxIP.PasswordChar = false;
            this.textBoxIP.PlaceholderText = "IP Adresi";
            this.textBoxIP.Size = new System.Drawing.Size(119, 35);
            this.textBoxIP.TabIndex = 27;
            this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIP.Texts = "127.0.0.1";
            this.textBoxIP.UnderlinedStyle = false;
            // 
            // labelGoToLogin
            // 
            this.labelGoToLogin.AutoSize = true;
            this.labelGoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGoToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.labelGoToLogin.Location = new System.Drawing.Point(49, 423);
            this.labelGoToLogin.Name = "labelGoToLogin";
            this.labelGoToLogin.Size = new System.Drawing.Size(246, 18);
            this.labelGoToLogin.TabIndex = 17;
            this.labelGoToLogin.Text = "Zaten bir hesabınız var mı? Giriş yapın.";
            this.labelGoToLogin.Click += new System.EventHandler(this.LabelGoToLoginClick);
            this.labelGoToLogin.MouseEnter += new System.EventHandler(this.LabelGoToLoginMouseEnter);
            this.labelGoToLogin.MouseLeave += new System.EventHandler(this.LabelGoToLoginMouseLeave);
            // 
            // textBoxPasswordAgain
            // 
            this.textBoxPasswordAgain.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPasswordAgain.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxPasswordAgain.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxPasswordAgain.BorderSize = 2;
            this.textBoxPasswordAgain.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPasswordAgain.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxPasswordAgain.Location = new System.Drawing.Point(175, 182);
            this.textBoxPasswordAgain.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordAgain.MaxLength = 24;
            this.textBoxPasswordAgain.Multiline = false;
            this.textBoxPasswordAgain.Name = "textBoxPasswordAgain";
            this.textBoxPasswordAgain.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPasswordAgain.PasswordChar = true;
            this.textBoxPasswordAgain.PlaceholderText = "Tekrar";
            this.textBoxPasswordAgain.Size = new System.Drawing.Size(90, 35);
            this.textBoxPasswordAgain.TabIndex = 26;
            this.textBoxPasswordAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPasswordAgain.Texts = "";
            this.textBoxPasswordAgain.UnderlinedStyle = false;
            // 
            // labelRegisterInfos
            // 
            this.labelRegisterInfos.AutoSize = true;
            this.labelRegisterInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegisterInfos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegisterInfos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(85)))));
            this.labelRegisterInfos.Location = new System.Drawing.Point(102, 43);
            this.labelRegisterInfos.Name = "labelRegisterInfos";
            this.labelRegisterInfos.Size = new System.Drawing.Size(138, 26);
            this.labelRegisterInfos.TabIndex = 18;
            this.labelRegisterInfos.Text = "Kayıt Bilgileri";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxPassword.BorderSize = 2;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxPassword.Location = new System.Drawing.Point(77, 182);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.MaxLength = 24;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPassword.PasswordChar = true;
            this.textBoxPassword.PlaceholderText = "Şifre";
            this.textBoxPassword.Size = new System.Drawing.Size(90, 35);
            this.textBoxPassword.TabIndex = 25;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlinedStyle = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(67, 381);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(211, 32);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Kayıt Ol";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegisterClick);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxUserName.BorderSize = 2;
            this.textBoxUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserName.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxUserName.Location = new System.Drawing.Point(77, 139);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.MaxLength = 50;
            this.textBoxUserName.Multiline = false;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxUserName.PasswordChar = false;
            this.textBoxUserName.PlaceholderText = "Kullanıcı Adı";
            this.textBoxUserName.Size = new System.Drawing.Size(188, 35);
            this.textBoxUserName.TabIndex = 24;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUserName.Texts = "";
            this.textBoxUserName.UnderlinedStyle = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxName.BorderSize = 2;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxName.Location = new System.Drawing.Point(77, 96);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxName.PasswordChar = false;
            this.textBoxName.PlaceholderText = "Ad";
            this.textBoxName.Size = new System.Drawing.Size(90, 35);
            this.textBoxName.TabIndex = 22;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.Texts = "";
            this.textBoxName.UnderlinedStyle = false;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSurname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxSurname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.textBoxSurname.BorderSize = 2;
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxSurname.Location = new System.Drawing.Point(175, 96);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurname.MaxLength = 30;
            this.textBoxSurname.Multiline = false;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxSurname.PasswordChar = false;
            this.textBoxSurname.PlaceholderText = "Soyad";
            this.textBoxSurname.Size = new System.Drawing.Size(90, 35);
            this.textBoxSurname.TabIndex = 23;
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSurname.Texts = "";
            this.textBoxSurname.UnderlinedStyle = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(722, 531);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SizeChanged += new System.EventHandler(this.LoginFormSizeChanged);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog pictureDialog;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelGoToRegister;
        private System.Windows.Forms.Button buttonGetPicture;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelLoginInfos;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelGoToLogin;
        private System.Windows.Forms.Label labelRegisterInfos;
        private System.Windows.Forms.Button buttonRegister;
        private LineTextBox textBoxLoginUserName;
        private LineTextBox textBoxLoginPassword;
        private LineTextBox textBoxName;
        private LineTextBox textBoxSurname;
        private LineTextBox textBoxUserName;
        private LineTextBox textBoxPasswordAgain;
        private LineTextBox textBoxPassword;
        private LineTextBox textBoxIP;
        private LineTextBox textBoxPort;
        private OvalPictureBox ovalPictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

