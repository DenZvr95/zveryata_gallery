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
    public partial class FormPicture : Form
    {
        string str;
        public Pictures picture;
        TableContext tabCon;
        public FormPicture(Pictures picture)
        {
            this.picture = picture;
            
            InitializeComponent();
            tabCon = new TableContext();
            //tabCon.Genres.Load();
            //tabCon.Authors.Load();
            //tabCon.Status.Load();

            

            if (picture == null)
            {
                bAdd.Click += bClick_Add;
                bDel.Visible = false;
                this.Text = "Добавление автора";
            }
            else
            {
                str = picture.InventoryNumber;
                tbInvNum.Text = picture.InventoryNumber;
                tbName.Text = picture.Name;
                dTPYearOfWriting.Value = picture.Year;
                tbPrice.Text = picture.Cost.ToString();
                bAdd.Click += bClick_Edit;
                this.Text = "Редактирование жанра";
                bAdd.Text = "Изменить";
            }
        }

        private void bClick_Add(object sender, EventArgs e)
        {
            if (tbInvNum.Text != "")
            {
                if (NonRelapse.PictureNR(tbInvNum.Text))
                {
                    picture = new Pictures
                    {
                        InventoryNumber = tbInvNum.Text,
                        Name = tbName.Text,
                        Authors = (Authors)cbAuthor.SelectedItem,
                        Year = dTPYearOfWriting.Value,
                        PictureGenre = (Genres)cbGenre.SelectedItem,
                        Cost = 10
                    };

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
                MessageBox.Show("Инвентарный номер не может быть пустым.");
            }
        }

        //
        //РЕДАКТИРОВАТЬ
        //
        private void bClick_Edit(object sender, EventArgs e)
        {
            if (tbInvNum.Text != "")
            {
                if (str == tbInvNum.Text)
                {
                    picture.Name = tbName.Text;
                    picture.Authors = (Authors)cbAuthor.SelectedItem;
                    picture.Year = dTPYearOfWriting.Value;
                    picture.PictureGenre = (Genres)cbGenre.SelectedItem;
                    picture.Cost = 12;
                }
                else
                {
                    if (NonRelapse.PictureNR(tbInvNum.Text))
                    {
                        picture.InventoryNumber = tbInvNum.Text;
                        picture.Name = tbName.Text;
                        picture.Authors = (Authors)cbAuthor.SelectedItem;
                        picture.Year = dTPYearOfWriting.Value;
                        picture.PictureGenre = (Genres)cbGenre.SelectedItem;
                        picture.Cost = 12;
                    }
                    else
                    {
                        DialogResult = DialogResult.None;
                        MessageBox.Show("Inv num с таким именем уже существует.");

                    }
                }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Inv num не может быть пустым.");
            }

        }

        private void bDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите удалить картину?";
            String caption = "Удаление";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
            }
        }

        private void tbInvNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbName.Focus();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') cbAuthor.Focus();
        }

        private void cbAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') dTPYearOfWriting.Focus();
        }

        private void dTPYearOfWriting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') cbGenre.Focus();
        }

        private void cbGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPrice.Focus();
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') cbStatus.Focus();
        }

        private void cbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') bAdd.Focus();
        }
    }
}
