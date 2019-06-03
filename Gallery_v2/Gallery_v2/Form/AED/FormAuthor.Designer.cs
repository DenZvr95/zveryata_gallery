namespace Gallery_v2
{
    partial class FormAuthor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateDied = new System.Windows.Forms.DateTimePicker();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.lDied = new System.Windows.Forms.Label();
            this.lBorn = new System.Windows.Forms.Label();
            this.lAuthorname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bDel = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateDied
            // 
            this.dateDied.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateDied.Font = new System.Drawing.Font("Verdana", 11F);
            this.dateDied.Location = new System.Drawing.Point(168, 142);
            this.dateDied.Name = "dateDied";
            this.dateDied.Size = new System.Drawing.Size(200, 25);
            this.dateDied.TabIndex = 3;
            this.dateDied.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateDied_KeyPress);
            // 
            // dateBorn
            // 
            this.dateBorn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBorn.Font = new System.Drawing.Font("Verdana", 11F);
            this.dateBorn.Location = new System.Drawing.Point(168, 107);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(200, 25);
            this.dateBorn.TabIndex = 2;
            this.dateBorn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateBorn_KeyPress);
            // 
            // lDied
            // 
            this.lDied.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lDied.AutoSize = true;
            this.lDied.BackColor = System.Drawing.Color.Transparent;
            this.lDied.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDied.ForeColor = System.Drawing.Color.Black;
            this.lDied.Location = new System.Drawing.Point(51, 147);
            this.lDied.Name = "lDied";
            this.lDied.Size = new System.Drawing.Size(117, 18);
            this.lDied.TabIndex = 16;
            this.lDied.Text = "Дата смерти:";
            // 
            // lBorn
            // 
            this.lBorn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBorn.AutoSize = true;
            this.lBorn.BackColor = System.Drawing.Color.Transparent;
            this.lBorn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBorn.ForeColor = System.Drawing.Color.Black;
            this.lBorn.Location = new System.Drawing.Point(19, 112);
            this.lBorn.Name = "lBorn";
            this.lBorn.Size = new System.Drawing.Size(143, 18);
            this.lBorn.TabIndex = 15;
            this.lBorn.Text = "Дата рождения:";
            // 
            // lAuthorname
            // 
            this.lAuthorname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lAuthorname.AutoSize = true;
            this.lAuthorname.BackColor = System.Drawing.Color.Transparent;
            this.lAuthorname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAuthorname.ForeColor = System.Drawing.Color.Black;
            this.lAuthorname.Location = new System.Drawing.Point(51, 74);
            this.lAuthorname.Name = "lAuthorname";
            this.lAuthorname.Size = new System.Drawing.Size(111, 18);
            this.lAuthorname.TabIndex = 14;
            this.lAuthorname.Text = "Имя автора:";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbName.Location = new System.Drawing.Point(168, 71);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(277, 25);
            this.tbName.TabIndex = 1;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 50);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Автор";
            // 
            // bDel
            // 
            this.bDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bDel.Font = new System.Drawing.Font("Verdana", 9F);
            this.bDel.Location = new System.Drawing.Point(181, 184);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(120, 30);
            this.bDel.TabIndex = 5;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.bCancel.Location = new System.Drawing.Point(307, 184);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(120, 30);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAdd.Font = new System.Drawing.Font("Verdana", 9F);
            this.bAdd.Location = new System.Drawing.Point(55, 184);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(120, 30);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "OK";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 236);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dateDied);
            this.Controls.Add(this.dateBorn);
            this.Controls.Add(this.lDied);
            this.Controls.Add(this.lBorn);
            this.Controls.Add(this.lAuthorname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(480, 275);
            this.Name = "FormAuthor";
            this.Text = "FormAuthor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DateTimePicker dateDied;
        protected internal System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.Label lDied;
        private System.Windows.Forms.Label lBorn;
        private System.Windows.Forms.Label lAuthorname;
        protected internal System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
    }
}