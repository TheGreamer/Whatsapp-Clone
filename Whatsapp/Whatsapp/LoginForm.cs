using SimpleTCP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Whatsapp.Properties;

namespace Whatsapp
{
    public partial class LoginForm : Form
    {
        public static SimpleTcpServer server;
        public static string userName, imagesFolder;
        public static int userId;
        private string imagePath;

        public LoginForm()
        {
            InitializeComponent();

            textBoxLoginUserName.Texts = "Gökay";
            textBoxLoginPassword.Texts = "11111111";

            Size = new(346, 450);
            panelLogin.Location = new(0, 148);
            panelRegister.Location = new(0, 148);

            userName = "";
            pictureDialog.Title = "Resim Seçimi";
            pictureDialog.Filter = "Resim Dosyaları (JPG, JPEG, PNG, BMP) | *.jpg; *.jpeg; *.png; *.bmp;";

            WhatsappDB.connection.InfoMessage += new SqlInfoMessageEventHandler(SendProcedureMessage);

            server = new()
            {
                Delimiter = 0x13,
                StringEncoder = Encoding.UTF8
            };

            imagesFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.GetDirectories("Images")[0].FullName;
        }

        private void ButtonSelectPictureClick(object sender, EventArgs e)
        {
            switch (pictureDialog.ShowDialog())
            {
                case DialogResult.OK:
                    imagePath = pictureDialog.FileName;
                    ovalPictureBoxImage.Image = Image.FromFile(imagePath);
                    break;
                default:
                    MessageBox.Show("Resim seçimini iptal ettiniz.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void ButtonRegisterClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Texts) || string.IsNullOrWhiteSpace(textBoxSurname.Texts) || string.IsNullOrWhiteSpace(textBoxUserName.Texts) || string.IsNullOrWhiteSpace(textBoxPassword.Texts) || string.IsNullOrWhiteSpace(textBoxIP.Texts) || string.IsNullOrWhiteSpace(textBoxPort.Texts))
            {
                MessageBox.Show("Kayıt bilgileri boş bırakılamaz.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBoxPassword.Texts.Length < 8)
                {
                    MessageBox.Show("Şifre 8 ile 24 karakter arasında bir uzunlukta olmalıdır.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPassword.Focus();
                }
                else if (textBoxPassword.Texts != textBoxPasswordAgain.Texts)
                {
                    MessageBox.Show("Şifreler aynı değil.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPassword.Focus();
                }
                else
                {
                    string imageName = imagePath == null
                                       ? Path.GetFileName(imagesFolder + "\\Default\\Default.jpg")
                                       : Path.GetFileName(imagePath);

                    WhatsappDB.ExecuteProcedure("AddUser",
                                                new string[] { "name", "surname", "userName", "password", "picture", "ip", "port" },
                                                new SqlDbType[] { SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.Int },
                                                new object[] { textBoxName.Texts, textBoxSurname.Texts, textBoxUserName.Texts, textBoxPassword.Texts, imageName, textBoxIP.Texts, Convert.ToInt32(textBoxPort.Texts) });
                }
            }
        }
        
        private void ButtonLoginClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLoginUserName.Texts))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLoginUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBoxLoginPassword.Texts))
            {
                MessageBox.Show("Şifre boş bırakılamaz.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLoginPassword.Focus();
            }
            else
            {
                WhatsappDB.connection.Open();

                SqlCommand command = new($"SELECT * FROM Users WHERE UserName = '{textBoxLoginUserName.Texts}' AND Password = '{textBoxLoginPassword.Texts}'", WhatsappDB.connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["UserState"].ToString() == "False")
                    {
                        userName = reader["UserName"].ToString();
                        userId = Convert.ToInt32(reader["Id"]);
                        MessageBox.Show("Giriş yaptınız.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        server.Start(IPAddress.Parse(reader["IP"].ToString()), Convert.ToInt32(reader["Port"]));
                        WhatsappDB.connection.Close();

                        WhatsappDB.UpdateData("Users", "UserState", 1, "Id", userId);

                        new ListForm().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı zaten giriş yapmış.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Girilen bilgiler uyuşmuyor.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                WhatsappDB.connection.Close();
            }
        }

        private void SendProcedureMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message, "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (e.Message.Contains("Başarı"))
            {
                if (imagePath != null)
                {
                    string folder = Path.Combine(imagesFolder, Path.GetFileName(imagePath));
                    bool imageExists = File.Exists(folder);

                    if (!imageExists)
                    {
                        File.Copy(imagePath, folder);
                    }
                }

                textBoxLoginUserName.Texts = textBoxUserName.Texts;
                textBoxLoginPassword.Texts = textBoxPassword.Texts;

                LineTextBox[] textBoxes = { textBoxName, textBoxSurname, textBoxUserName, textBoxPassword, textBoxPasswordAgain, textBoxIP, textBoxPort };
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    (textBoxes[i].Controls[0] as TextBox).Clear();
                }

                ovalPictureBoxImage.Image = Image.FromFile(imagesFolder + "\\Default\\Default.jpg");
                Size = new(346, 450);
                panelLogin.Visible = true;
                panelRegister.Visible = false;
            }
        }

        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                checkBox.BackgroundImage = Resources.Not_Checked_Icon;
                textBoxIP.Texts = "";
                textBoxIP.Enabled = true;
            }
            else
            {
                checkBox.BackgroundImage = Resources.Checked_Icon;
                textBoxIP.Texts = "127.0.0.1";
                textBoxIP.Enabled = false;
            }
        }

        #region Ek Eventlar
        private void LabelGoToRegisterClick(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
            Size = new(346, 630);
        }

        private void LabelGoToLoginClick(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelRegister.Visible = false;
            Size = new(346, 450);
        }

        private void LabelGoToRegisterMouseEnter(object sender, EventArgs e) => labelGoToRegister.Font = new("Calibri", 11.25F, FontStyle.Underline, GraphicsUnit.Point);

        private void LabelGoToRegisterMouseLeave(object sender, EventArgs e) => labelGoToRegister.Font = new("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);

        private void LabelGoToLoginMouseEnter(object sender, EventArgs e) => labelGoToLogin.Font = new("Calibri", 11.25F, FontStyle.Underline, GraphicsUnit.Point);

        private void LabelGoToLoginMouseLeave(object sender, EventArgs e) => labelGoToLogin.Font = new("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);

        private void PictureBoxExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginFormSizeChanged(object sender, EventArgs e) => Top = (Screen.FromControl(this).WorkingArea.Height - Height) / 2;

        private Point mouseLocation;

        private void PictureBoxTitleMouseDown(object sender, MouseEventArgs e) => mouseLocation = e.Location;

        private void PictureBoxTitleMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Location = new Point(Location.X + e.Location.X - mouseLocation.X, Location.Y + e.Location.Y - mouseLocation.Y);
        }
        #endregion
    }
}