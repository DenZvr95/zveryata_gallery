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
    public partial class FormExposition : Form
    {
        string str;
        public Expositions exposition;
        public FormExposition(Expositions exposition)
        {
            this.exposition = exposition;
            InitializeComponent();

            if (exposition == null)
            {
                bAdd.Click += bClick_Add;
                bDel.Visible = false;
                this.Text = "Добавление выставки";
            }
            else
            {
                tbName.Text = exposition.Name;
                tbAddress.Text = exposition.Address;
                dateBegin.Value = exposition.BeginData;
                dateEnd.Value = exposition.EndData;
                str = exposition.Name;
                bAdd.Click += bClick_Edit;
                this.Text = "Редактирование выставки";
                bAdd.Text = "Изменить";
            }
        }

        //
        //ДОБАВИТЬ
        //
        private void bClick_Add(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if (NonRelapse.ExpositionsNR(tbName.Text))
                {
                    if (Validation.DataCheck(dateBegin.Value, dateEnd.Value))
                    {
                        exposition = new Expositions
                        {
                            Name = tbName.Text,
                            Address = tbAddress.Text,
                            BeginData = dateBegin.Value,
                            EndData = dateEnd.Value
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
                    MessageBox.Show("Такая выставка уже существует.");
                }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Название выставки не может быть пустым.");
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
                    if (Validation.DataCheck(dateBegin.Value, dateEnd.Value))
                    {
                        exposition.Address = tbAddress.Text;
                        exposition.BeginData = dateBegin.Value;
                        exposition.EndData = dateEnd.Value;
                    }
                    else
                    {
                        DialogResult = DialogResult.None;
                        MessageBox.Show("Даты введены некорректно!");
                    }
                }
                else
                {
                    if (NonRelapse.ExpositionsNR(tbName.Text))
                    {
                        if (Validation.DataCheck(dateBegin.Value, dateEnd.Value))
                        {
                            exposition.Name = tbName.Text;
                            exposition.Address = tbAddress.Text;
                            exposition.BeginData = dateBegin.Value;
                            exposition.EndData = dateEnd.Value;
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
                        MessageBox.Show("Выставка с таким названием уже существует.");

                    }
                }
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Название выставки не может быть пустым.");
            }

        }

        //
        //Удалить
        //
        private void bDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите удалить экспозицию?";
            String caption = "Удаление";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') tbAddress.Focus();
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') dateBegin.Focus();
        }

        private void dateBegin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') dateBegin.Focus();
        }

        private void dateEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') bAdd.Focus();
        }
    }
}
