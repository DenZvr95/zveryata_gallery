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
    public partial class FormAuthorList : Form
    {
        Users sess;
        TableContext TabCon;

        public FormAuthorList(Users sess)
        {
            this.sess = sess;
            TabCon = new TableContext();
            InitializeComponent();
            if (DBFunction.Session(sess))
            {
                TabCon.Authors.Load();
                dGVAvtorList.DataSource = TabCon.Authors.Local.ToBindingList();
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
            FormAuthor addForm = new FormAuthor(null,sess);
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            //if (DBFunction.GenreAdd(addForm.tbName.Text, addForm.tbDescription.Text, TabCon))
            if (dbAdd.AuthorAdd(addForm.author, TabCon))
            {
                MessageBox.Show("Новый объект добавлен");
            }
            else
            {
                MessageBox.Show("Ай-ай");
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dGVAvtorList.SelectedRows.Count > 0)
            {
                int index = dGVAvtorList.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dGVAvtorList[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Authors author = TabCon.Authors.Find(id);
                FormAuthor editForm = new FormAuthor(author,sess);

                DialogResult result = editForm.ShowDialog(this);

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Abort:
                        dbDelete.AuthorDel(editForm.author, TabCon);
                        dGVAvtorList.Refresh();
                        break;
                    case DialogResult.OK:
                        dbEdit.AuthorEdit(author, editForm.author, TabCon);
                        dGVAvtorList.Refresh();
                        break;
                    default:
                        Console.WriteLine("Ой-ой");
                        break;
                }
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            
        }

        private void dGVAvtorList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }

        }

        private void dGVAvtorList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //handle the row selection on right click
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dGVAvtorList.CurrentCell = dGVAvtorList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    // Can leave these here - doesn't hurt
                    dGVAvtorList.Rows[e.RowIndex].Selected = true;
                    dGVAvtorList.Focus();

                    //selectedBiodataId = Convert.ToInt32(dGVAvtorList.Rows[e.RowIndex].Cells[1].Value);
                }
                catch (Exception)
                {

                }
            }
        }

        private void bAutSearch_Click(object sender, EventArgs e)
        {
            var AutFilter = TabCon.Authors.Where(x => x.Name.Contains(tbAutFilter.Text)).ToList();
            dGVAvtorList.DataSource = AutFilter;
        }

        private void bAutSbros_Click(object sender, EventArgs e)
        {
            tbAutFilter.Text = null;

            TabCon = new TableContext();
            TabCon.Authors.Load();
            dGVAvtorList.DataSource = TabCon.Authors.Local.ToBindingList();
        }

        private void bBackUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
