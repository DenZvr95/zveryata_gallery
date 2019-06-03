namespace Gallery_v2
{
    partial class FormGenreList
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
            this.dGVGenreList = new System.Windows.Forms.DataGridView();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bBackGenre = new System.Windows.Forms.Button();
            this.tbGenFilter = new System.Windows.Forms.TextBox();
            this.tbGenFilter2 = new System.Windows.Forms.TextBox();
            this.bGenSearch = new System.Windows.Forms.Button();
            this.bGenSbros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDel
            // 
            this.bDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDel.Font = new System.Drawing.Font("Verdana", 9F);
            this.bDel.Location = new System.Drawing.Point(273, 304);
            this.bDel.Margin = new System.Windows.Forms.Padding(4);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(120, 30);
            this.bDel.TabIndex = 32;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEdit.Font = new System.Drawing.Font("Verdana", 9F);
            this.bEdit.Location = new System.Drawing.Point(141, 304);
            this.bEdit.Margin = new System.Windows.Forms.Padding(4);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(120, 30);
            this.bEdit.TabIndex = 31;
            this.bEdit.Text = "Редактировать";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAdd.Font = new System.Drawing.Font("Verdana", 9F);
            this.bAdd.Location = new System.Drawing.Point(13, 304);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(120, 30);
            this.bAdd.TabIndex = 30;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dGVGenreList
            // 
            this.dGVGenreList.AllowUserToAddRows = false;
            this.dGVGenreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVGenreList.AutoGenerateColumns = false;
            this.dGVGenreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGenreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dGVGenreList.DataSource = this.genresBindingSource;
            this.dGVGenreList.Location = new System.Drawing.Point(13, 130);
            this.dGVGenreList.Margin = new System.Windows.Forms.Padding(4);
            this.dGVGenreList.Name = "dGVGenreList";
            this.dGVGenreList.ReadOnly = true;
            this.dGVGenreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVGenreList.Size = new System.Drawing.Size(520, 166);
            this.dGVGenreList.TabIndex = 29;
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            this.genreIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 275;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataSource = typeof(Gallery_v2.Genres);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bBackGenre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 62);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(138, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список жанров";
            // 
            // bBackGenre
            // 
            this.bBackGenre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBackGenre.Location = new System.Drawing.Point(16, 21);
            this.bBackGenre.Margin = new System.Windows.Forms.Padding(4);
            this.bBackGenre.Name = "bBackGenre";
            this.bBackGenre.Size = new System.Drawing.Size(92, 30);
            this.bBackGenre.TabIndex = 23;
            this.bBackGenre.Text = "Назад";
            this.bBackGenre.UseVisualStyleBackColor = true;
            this.bBackGenre.Click += new System.EventHandler(this.bBackGenre_Click);
            // 
            // tbGenFilter
            // 
            this.tbGenFilter.Location = new System.Drawing.Point(16, 93);
            this.tbGenFilter.Name = "tbGenFilter";
            this.tbGenFilter.Size = new System.Drawing.Size(100, 24);
            this.tbGenFilter.TabIndex = 33;
            // 
            // tbGenFilter2
            // 
            this.tbGenFilter2.Location = new System.Drawing.Point(144, 93);
            this.tbGenFilter2.Name = "tbGenFilter2";
            this.tbGenFilter2.Size = new System.Drawing.Size(165, 24);
            this.tbGenFilter2.TabIndex = 34;
            // 
            // bGenSearch
            // 
            this.bGenSearch.Location = new System.Drawing.Point(340, 92);
            this.bGenSearch.Name = "bGenSearch";
            this.bGenSearch.Size = new System.Drawing.Size(75, 25);
            this.bGenSearch.TabIndex = 35;
            this.bGenSearch.Text = "Поиск";
            this.bGenSearch.UseVisualStyleBackColor = true;
            this.bGenSearch.Click += new System.EventHandler(this.bGenSearch_Click);
            // 
            // bGenSbros
            // 
            this.bGenSbros.Location = new System.Drawing.Point(430, 92);
            this.bGenSbros.Name = "bGenSbros";
            this.bGenSbros.Size = new System.Drawing.Size(75, 25);
            this.bGenSbros.TabIndex = 36;
            this.bGenSbros.Text = "Сброс";
            this.bGenSbros.UseVisualStyleBackColor = true;
            this.bGenSbros.Click += new System.EventHandler(this.bGenSbros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Описание:";
            // 
            // FormGenreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bGenSbros);
            this.Controls.Add(this.bGenSearch);
            this.Controls.Add(this.tbGenFilter2);
            this.Controls.Add(this.tbGenFilter);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dGVGenreList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(568, 395);
            this.Name = "FormGenreList";
            this.Text = "Список жанров";
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenreList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DataGridView dGVGenreList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBackGenre;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private System.Windows.Forms.TextBox tbGenFilter;
        private System.Windows.Forms.TextBox tbGenFilter2;
        private System.Windows.Forms.Button bGenSearch;
        private System.Windows.Forms.Button bGenSbros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}