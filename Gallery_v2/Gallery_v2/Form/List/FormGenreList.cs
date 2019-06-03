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
    public partial class FormGenreList : Form
    {
        Users sess;
        TableContext TabCon;
        public FormGenreList(Users sess)
        {
            this.sess = sess;
            TabCon = new TableContext();
            InitializeComponent();
            if (DBFunction.Session(sess))
            {
                TabCon.Genres.Load();
                dGVGenreList.DataSource = TabCon.Genres.Local.ToBindingList();
                bDel.Visible = false;
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

        private void bAdd_Click(object sender, EventArgs e)
        {
            FormGenre addForm = new FormGenre(null,sess);
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            //if (DBFunction.GenreAdd(addForm.tbName.Text, addForm.tbDescription.Text, TabCon))
            if (dbAdd.GenreAdd(addForm.genre, TabCon))
            {
                MessageBox.Show("Новый объект добавлен");
            }
            else
            {
                MessageBox.Show("Ай-ай");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dGVGenreList.SelectedRows.Count > 0)
            {
                //int index = dGVGenreList.SelectedRows[0].Index;
                //int id = 0;
                //bool converted = Int32.TryParse(dGVGenreList[0, index].Value.ToString(), out id);
                //if (converted == false)
                //    return;

                //if (DBFunction.GenreDel(id, TabCon))
                //{
                //    MessageBox.Show("Объект удален");
                //}
                //else
                //{
                //    MessageBox.Show("ой-ой");
                //}
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dGVGenreList.SelectedRows.Count > 0)
            {
                int index = dGVGenreList.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dGVGenreList[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Genres genres = TabCon.Genres.Find(id);
                FormGenre editForm = new FormGenre(genres,sess);

                DialogResult result = editForm.ShowDialog(this);

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Abort:
                        dbDelete.GenreDel(editForm.genre, TabCon);
                        dGVGenreList.Refresh();
                        break;
                    case DialogResult.OK:
                        dbEdit.GenreEdit(genres, editForm.genre, TabCon);
                        dGVGenreList.Refresh();
                        break;
                    default:
                        Console.WriteLine("Ой-ой");
                        break;
                }                
            }
        }

        private void bBackGenre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGenSearch_Click(object sender, EventArgs e)
        {
            var GenFilter = TabCon.Genres.Where(x => x.Name.Contains(tbGenFilter.Text)).Where(x => x.Description.Contains(tbGenFilter2.Text)).ToList();
            dGVGenreList.DataSource = GenFilter;
        }

        private void bGenSbros_Click(object sender, EventArgs e)
        {
            tbGenFilter.Text = null;
            tbGenFilter2.Text = null;

            TabCon = new TableContext();
            TabCon.Genres.Load();
            dGVGenreList.DataSource = TabCon.Genres.Local.ToBindingList();
        }
    }
}
