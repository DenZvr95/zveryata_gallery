namespace Gallery_v2
{
    partial class FormPicture
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
            this.dTPYearOfWriting = new System.Windows.Forms.DateTimePicker();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbInvNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bDel = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTPYearOfWriting
            // 
            this.dTPYearOfWriting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTPYearOfWriting.Font = new System.Drawing.Font("Verdana", 11F);
            this.dTPYearOfWriting.Location = new System.Drawing.Point(151, 186);
            this.dTPYearOfWriting.Name = "dTPYearOfWriting";
            this.dTPYearOfWriting.Size = new System.Drawing.Size(259, 25);
            this.dTPYearOfWriting.TabIndex = 4;
            this.dTPYearOfWriting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dTPYearOfWriting_KeyPress);
            // 
            // cbGenre
            // 
            this.cbGenre.AllowDrop = true;
            this.cbGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGenre.Font = new System.Drawing.Font("Verdana", 11F);
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.ItemHeight = 18;
            this.cbGenre.Location = new System.Drawing.Point(151, 226);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(259, 26);
            this.cbGenre.TabIndex = 5;
            this.cbGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGenre_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbName.Location = new System.Drawing.Point(151, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(259, 25);
            this.tbName.TabIndex = 2;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Название:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 50);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Картина";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrice.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbPrice.Location = new System.Drawing.Point(151, 266);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(259, 25);
            this.tbPrice.TabIndex = 6;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbInvNum
            // 
            this.tbInvNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInvNum.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbInvNum.Location = new System.Drawing.Point(151, 66);
            this.tbInvNum.Name = "tbInvNum";
            this.tbInvNum.Size = new System.Drawing.Size(259, 25);
            this.tbInvNum.TabIndex = 1;
            this.tbInvNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInvNum_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(92, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Цена:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(83, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Жанр:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Год написания:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(79, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Автор:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Статус:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Инвентарный\r\nномер:";
            // 
            // bDel
            // 
            this.bDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bDel.Font = new System.Drawing.Font("Verdana", 9F);
            this.bDel.Location = new System.Drawing.Point(151, 349);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(120, 30);
            this.bDel.TabIndex = 9;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.bCancel.Location = new System.Drawing.Point(290, 349);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(120, 30);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAdd.Font = new System.Drawing.Font("Verdana", 9F);
            this.bAdd.Location = new System.Drawing.Point(9, 349);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(120, 30);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "OK";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // cbAuthor
            // 
            this.cbAuthor.AllowDrop = true;
            this.cbAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAuthor.Font = new System.Drawing.Font("Verdana", 11F);
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.ItemHeight = 18;
            this.cbAuthor.Location = new System.Drawing.Point(151, 145);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(259, 26);
            this.cbAuthor.Sorted = true;
            this.cbAuthor.TabIndex = 3;
            this.cbAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAuthor_KeyPress);
            // 
            // cbStatus
            // 
            this.cbStatus.AllowDrop = true;
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.Font = new System.Drawing.Font("Verdana", 11F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.ItemHeight = 18;
            this.cbStatus.Location = new System.Drawing.Point(151, 304);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(259, 26);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbStatus_KeyPress);
            // 
            // FormPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 391);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dTPYearOfWriting);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbInvNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(450, 430);
            this.Name = "FormPicture";
            this.Text = "FormPicture";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DateTimePicker dTPYearOfWriting;
        protected internal System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox tbPrice;
        protected internal System.Windows.Forms.TextBox tbInvNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        protected internal System.Windows.Forms.ComboBox cbAuthor;
        protected internal System.Windows.Forms.ComboBox cbGenre;
        protected internal System.Windows.Forms.ComboBox cbStatus;
    }
}