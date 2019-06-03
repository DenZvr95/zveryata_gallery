namespace Gallery_v2
{
    partial class FormAuthorList
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
            this.components = new System.ComponentModel.Container();
            this.bDel = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.dGVAvtorList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBackUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAutFilter = new System.Windows.Forms.TextBox();
            this.bAutSearch = new System.Windows.Forms.Button();
            this.bAutSbros = new System.Windows.Forms.Button();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAvtorList)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDel
            // 
            this.bDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDel.Font = new System.Drawing.Font("Verdana", 9F);
            this.bDel.Location = new System.Drawing.Point(284, 313);
            this.bDel.Margin = new System.Windows.Forms.Padding(4);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(120, 30);
            this.bDel.TabIndex = 10;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEdit.Font = new System.Drawing.Font("Verdana", 9F);
            this.bEdit.Location = new System.Drawing.Point(156, 313);
            this.bEdit.Margin = new System.Windows.Forms.Padding(4);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(120, 30);
            this.bEdit.TabIndex = 9;
            this.bEdit.Text = "Редактировать";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAdd.Font = new System.Drawing.Font("Verdana", 9F);
            this.bAdd.Location = new System.Drawing.Point(28, 313);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(120, 30);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dGVAvtorList
            // 
            this.dGVAvtorList.AllowUserToAddRows = false;
            this.dGVAvtorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVAvtorList.AutoGenerateColumns = false;
            this.dGVAvtorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAvtorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bornDataGridViewTextBoxColumn,
            this.diedDataGridViewTextBoxColumn});
            this.dGVAvtorList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dGVAvtorList.DataSource = this.authorsBindingSource;
            this.dGVAvtorList.Location = new System.Drawing.Point(13, 130);
            this.dGVAvtorList.Margin = new System.Windows.Forms.Padding(4);
            this.dGVAvtorList.Name = "dGVAvtorList";
            this.dGVAvtorList.ReadOnly = true;
            this.dGVAvtorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVAvtorList.Size = new System.Drawing.Size(520, 166);
            this.dGVAvtorList.TabIndex = 7;
            this.dGVAvtorList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVAvtorList_CellMouseDown);
            this.dGVAvtorList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dGVAvtorList_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.bBackUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 62);
            this.panel1.TabIndex = 6;
            // 
            // bBackUser
            // 
            this.bBackUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bBackUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBackUser.Location = new System.Drawing.Point(16, 21);
            this.bBackUser.Margin = new System.Windows.Forms.Padding(4);
            this.bBackUser.Name = "bBackUser";
            this.bBackUser.Size = new System.Drawing.Size(92, 30);
            this.bBackUser.TabIndex = 25;
            this.bBackUser.Text = "Назад";
            this.bBackUser.UseVisualStyleBackColor = true;
            this.bBackUser.Click += new System.EventHandler(this.bBackUser_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список художников";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 70);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.bDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Имя:";
            // 
            // tbAutFilter
            // 
            this.tbAutFilter.Location = new System.Drawing.Point(16, 93);
            this.tbAutFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbAutFilter.Name = "tbAutFilter";
            this.tbAutFilter.Size = new System.Drawing.Size(167, 24);
            this.tbAutFilter.TabIndex = 40;
            // 
            // bAutSearch
            // 
            this.bAutSearch.Location = new System.Drawing.Point(340, 92);
            this.bAutSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bAutSearch.Name = "bAutSearch";
            this.bAutSearch.Size = new System.Drawing.Size(75, 25);
            this.bAutSearch.TabIndex = 46;
            this.bAutSearch.Text = "Поиск";
            this.bAutSearch.UseVisualStyleBackColor = true;
            this.bAutSearch.Click += new System.EventHandler(this.bAutSearch_Click);
            // 
            // bAutSbros
            // 
            this.bAutSbros.Location = new System.Drawing.Point(430, 92);
            this.bAutSbros.Name = "bAutSbros";
            this.bAutSbros.Size = new System.Drawing.Size(75, 25);
            this.bAutSbros.TabIndex = 47;
            this.bAutSbros.Text = "Сброс";
            this.bAutSbros.UseVisualStyleBackColor = true;
            this.bAutSbros.Click += new System.EventHandler(this.bAutSbros_Click);
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataSource = typeof(Gallery_v2.Authors);
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            this.authorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя художника";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 215;
            // 
            // bornDataGridViewTextBoxColumn
            // 
            this.bornDataGridViewTextBoxColumn.DataPropertyName = "Born";
            this.bornDataGridViewTextBoxColumn.HeaderText = "Родился";
            this.bornDataGridViewTextBoxColumn.Name = "bornDataGridViewTextBoxColumn";
            this.bornDataGridViewTextBoxColumn.ReadOnly = true;
            this.bornDataGridViewTextBoxColumn.Width = 130;
            // 
            // diedDataGridViewTextBoxColumn
            // 
            this.diedDataGridViewTextBoxColumn.DataPropertyName = "Died";
            this.diedDataGridViewTextBoxColumn.HeaderText = "Умер";
            this.diedDataGridViewTextBoxColumn.Name = "diedDataGridViewTextBoxColumn";
            this.diedDataGridViewTextBoxColumn.ReadOnly = true;
            this.diedDataGridViewTextBoxColumn.Width = 130;
            // 
            // FormAuthorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 356);
            this.Controls.Add(this.bAutSbros);
            this.Controls.Add(this.dGVAvtorList);
            this.Controls.Add(this.bAutSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAutFilter);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(568, 395);
            this.Name = "FormAuthorList";
            this.Text = "Список художников";
            ((System.ComponentModel.ISupportInitialize)(this.dGVAvtorList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DataGridView dGVAvtorList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBackUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAutFilter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.Button bAutSearch;
        private System.Windows.Forms.Button bAutSbros;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diedDataGridViewTextBoxColumn;
    }
}