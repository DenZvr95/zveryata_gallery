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
    public partial class FormGenre : Form
    {
        Users sess;
        string str;
        public Genres genre;

        public FormGenre(Genres genreIn, Users sess)
        {
            this.sess = sess;
            this.genre = genreIn;
            
            InitializeComponent();
            if (DBFunction.Session(sess))
            {
                if (genre == null)
                {
                    bAdd.Click += bAdd_Click_Add;
                    bDel.Visible = false;
                    this.Text = "Добавление жанра";
                }
                else
                {
                    tbName.Text = genre.Name;
                    tbDescription.Text = genre.Description;
                    str = genre.Name;
                    bAdd.Click += bAdd_Click_Edit;
                    this.Text = "Редактирование жанра";
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
        //ADD
        //
        private void bAdd_Click_Add(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if (NonRelapse.GenresNR(tbName.Text))
                {
                    genre = new Genres
                    {
                        Name = tbName.Text,
                        Description = tbDescription.Text
                    };
                }
                else
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("Жанр с таким наименованием уже есть.");                   
                }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Название жанра не может быть пустым.");
            }
        }

        //
        //EDIT
        //
        private void bAdd_Click_Edit(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if (str == tbName.Text)
            {
                genre.Description = tbDescription.Text;
            }
            else
            {
                if (NonRelapse.GenresNR(tbName.Text))
                {
                    genre.Name = tbName.Text;
                    genre.Description = tbDescription.Text;
                }
                else
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("Жанр с таким наименованием уже есть.");
                }
            }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Название жанра не может быть пустым.");
            }
        }

        //
        //EDIT
        //
        private void bDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите удалить жанр?";
            String caption = "Удаление";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbDescription.Focus();
        }
    }
}
