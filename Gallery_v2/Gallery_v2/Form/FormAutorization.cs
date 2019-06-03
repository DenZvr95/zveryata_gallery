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
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        //private void DataRefresh()
        //{
        //    db = new TableContext();
        //    db.Pictures.Include("Status").Load();
        //    dGVPicturesList.DataSource = db.Pictures.Local.ToBindingList();
        //    dGVPicturesList.Refresh();
        //}

        private void bInput_Click(object sender, EventArgs e)
        {
            Users user;
            if ((user=DBFunction.Auth(tbLogin.Text, tbPassword.Text)) != null)
            {
                FormMain formMain = new FormMain(user);
                formMain.Show();
                formMain.Closed += (s, Args) => this.Close();
                this.Hide();
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            this.Close();
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbPassword.Focus();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') bInput.Focus();
        }

    }
}
