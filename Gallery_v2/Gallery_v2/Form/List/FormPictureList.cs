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
    public partial class FormPictureList : Form
    {
        public int id = 0;
        TableContext db;
        Expositions expos;
        public FormPictureList(Expositions expositions)
        {
            this.expos = expositions;
            InitializeComponent();
            db = new TableContext();
            db.Pictures.Include("Status").Load();
            dGVPictures.DataSource = db.Pictures.Local.ToBindingList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            int index = dGVPictures.SelectedRows[0].Index;
            id = 0;
            bool converted = Int32.TryParse(dGVPictures[0, index].Value.ToString(), out id);
            if (converted == false)
                return;


            List<ExpToPic> exps = db.ExpToPics.Where(c => c.IdPic == id).ToList();
            foreach (var item in exps)
            {

                bool lowBeginData = Validation.DataCheck(expos.EndData, item.Exposition.BeginData);
                bool lowEndData   = Validation.DataCheck(expos.EndData, item.Exposition.BeginData);

                bool hingBeginData = Validation.DataCheck(item.Exposition.EndData, expos.BeginData);
                bool hingEndData   = Validation.DataCheck(item.Exposition.EndData, expos.BeginData);


                if ( !( (lowBeginData && lowEndData ) || (hingBeginData && hingEndData) ) )
                {
                    MessageBox.Show("Картина уже зарезервирована - " + item.Exposition.Name + " " +
                        item.Exposition.BeginData + " - " + item.Exposition.EndData);
                    DialogResult = DialogResult.None;
                    break;
                }

            }
        
        }

    }
}
