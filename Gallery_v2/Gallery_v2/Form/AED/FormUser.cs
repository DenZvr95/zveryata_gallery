using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gallery_v2
{
    public partial class FormUser : Form
    {
        string str;
        public Users user;
        TableContext tabCon;

        public FormUser(Users user)
        {
            this.user = user;
            str = "";
            InitializeComponent();
            tabCon = new TableContext();

            if (user == null)
            {
                bAdd.Click += bAdd_Click_Add;
                bDel.Visible = false;
                this.Text = "Добавление пользователя";
            }
            else
            {

                tbLogin.Text = user.Login;
                tbPassword.Text = user.Password;
                tbPassReap.Text = user.Password;
                tbSurname.Text = user.Surname;
                tbName.Text = user.FirstName;
                tbLastName.Text = user.LastName;

                bAdd.Click += bAdd_Click_Edit;
                this.Text = "Редактирование пользователя";
                bAdd.Text = "Изменить";
            }
        }

        //
        //ADD
        //
        private void bAdd_Click_Add(object sender, EventArgs e)
        {
            if (tbLogin.Text != "")
            {
                if (NonRelapse.UsersNR(tbLogin.Text))
                {
                    if (tbPassword.Text == tbPassReap.Text)
                    {
                        user = new Users
                        {
                            Login = tbLogin.Text,
                            Password = tbPassword.Text,
                            Surname = tbSurname.Text,
                            FirstName = tbName.Text,
                            LastName = tbLastName.Text
                            
                        };

                    }
                    else
                    {
                        DialogResult = DialogResult.None;
                        MessageBox.Show("Повторите пароль");
                    }
                }
                else
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("Пользователь с таким логином уже есть.");
                }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Поле логин не может быть пустым.");
            }
        }

        //
        //EDIT
        //
        private void bAdd_Click_Edit(object sender, EventArgs e)
        {
            if (tbLogin.Text != "")
            {
                if (str == tbLogin.Text)
                {
                    if (tbPassword.Text == tbPassReap.Text)
                    {
                        user.Password = tbPassword.Text;
                        user.Surname = tbSurname.Text;
                        user.FirstName = tbName.Text;
                        user.LastName = tbLastName.Text;
                    }
                    else
                    {
                        DialogResult = DialogResult.None;
                        MessageBox.Show("Повторите пароль");
                    }
                }
                else
                {
                    if (NonRelapse.GenresNR(tbLogin.Text))
                    {
                        if (tbPassword.Text == tbPassReap.Text)
                        {
                            user.Login = tbLogin.Text;
                            user.Password = tbPassword.Text;
                            user.Surname = tbSurname.Text;
                            user.FirstName = tbName.Text;
                            user.LastName = tbLastName.Text;
                        }
                        else
                        {
                            DialogResult = DialogResult.None;
                            MessageBox.Show("Повторите пароль");
                        }
                    }
                    else
                    {
                        DialogResult = DialogResult.None;
                        MessageBox.Show("Пользователь с таким логином уже есть.");
                    }
                }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Поле логин не может быть пустым.");
            }
        }

        //
        //EDIT
        //
        private void bDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите удалить пользователя?";
            String caption = "Удаление";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
            }
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPassword.Focus();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPassword.Focus();
        }

        private void tbPassReap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPassword.Focus();
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPassword.Focus();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPassword.Focus();
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPassword.Focus();
        }

        private void cbPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPassword.Focus();
        }
    }
}
