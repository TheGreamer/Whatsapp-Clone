using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Whatsapp.Properties;
using Message = SimpleTCP.Message;

namespace Whatsapp
{
    public partial class ListForm : Form
    {
        private SimpleTcpClient client;
        private List<Button> deleteButtons;
        private List<string> nameList;
        private string tempData;
        private bool connectionState, searchState;

        public ListForm()
        {
            InitializeComponent();

            nameList = new();
            deleteButtons = new();
            Size = new(349, 545);
            panelAddUser.Location = new(0, 112);
            panelChats.Location = new(0, 112);
            panelChat.Location = new(0, 0);

            GetFriends();
            GetChats();

            for (int i = 0; i < panelChats.Controls.Count; i++)
            {
                nameList.Add(panelChats.Controls[i].Controls[0].Text);
            }

            client = new()
            {
                StringEncoder = Encoding.UTF8,
            };

            client.DataReceived += ClientDataReceieved;
            LoginForm.server.DataReceived += ServerDataRecieved;
        }

        private void GetFriends(bool filter = false)
        {
            panelAllFriends.Controls.Clear();

            WhatsappDB.connection.Open();

            SqlCommand command = filter
                                 ? (new($"SELECT * FROM Friends INNER JOIN Users ON (Users.Id = Friends.UserId) WHERE Users.Id = {LoginForm.userId} AND Friends.FriendName LIKE '%{lineTextBoxSearch.Texts}%'", WhatsappDB.connection))
                                 : (new($"SELECT * FROM Friends INNER JOIN Users ON (Users.Id = Friends.UserId) WHERE Users.Id = {LoginForm.userId}", WhatsappDB.connection));

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                #region Panel
                Panel panelFriend = new()
                {
                    Dock = DockStyle.Top,
                    BackColor = Color.Transparent,
                    Height = 60,
                    Padding = new(5),
                    BorderStyle = BorderStyle.None,
                    Cursor = Cursors.PanWest
                };

                panelFriend.MouseEnter += NewUserPanelMouseEnter;
                panelFriend.MouseLeave += NewUserPanelMouseLeave;
                panelFriend.Click += NewUserPanelClick;

                void NewUserPanelMouseEnter(object sender, EventArgs e) => panelFriend.BackColor = Color.FromArgb(150, 200, 200);

                void NewUserPanelMouseLeave(object sender, EventArgs e) => panelFriend.BackColor = Color.Transparent;

                void NewUserPanelClick(object sender, EventArgs e)
                {
                    if (!nameList.Contains(panelFriend.Controls[0].Text))
                    {
                        panelAllFriends.Visible = false;
                        panelChats.Visible = true;
                        buttonAddFriend.Visible = false;
                        buttonFriends.BackColor = Color.ForestGreen;
                        buttonChats.BackColor = Color.FromArgb(34, 177, 76);

                        #region Panel
                        Panel panelChatUser = new()
                        {
                            Dock = DockStyle.Top,
                            BackColor = Color.Transparent,
                            Height = 60,
                            Padding = new(5),
                            BorderStyle = BorderStyle.None,
                            Cursor = Cursors.Hand
                        };

                        panelChatUser.MouseEnter += NewChatPanelMouseEnter;
                        panelChatUser.MouseLeave += NewChatPanelMouseLeave;
                        panelChatUser.Click += NewChatPanelClick;

                        void NewChatPanelMouseEnter(object sender, EventArgs e) => panelChatUser.BackColor = Color.FromArgb(150, 200, 200);

                        void NewChatPanelMouseLeave(object sender, EventArgs e) => panelChatUser.BackColor = Color.Transparent;

                        void NewChatPanelClick(object sender, EventArgs e) => PanelClick(panelChatUser);
                        #endregion

                        #region Picture Box
                        OvalPictureBox pictureChatFriend = new()
                        {
                            Dock = DockStyle.Left,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Height = 50,
                            Width = 50,
                            Image = (panelFriend.Controls[1] as OvalPictureBox).Image
                        };
                        #endregion

                        #region Label
                        Label labelFriendName = new()
                        {
                            Dock = DockStyle.Left,
                            ForeColor = Color.Black,
                            AutoSize = true,
                            Font = new("Calibri", 12.5F, FontStyle.Bold, GraphicsUnit.Point),
                            Text = panelFriend.Controls[0].Text
                        };
                        #endregion

                        panelChatUser.Controls.Add(labelFriendName);
                        panelChatUser.Controls.Add(pictureChatFriend);
                        panelChats.Controls.Add(panelChatUser);
                        tempData = labelFriendName.Text;
                    }
                    else
                    {
                        MessageBox.Show("Bu kişi sohbet listenizde mevcut.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                #endregion

                #region Picture Box
                OvalPictureBox pictureFriend = new()
                {
                    Dock = DockStyle.Left,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = 50,
                    Width = 50
                };

                try
                {
                    pictureFriend.Image = Image.FromFile(LoginForm.imagesFolder + "\\" + reader["FriendPicture"].ToString());
                }
                catch (FileNotFoundException)
                {
                    pictureFriend.Image = Image.FromFile(LoginForm.imagesFolder + "\\Default\\Default.jpg");
                }
                #endregion

                #region Label
                Label labelFriendName = new()
                {
                    Dock = DockStyle.Left,
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Font = new("Calibri", 12.5F, FontStyle.Bold, GraphicsUnit.Point),
                    Text = reader["FriendName"].ToString()
                };
                #endregion

                #region Button
                Button buttonDeleteFriend = new()
                {
                    Dock = DockStyle.Right,
                    Width = 45,
                    Height = 25,
                    Visible = false,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    BackColor = Color.Transparent,
                    BackgroundImage = Resources.User_Delete_Icon,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Cursor = Cursors.Hand,
                };

                buttonDeleteFriend.Click += ButtonDeleteFriendClick;

                void ButtonDeleteFriendClick(object sender, EventArgs e)
                {
                    if (MessageBox.Show("Bu kişiyi silmek istediğine emin misin?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        WhatsappDB.ExecuteProcedure("DeleteFriend",
                                                    new string[] { "userId", "friendName" },
                                                    new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar },
                                                    new object[] { LoginForm.userId, labelFriendName.Text });

                        GetFriends();
                    }
                }
                #endregion

                panelFriend.Controls.Add(labelFriendName);
                panelFriend.Controls.Add(pictureFriend);
                panelFriend.Controls.Add(buttonDeleteFriend);
                panelAllFriends.Controls.Add(panelFriend);
                deleteButtons.Add(buttonDeleteFriend);
            }

            WhatsappDB.connection.Close();
        }

        private void GetChats(bool filter = false)
        {
            panelChats.Controls.Clear();

            WhatsappDB.connection.Open();

            SqlCommand command = filter
                                 ? (new($"SELECT DISTINCT FriendName, FriendPicture FROM Chats INNER JOIN Friends ON (Chats.FriendId = Friends.FriendId) WHERE Chats.UserId = {LoginForm.userId} AND Friends.FriendName LIKE '%{lineTextBoxSearch.Texts}%'", WhatsappDB.connection))
                                 : (new($"SELECT DISTINCT FriendName, FriendPicture FROM Chats INNER JOIN Friends ON (Chats.FriendId = Friends.FriendId) WHERE Chats.UserId = {LoginForm.userId}", WhatsappDB.connection));

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                #region Panel
                Panel panelFriend = new()
                {
                    Dock = DockStyle.Top,
                    BackColor = Color.Transparent,
                    Height = 60,
                    Padding = new(5),
                    BorderStyle = BorderStyle.None,
                    Cursor = Cursors.Hand
                };

                panelFriend.MouseEnter += NewChatPanelMouseEnter;
                panelFriend.MouseLeave += NewChatPanelMouseLeave;
                panelFriend.Click += NewChatPanelClick;

                void NewChatPanelMouseEnter(object sender, EventArgs e) => panelFriend.BackColor = Color.FromArgb(150, 200, 200);

                void NewChatPanelMouseLeave(object sender, EventArgs e) => panelFriend.BackColor = Color.Transparent;

                void NewChatPanelClick(object sender, EventArgs e)
                {
                    WhatsappDB.connection.Open();
                    SqlCommand ipCommand = new($"SELECT * FROM Users WHERE UserName = '{panelFriend.Controls[0].Text}'", WhatsappDB.connection);
                    SqlDataReader ipReader = ipCommand.ExecuteReader();

                    string friendIP = "";
                    int friendPort = 0;
                    int friendId = 0;

                    if (ipReader.Read())
                    {
                        friendIP = ipReader["IP"].ToString();
                        friendPort = Convert.ToInt32(ipReader["Port"]);
                        friendId = Convert.ToInt32(ipReader["Id"]);
                    }
                    WhatsappDB.connection.Close();

                    try
                    {
                        PanelClick(panelFriend);
                        richTextBox.Text = "";

                        WhatsappDB.connection.Open();
                        SqlCommand messageCommand = new($"SELECT [Message] FROM [Messages] WHERE (UserId = {LoginForm.userId} OR UserId = {friendId}) AND (FriendId = {friendId} OR FriendId = {LoginForm.userId}) ORDER BY MessageDate ASC", WhatsappDB.connection);
                        SqlDataReader messageReader = messageCommand.ExecuteReader();
                        while (messageReader.Read())
                        {
                            richTextBox.Text += messageReader.GetString(0) + "\n";
                        }
                        WhatsappDB.connection.Close();

                        client.Connect(friendIP, friendPort);
                        connectionState = true;
                    }
                    catch
                    {
                        connectionState = false;
                        MessageBox.Show("Bu kişi çevrimdışı.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                #endregion

                #region Picture Box
                OvalPictureBox pictureFriend = new()
                {
                    Dock = DockStyle.Left,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = 50,
                    Width = 50
                };

                try
                {
                    pictureFriend.Image = Image.FromFile(LoginForm.imagesFolder + "\\" + reader["FriendPicture"].ToString());
                }
                catch (FileNotFoundException)
                {
                    pictureFriend.Image = Image.FromFile(LoginForm.imagesFolder + "\\Default\\Default.jpg");
                }
                #endregion

                #region Label
                Label labelFriendName = new()
                {
                    Dock = DockStyle.Left,
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Font = new("Calibri", 12.5F, FontStyle.Bold, GraphicsUnit.Point),
                    Text = reader["FriendName"].ToString()
                };
                #endregion

                panelFriend.Controls.Add(labelFriendName);
                panelFriend.Controls.Add(pictureFriend);
                panelChats.Controls.Add(panelFriend);
            }

            WhatsappDB.connection.Close();
        }

        private void PanelClick(Panel panel)
        {
            panelChats.Visible = false;
            panelChat.Visible = true;
            ovalPictureBoxFriendPicture.Image = (panel.Controls[1] as OvalPictureBox).Image;
            labelFriendName_.Text = panel.Controls[0].Text;

            int friendId = WhatsappDB.GetData($"SELECT FriendId FROM Friends WHERE FriendName = '{labelFriendName_.Text}'", 0);
            int count = WhatsappDB.GetData($"SELECT COUNT(*) FROM Chats WHERE UserId = {LoginForm.userId} AND FriendId = {friendId}", 0);

            if (count == 0)
                WhatsappDB.AddData("Chats", "UserId, FriendId", $"{LoginForm.userId}, {friendId}");

            nameList.Add(tempData);
            tempData = "";
        }

        private void ButtonAddNewFriendClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";

            if (textBoxFriendName.Texts != LoginForm.userName)
            {
                WhatsappDB.connection.Open();

                SqlCommand command = new($"SELECT * FROM Users WHERE UserName = '{textBoxFriendName.Texts}'", WhatsappDB.connection);
                SqlDataReader reader = command.ExecuteReader();
                int friendId = 0;
                string friendPicture = "";

                if (reader.Read())
                {
                    friendId = Convert.ToInt32(reader["Id"]);
                    friendPicture = reader["Picture"].ToString();
                }

                WhatsappDB.connection.Close();

                WhatsappDB.ExecuteProcedure("AddFriend",
                                            new string[] { "userId", "friendId", "userName", "friendName", "friendPicture" },
                                            new SqlDbType[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar },
                                            new object[] { LoginForm.userId, friendId, LoginForm.userName, textBoxFriendName.Texts, friendPicture });

                GetFriends();
            }
            else
            {
                MessageBox.Show("Kendinizi ekleyemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LineTextBoxSearchTextChanged(object sender, EventArgs e)
        {
            if (searchState)
                GetFriends(true);
            else
                GetChats(true);
        }

        private void ButtonLeaveChatClick(object sender, EventArgs e)
        {
            panelChats.Visible = true;
            panelChat.Visible = false;
        }

        private void ListFormFormClosing(object sender, FormClosingEventArgs e)
        {
            WhatsappDB.UpdateData("Users", "UserState", 0, "Id", LoginForm.userId);
            LoginForm.server.Stop();
            Application.Exit();
        }

        private void ButtonSendMessageClick(object sender, EventArgs e)
        {
            if (connectionState)
            {
                if (!string.IsNullOrWhiteSpace(lineTextBoxSendMessage.Texts))
                {
                    string message = LoginForm.userName + " : " + lineTextBoxSendMessage.Texts + "\n";

                    richTextBox.Text += message;
                    client.Write(message);

                    WhatsappDB.ExecuteProcedure("AddMessage",
                                                new string[] { "userId", "friendId", "userName", "friendName", "messages" },
                                                new SqlDbType[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar },
                                                new object[] { LoginForm.userId, WhatsappDB.GetData($"SELECT Id FROM Users WHERE UserName = '{labelFriendName_.Text}'", 0), LoginForm.userName, labelFriendName_.Text, LoginForm.userName + " : " + lineTextBoxSendMessage.Texts });

                    lineTextBoxSendMessage.Texts = "";
                }
                else
                {
                    MessageBox.Show("Boş mesaj gönderemezsin.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu kişi çevrimdışı olduğu için mesaj gönderemezsin.", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClientDataReceieved(object sender, Message e)
        {
            richTextBox.Invoke((MethodInvoker)delegate ()
            {
                richTextBox.Text += e.MessageString;
            });
        }

        private void ServerDataRecieved(object sender, Message e)
        {
            richTextBox.Invoke((MethodInvoker)delegate ()
            {
                richTextBox.Text += e.MessageString;
            });
        }

        #region Ek Eventlar
        private void ButtonChatsClick(object sender, EventArgs e)
        {
            GetChats();

            searchState = false;
            lineTextBoxSearch.Texts = "";
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            panelAllFriends.Visible = false;
            panelChats.Visible = true;
            buttonAddFriend.Visible = false;
            buttonChats.BackColor = Color.FromArgb(34, 177, 76);
            buttonFriends.BackColor = Color.ForestGreen;

            for (int i = 0; i < deleteButtons.Count; i++)
            {
                deleteButtons[i].Visible = false;
            }
        }

        private void ButtonFriendsClick(object sender, EventArgs e)
        {
            GetFriends();

            searchState = true;
            lineTextBoxSearch.Texts = "";
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            panelAllFriends.Visible = true;
            panelChats.Visible = false;
            buttonAddFriend.Visible = true;
            buttonFriends.BackColor = Color.FromArgb(34, 177, 76);
            buttonChats.BackColor = Color.ForestGreen;

            for (int i = 0; i < deleteButtons.Count; i++)
            {
                deleteButtons[i].Visible = false;
            }
        }

        private void ButtonAddFriendClick(object sender, EventArgs e)
        {
            lineTextBoxSearch.Texts = "";
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            panelAddUser.Visible = true;
            panelAllFriends.Visible = false;
            buttonAddFriend.Visible = false;
        }

        private void ButtonGoBackClick(object sender, EventArgs e)
        {
            lineTextBoxSearch.Texts = "";
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            panelAddUser.Visible = false;
            panelAllFriends.Visible = true;
            buttonAddFriend.Visible = true;
        }

        private void ButtonRemoveFriendClick(object sender, EventArgs e)
        {
            lineTextBoxSearch.Texts = "";
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            panelAddUser.Visible = false;
            panelAllFriends.Visible = true;
            buttonAddFriend.Visible = false;

            for (int i = 0; i < deleteButtons.Count; i++)
            {
                deleteButtons[i].Visible = true;
            }
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = false;
            lineTextBoxSearch.Visible = true;
        }

        private void LineTextBoxSearchKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is ((char)Keys.Enter) or (char)Keys.Escape)
            {
                buttonSearch.Visible = true;
                lineTextBoxSearch.Visible = false;
                lineTextBoxSearch.Texts = "";
            }
        }

        private void PanelHeaderClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";
        }

        private void LabelTitleClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";
        }

        private void PictureBoxLogoClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";
        }

        private void TextBoxFriendNameClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";
        }

        private void PanelAllFriendsClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";
        }

        private void PanelChatsClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";
        }

        private void PanelAddUserClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";
        }
        
        private void PanelChatClick(object sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            lineTextBoxSearch.Visible = false;
            lineTextBoxSearch.Texts = "";
        }

        private void PictureBoxExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Point mouseLocation;

        private void PanelHeaderMouseDown(object sender, MouseEventArgs e) => mouseLocation = e.Location;

        private void PanelHeaderMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Location = new Point(Location.X + e.Location.X - mouseLocation.X, Location.Y + e.Location.Y - mouseLocation.Y);
        }

        private void PanelChatTitleMouseDown(object sender, MouseEventArgs e) => mouseLocation = e.Location;

        private void PanelChatTitleMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Location = new Point(Location.X + e.Location.X - mouseLocation.X, Location.Y + e.Location.Y - mouseLocation.Y);
        }
        #endregion
    }
}