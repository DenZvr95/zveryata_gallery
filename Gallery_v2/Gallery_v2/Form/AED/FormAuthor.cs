using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gallery_v2
{
    public partial class FormAuthor : Form
    {
        Users sess;
        string str;
        public Authors author;

        public FormAuthor(Authors authorIn, Users sess)
        {
            this.sess = sess;
            this.author = authorIn;
            InitializeComponent();
            if (DBFunction.Session(sess))
            {
                if (authorIn == null)
                {
                    bAdd.Click += bClick_Add;
                    bDel.Visible = false;
                    this.Text = "Добавление автора";
                }
                else
                {
                    tbName.Text = author.Name;
                    dateBorn.Value = author.Born;
                    dateDied.Value = author.Died;
                    str = author.Name;
                    bAdd.Click += bClick_Edit;
                    this.Text = "Редактирование автора";
                    bAdd.Text = "Изменить";
                }
            }
            else
            {
                MessageBox.Show("Ай-ай");
                FormAutorization formAuth = new FormAutorization();
                formAuth.Show();
                formAuth.Closed += (s, Args) => this.Close();
                this.Hide();
            }
        }

        //
        //ДОБАВИТЬ
        //
        private void bClick_Add(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if (NonRelapse.AuthorsNR(tbName.Text))
                {
                    if (Validation.DataCheck(dateBorn.Value, dateDied.Value))
                    {
                        author = new Authors
                        {
                            Name = tbName.Text,
                            Born = dateBorn.Value,
                            Died = dateDied.Value
                        };
                    }
                    else
                    {
                        DialogResult = DialogResult.None;
                        MessageBox.Show("Даты введены некорректно!");
                    }
                }
                else
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("Такой автор уже существует.");
                }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Имя автора не может быть пустым.");
            }

        }

        //
        //РЕДАКТИРОВАТЬ
        //
        private void bClick_Edit(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                    if (str == tbName.Text)
                    {
                        author.Born = dateBorn.Value;
                        author.Died = dateDied.Value;
                    }
                    else
                    {
                        if (NonRelapse.AuthorsNR(tbName.Text))
                        {
                            if (Validation.DataCheck(dateBorn.Value, dateDied.Value))
                            {
                                author.Name = tbName.Text;
                                author.Born = dateBorn.Value;
                                author.Died = dateDied.Value;
                            }
                            else
                                DialogResult = DialogResult.None;
                                MessageBox.Show("Даты введены некорректно!");
                        }
                        else
                        {
                            DialogResult = DialogResult.None;
                            MessageBox.Show("Автор с таким именем уже существует.");

                        }
                    }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Имя автора не может быть пустым.");
            }

        }

        //
        //Удалить
        //
        private void bDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите удалить автора?";
            String caption = "Удаление";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
            }
            
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') dateBorn.Focus();
        }

        private void dateBorn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') dateDied.Focus();
        }

        private void dateDied_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') bAdd.Focus();
        }
    }
}
