using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Gallery_v2
{
    public partial class FormMain : Form
    {
        List<ExpToPic> expToPics;
        Expositions expos;
        Users sess;
        TableContext db;
        public FormMain(Users sess)
        {
            this.sess = sess;
            InitializeComponent();
            
            if (DBFunction.Session(sess))
            {
                db = new TableContext();

                fillchbox();
                bPicSbros_Click(null, null);

                dtPicker.Format = DateTimePickerFormat.Custom;
                dtPicker.CustomFormat = "yyyy";
                dtPicker.ShowUpDown = true;

                switch (sess.Position.Position)
                {
                    case "Администратор":
                        db.Pictures.Include("Status").Load();
                        dGVPicturesList.DataSource = db.Pictures.Local.ToBindingList();
                        dGVPicturesList.Columns[4].DefaultCellStyle.Format = "yyyy";
                        db.Expositions.Load();
                        dGVExpositionList.DataSource = db.Expositions.Local.ToBindingList();
                        CbExposition_Refresh();
                        cbExposition_SelectionChangeCommitted(null, null);
                        db.Users.Include("Position").Load();
                        db.Users.Load();
                        dGVUserList.DataSource = db.Users.Local.ToBindingList();
                        break;
                    case "Реставратор":
                        db.Pictures.Include("Status").Load();
                        dGVPicturesList.DataSource = db.Pictures.Local.ToBindingList();
                        dGVPicturesList.Columns[4].DefaultCellStyle.Format = "yyyy";

                        tabControl3.TabPages.Remove(tabPageExpToPic);
                        tabControl3.TabPages.Remove(tabPageExp);
                        tabControl3.TabPages.Remove(tabPageUser);
                        bGenre.Visible = false;
                        break;
                    case "Помошник администратора":
                        db.Pictures.Include("Status").Load();
                        dGVPicturesList.DataSource = db.Pictures.Local.ToBindingList();
                        dGVPicturesList.Columns[4].DefaultCellStyle.Format = "yyyy";
                        db.Expositions.Load();
                        dGVExpositionList.DataSource = db.Expositions.Local.ToBindingList();
                        CbExposition_Refresh();
                        cbExposition_SelectionChangeCommitted(null, null);
                        break;
                    case "Директор":
                        db.Pictures.Include("Status").Load();
                        dGVPicturesList.DataSource = db.Pictures.Local.ToBindingList();
                        dGVPicturesList.Columns[4].DefaultCellStyle.Format = "yyyy";
                        tabControl3.TabPages.Remove(tabPageExpToPic);
                        tabControl3.TabPages.Remove(tabPageExp);
                        tabControl3.TabPages.Remove(tabPageUser);
                        bGenre.Visible = false;
                        break;
                    default:
                        Console.WriteLine("Ой-ой");
                        break;
                }
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


        //
        //
        //
        public void fillchbox()
        {
            db = new TableContext();
            cbPicFilter.DataSource = db.Statuses.ToList<Statuses>();
            cbPicFilter.ValueMember = "Status";
            cbPicFilter.DisplayMember = "Status";

        }

        //
        //ВЫХОД
        //
        private void bExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                FormAutorization formAuth = new FormAutorization();
                formAuth.Show();
                formAuth.Closed += (s, Args) => this.Close();
                this.Hide();
            }

        }

        //
        //Добавление картин
        //
        private void bAddPic_Click(object sender, EventArgs e)
        {
            FormPicture addForm = new FormPicture(null);

            List<Authors> authors = db.Authors.ToList();
            addForm.cbAuthor.DataSource = authors;
            addForm.cbAuthor.ValueMember = "AuthorId";
            addForm.cbAuthor.DisplayMember = "Name";

            List<Genres> genres = db.Genres.ToList();
            addForm.cbGenre.DataSource = genres;
            addForm.cbGenre.ValueMember = "GenreId";
            addForm.cbGenre.DisplayMember = "Name";

            db.Statuses.Load();
            var fibNumbers = db.Statuses.Local.ToList();
            foreach (Statuses rrr in fibNumbers)
            {
                addForm.cbStatus.Items.Add(rrr.Status);
            }

            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            addForm.picture.Status = db.Statuses.Find(addForm.cbStatus.SelectedItem.ToString());
            if (dbAdd.PictureAdd(addForm.picture, db))
            {
                MessageBox.Show("Новый объект добавлен");
            }
            else
            {
                MessageBox.Show("Ай-ай");
            }
        }

        //
        //Редактирование картин
        //
        private void bEditPic_Click(object sender, EventArgs e)
        {
            int id = IdConverter(dGVPicturesList);
            if (id > 0)
            {
                Pictures pictures = db.Pictures.Find(id);
                FormPicture editForm = new FormPicture(pictures);

                List<Authors> authors = db.Authors.ToList();
                editForm.cbAuthor.DataSource = authors;
                editForm.cbAuthor.ValueMember = "AuthorId";
                editForm.cbAuthor.DisplayMember = "Name";
                editForm.cbAuthor.SelectedItem = editForm.picture.Authors;

                List<Genres> genres = db.Genres.ToList();
                editForm.cbGenre.DataSource = genres;
                editForm.cbGenre.ValueMember = "GenreId";
                editForm.cbGenre.DisplayMember = "Name";
                editForm.cbGenre.SelectedItem = editForm.picture.PictureGenre;

                db.Statuses.Load();
                var fibNumbers = db.Statuses.Local.ToList();
                foreach (Statuses rrr in fibNumbers)
                {
                    editForm.cbStatus.Items.Add(rrr.Status);
                }

                editForm.cbStatus.SelectedItem = editForm.picture.Status.ToString();

                DialogResult result = editForm.ShowDialog(this);

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Abort:
                        dbDelete.PictureDel(editForm.picture, db);
                        dGVPicturesList.Refresh();
                        break;
                    case DialogResult.OK:
                        editForm.picture.Status = db.Statuses.Find(editForm.cbStatus.SelectedItem.ToString());
                        dbEdit.PicturesEdit(pictures, editForm.picture, db);
                        dGVPicturesList.Refresh();
                        break;
                    default:
                        Console.WriteLine("Ой-ой");
                        break;
                }
            }
        }

        //
        //Добавление экспозиций
        //
        private void bAddExp_Click(object sender, EventArgs e)
        {
            FormExposition addForm = new FormExposition(null);
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            if (dbAdd.ExpositionAdd(addForm.exposition, db))
            {
                dGVExpositionList.Refresh();
                CbExposition_Refresh();
                MessageBox.Show("Новый объект добавлен");
            }
            else
            {
                MessageBox.Show("Ай-ай");
            }
        }

        //
        //Редактирование экспозиций
        //
        private void bEditExp_Click(object sender, EventArgs e)
        {
            int id = IdConverter(dGVExpositionList);
            if (id > 0)
            {
                Expositions exposition = db.Expositions.Find(id);
                FormExposition editForm = new FormExposition(exposition);

                DialogResult result = editForm.ShowDialog(this);

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Abort:
                        dbDelete.ExpositionDel(editForm.exposition, db);
                        cbExposition_SelectionChangeCommitted(null, null);
                        CbExposition_Refresh();
                        dGVExpositionList.Refresh();
                        break;
                    case DialogResult.OK:
                        dbEdit.ExpositionEdit(exposition, editForm.exposition, db);
                        CbExposition_Refresh();
                        dGVExpositionList.Refresh();
                        break;
                    default:
                        Console.WriteLine("Ой-ой");
                        break;
                }
            }
        }

        //
        //Добавление пользователей
        //
        private void bAddUser_Click(object sender, EventArgs e)
        {
            FormUser addForm = new FormUser(null);  

            db.Positions.Load();
            var fibNumbers = db.Positions.Local.ToList();
            foreach (Positions rrr in fibNumbers)
            {
                addForm.cbPosition.Items.Add(rrr.Position);
            }

            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            addForm.user.Position = db.Positions.Find(addForm.cbPosition.SelectedItem.ToString());
            if (dbAdd.UserAdd(addForm.user, db))
            {
                MessageBox.Show("Новый объект добавлен");
            }
            else
            {
                MessageBox.Show("Ай-ай");
            }
        }

        //
        //Редактирование Пользователей
        //
        private void bEditUser_Click(object sender, EventArgs e)
        {
            int id = IdConverter(dGVUserList);
            if (id > 0)
            {
            
                Users user = db.Users.Find(id);
                FormUser editForm = new FormUser(user);

                db.Positions.Load();
                var fibNumbers = db.Positions.Local.ToList();
                foreach (Positions rrr in fibNumbers)
                {
                    editForm.cbPosition.Items.Add(rrr.Position);
                }

                editForm.cbPosition.SelectedItem = editForm.user.Position.ToString();

                DialogResult result = editForm.ShowDialog(this);

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Abort:
                        dbDelete.UserDel(editForm.user, db);
                        dGVUserList.Refresh();
                        break;
                    case DialogResult.OK:
                        editForm.user.Position = db.Positions.Find(editForm.cbPosition.SelectedItem.ToString());
                        dbEdit.UserEdit(user, editForm.user, db);
                        dGVUserList.Refresh();
                        break;
                    default:
                        Console.WriteLine("Ой-ой");
                        break;
                }
            }
        }

        //
        //Список Авторов
        //
        private void bAvtorList_Click(object sender, EventArgs e)
        {
            FormAuthorList form = new FormAuthorList(sess);
            form.Show();
        }

        //
        //Список Жанров
        //
        private void bGenre_Click(object sender, EventArgs e)
        {
            FormGenreList form = new FormGenreList(sess);
            form.Show();
        }

        //
        //Поиск картин
        //
        private void bPicSearch_Click(object sender, EventArgs e)
        {

            if (dtPicker.Value.Year == 1753 && dtPicker.Value.Month == 01 && dtPicker.Value.Day == 01)
            {
                var PicFilter = db.Pictures.Include("Authors").Where(x => x.Name.Contains(tbPicFilter.Text)).Where(x => x.Authors.Name.Contains(tbPicFilter2.Text)).Where(x => x.Status.Status.Contains(cbPicFilter.Text)).ToList();
                dGVPicturesList.DataSource = PicFilter;
            }
            else
            {
                var PicFilter = db.Pictures.Include("Authors").Where(x => x.Name.Contains(tbPicFilter.Text)).Where(x => x.Authors.Name.Contains(tbPicFilter2.Text)).Where(x => x.Status.Status.Contains(cbPicFilter.Text)).Where(x => x.Year.Year == dtPicker.Value.Year).ToList();
                dGVPicturesList.DataSource = PicFilter;
            }
    
        }

        //
        //Сброс поиска картин
        //
        private void bPicSbros_Click(object sender, EventArgs e)
        {
            tbPicFilter.Text = null;
            tbPicFilter2.Text = null;
            dtPicker.Value = new DateTime(1753, 01, 01);
            cbPicFilter.Text = null;

            db = new TableContext();
            db.Pictures.Include("Status").Load();
            dGVPicturesList.DataSource = db.Pictures.Local.ToBindingList();

        }

        //
        //Поиск экспозиций
        //
        private void bExpSearch_Click(object sender, EventArgs e)
        {
            var ExpFilter = db.Expositions.Where(x => x.BeginData >= dtExpFilter1.Value && x.EndData <= dtExpFilter2.Value).ToList();

            dGVExpositionList.DataSource = ExpFilter;

        }

        //
        //Поиск Экспозиций
        //
        private void bExpSbros_Click(object sender, EventArgs e)
        {
            tbExpFilter.Text = null;
            tbExpFilter2.Text = null;
            db = new TableContext();
            db.Expositions.Load();
            dGVExpositionList.DataSource = db.Expositions.Local.ToBindingList();
        }

        //Поиск пользователей
        private void bUsrSearch_Click(object sender, EventArgs e)
        {
            var UsrFilter = db.Users.Where(x => x.Surname.Contains(tbUsrFilter.Text)).Where(x => x.FirstName.Contains(tbUsrFilter2.Text)).Where(x => x.LastName.Contains(tbUsrFilter3.Text)).Where(x => x.Position.Position == cbUsrFilter.Text).ToList();
            dGVUserList.DataSource = UsrFilter;
        }

        //
        //Сброс поиска пользователей
        //
        private void bUsrSbros_Click(object sender, EventArgs e)
        {
            tbUsrFilter.Text = null;
            tbUsrFilter2.Text = null;
            tbUsrFilter3.Text = null;
            cbUsrFilter.Text = null;

            db = new TableContext();
            db.Users.Include("Position").Load();
            dGVUserList.DataSource = db.Users.Local.ToBindingList();
        }

        //
        //КОНТЕКСТНЫЕ МЕНЮ
        //
        //
        //Контекстное меню картины
        //
        private void dGVPicturesList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dGVPicturesList.CurrentCell = dGVPicturesList.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    dGVPicturesList.Rows[e.RowIndex].Selected = true;
                    dGVPicturesList.Focus();
                }
                catch (Exception)
                {
                    
                }
            }
        }

        //
        //Удаление картины через контекстное меню 
        //
        private void contMenuPicDel_Click(object sender, EventArgs e)
        {
            int id = IdConverter(dGVPicturesList);
            if (id > 0)
            {
                MessageBoxButtons msb = MessageBoxButtons.YesNo;
                String message = "Вы действительно хотите удалить картину?";
                String caption = "Удаление";
                if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                {
                    Pictures pictures = db.Pictures.Find(id);
                    dbDelete.PictureDel(pictures, db);
                }
            }
        }

        //
        //Контекстное меню экспозиции
        //
        private void dGVExpositionList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dGVExpositionList.CurrentCell = dGVExpositionList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dGVExpositionList.Rows[e.RowIndex].Selected = true;
                    dGVExpositionList.Focus();
                }
                catch (Exception)
                {

                }
            }
        }

        //
        //Удаление экспозиции через контекстное меню 
        //
        private void tsmExpDel_Click(object sender, EventArgs e)
        {
            int id = IdConverter(dGVExpositionList);
            if (id > 0)
            {
                MessageBoxButtons msb = MessageBoxButtons.YesNo;
                String message = "Вы действительно хотите удалить экспозицию?";
                String caption = "Удаление";
                if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                {
                    Expositions expo = db.Expositions.Find(id);
                    dbDelete.ExpositionDel(expo, db);
                }
            }
        }

        //
        //Контекстное меню пользователей
        //
        private void dGVUserList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dGVUserList.CurrentCell = dGVUserList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    // Can leave these here - doesn't hurt
                    dGVUserList.Rows[e.RowIndex].Selected = true;
                    dGVUserList.Focus();
                    //selectedBiodataId = Convert.ToInt32(dGVAvtorList.Rows[e.RowIndex].Cells[1].Value);
                }
                catch (Exception)
                {

                }
            }
        }

        //
        //Контекстное Экспозиции -> Картины
        //
        private void dGVExpToPic_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dGVExpToPic.CurrentCell = dGVExpToPic.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dGVExpToPic.Rows[e.RowIndex].Selected = true;
                    dGVExpToPic.Focus();
                }
                catch (Exception)
                {

                }
            }
        }

        //
        //Удаление пользователя через контекстное меню 
        //
        private void tsmUserDel_Click(object sender, EventArgs e)
        {
            int id = IdConverter(dGVUserList);
            if (id > 0)
            {
                MessageBoxButtons msb = MessageBoxButtons.YesNo;
                String message = "Вы действительно хотите удалить польвателя?";
                String caption = "Удаление";
                if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                {
                    Users users = db.Users.Find(id);
                    dbDelete.UserDel(users, db);
                }
            }
        }

        //
        // Добавление связи экспозиции с картиной
        //
        private void bAddExpToPic_Click(object sender, EventArgs e)
        {
            
            FormPictureList addForm = new FormPictureList(expos);

            addForm.dGVPictures.DataSource = db.Pictures.Local
                .Where(c => c.Status.Status.Contains("На складе"))
                .Except( expToPics.Select(c => c.Picture) )
                .ToList();

            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            
            if (dbAdd.ExpToPicAdd(expos.Id , addForm.id , db))
            {
                cbExposition_SelectionChangeCommitted(null, null);
                dGVExpToPic.Refresh();
            }
            else
            {
                MessageBox.Show("Ай-ай");
            }
        }

        //
        // Удаление связи экспозиции с картиной
        //
        private void bDelExpToPic_Click(object sender, EventArgs e)
        {
            int id = IdConverter(dGVExpToPic);
            if (id > 0)
            {
                dbDelete.DelExpToPic(expos.Id, id, db);
                cbExposition_SelectionChangeCommitted(null, null);
                dGVExpToPic.Refresh();
            }
        }

        //
        // Обновление списка картин на экспозиции
        //
        private void cbExposition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            expos = (Expositions)cbExposition.SelectedItem;
            expToPics = db.ExpToPics.Where(c => c.IdExp == (int)cbExposition.SelectedValue).ToList();
            dGVExpToPic.DataSource = expToPics;
            dGVExpToPic.Refresh();
        }

        //
        // Обновление списка экспозиций
        //
        private void CbExposition_Refresh()
        { 
            List<Expositions> exp = db.Expositions.Local.ToList();
            cbExposition.DataSource = exp;
            cbExposition.ValueMember = "id";
            cbExposition.DisplayMember = "Name";
            dGVExpToPic.Refresh();
        }

        //
        // Перебор DGV
        //
        private int IdConverter(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int index = dataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return 0;
                //dataGridView.Rows[3].Selected = true;
                return id;
            }
            return 0;
        }

        //
        //Отчет по картинам
        //
        private void bPicReport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Отчет";
            // storing header part in Excel  
            int cell = 1;
            for (int i = 0; i < dGVPicturesList.Columns.Count; i++)
            {
                if (dGVPicturesList.Columns[i].Visible == true)
                {
                    worksheet.Cells[1, cell] = dGVPicturesList.Columns[i].HeaderText;
                    cell++;

                }
            }

            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dGVPicturesList.Rows.Count; i++)
            {
                for (int j = 0; j < dGVPicturesList.Columns.Count - 2; j++)
                {
                    if (dGVPicturesList.Columns[j].Visible == true)
                    {
                        worksheet.Cells[i + 2, j] = dGVPicturesList.Rows[i].Cells[j].Value.ToString();
                    }
                }

            }

            Excel.Range cellRange = (Excel.Range)worksheet.Cells[1, 1];
            Excel.Range rowRange = cellRange.EntireRow;
            Excel.Range colRange = cellRange.EntireColumn;
            rowRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            colRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            Excel.Range excelCells = (Excel.Range)worksheet.get_Range("B1", "H1").Cells;
            excelCells.Merge(Type.Missing);
            excelCells.Font.Bold = true;
            worksheet.Cells[1, 2] = "Отчет";

            Excel.Range range1 = worksheet.UsedRange;
            range1.Font.Name = "Times New Roman";
            range1.Font.Size = 12;
            // выравниваем колонки, чтобы все данные были на виду           
            range1.EntireColumn.AutoFit();
            range1.EntireRow.AutoFit();
            range1.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            // Расставляем рамки со всех сторон
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            //range1.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic);

            app.Visible = true;
            // save the application  
            //workbook.SaveAs("C:\\Users\\Banana\\Desktop\\Report\\dbExportPicture.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //app.Quit();
        }

        //
        //Отчет по экспозициям
        //
        private void bExpReport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Отчет";
            // storing header part in Excel  
            int cell = 1;
            for (int i = 0; i < dGVExpositionList.Columns.Count; i++)
            {
                if (dGVExpositionList.Columns[i].Visible == true)
                {
                    worksheet.Cells[1, cell] = dGVExpositionList.Columns[i].HeaderText;
                    cell++;

                }
            }

            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dGVExpositionList.Rows.Count; i++)
            {
                for (int j = 0; j < dGVExpositionList.Columns.Count; j++)
                {
                    if (dGVExpositionList.Columns[j].Visible == true)
                    {
                        worksheet.Cells[i + 2, j] = dGVExpositionList.Rows[i].Cells[j].Value.ToString();
                    }
                }

            }

            Excel.Range cellRange = (Excel.Range)worksheet.Cells[1, 1];
            Excel.Range rowRange = cellRange.EntireRow;
            Excel.Range colRange = cellRange.EntireColumn;
            rowRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            colRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            Excel.Range excelCells = (Excel.Range)worksheet.get_Range("B1", "H1").Cells;
            excelCells.Merge(Type.Missing);
            excelCells.Font.Bold = true;
            worksheet.Cells[1, 2] = "Отчет";

            Excel.Range range1 = worksheet.UsedRange;
            range1.Font.Name = "Times New Roman";
            range1.Font.Size = 12;
            // выравниваем колонки, чтобы все данные были на виду           
            range1.EntireColumn.AutoFit();
            range1.EntireRow.AutoFit();
            range1.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            // Расставляем рамки со всех сторон
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            //range1.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic);


            // save the application  
            workbook.SaveAs("C:\\Users\\Banana\\Desktop\\Report\\dbExportExposition.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        //
        //Отчет по пользователям
        //
        private void bUsrReport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
          
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Отчет";
            // storing header part in Excel  
            int cell = 1;
            for (int i = 0; i < dGVUserList.Columns.Count; i++)
            {
                if (dGVUserList.Columns[i].Visible == true)
                {
                    worksheet.Cells[1, cell] = dGVUserList.Columns[i].HeaderText;
                    cell++;
                }
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dGVUserList.Rows.Count; i++)
            {
                for (int j = 0; j < dGVUserList.Columns.Count; j++)
                {
                    if (dGVUserList.Columns[j].Visible == true)
                        worksheet.Cells[i + 2, j] = dGVUserList.Rows[i].Cells[j].Value.ToString();
                }
            }

            Excel.Range cellRange = (Excel.Range)worksheet.Cells[1, 1];
            Excel.Range rowRange = cellRange.EntireRow;
            Excel.Range colRange = cellRange.EntireColumn;
            rowRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            colRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            Excel.Range excelCells = (Excel.Range)worksheet.get_Range("B1", "F1").Cells;
            excelCells.Merge(Type.Missing);
            worksheet.Cells[1, 2] = "Отчет";

            Excel.Range range1 = worksheet.UsedRange;
            range1.Font.Name = "Times New Roman";
            range1.Font.Size = 12;
            // выравниваем колонки, чтобы все данные были на виду           
            range1.EntireColumn.AutoFit();
            range1.EntireRow.AutoFit();
            range1.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            // Расставляем рамки со всех сторон
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            //range1.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic);

            // see the excel sheet behind the program  
            app.Visible = true;
            // save the application  
            //workbook.SaveAs("C:\\Users\\Banana\\Desktop\\Report\\dbExportUser.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //app.Quit();
        }

        //
        //Отчет по картинам на экспозиции
        //
        private void bExpToPic_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Отчет";
            // storing header part in Excel  
            int cell = 1;
            for (int i = 0; i < dGVExpToPic.Columns.Count; i++)
            {
                if (dGVExpToPic.Columns[i].Visible == true)
                {
                    worksheet.Cells[1, cell] = dGVExpToPic.Columns[i].HeaderText;
                    cell++;
                }
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dGVExpToPic.Rows.Count; i++)
            {
                for (int j = 0; j < dGVExpToPic.Columns.Count; j++)
                {
                    if (dGVExpToPic.Columns[j].Visible == true)
                        worksheet.Cells[i + 2, j] = dGVExpToPic.Rows[i].Cells[j].Value.ToString();
                }
            }

            Excel.Range cellRange = (Excel.Range)worksheet.Cells[1, 1];
            Excel.Range rowRange = cellRange.EntireRow;
            Excel.Range colRange = cellRange.EntireColumn;
            rowRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            colRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            Excel.Range excelCells = (Excel.Range)worksheet.get_Range("B1").Cells;
            excelCells.Merge(Type.Missing);
            Expositions ex1 = (Expositions)cbExposition.SelectedItem;
            worksheet.Cells[1, 2] = "Перечень картин на " + ex1.Name;

            Excel.Range range1 = worksheet.UsedRange;
            range1.Font.Name = "Times New Roman";
            range1.Font.Size = 12;
            // выравниваем колонки, чтобы все данные были на виду           
            range1.EntireColumn.AutoFit();
            range1.EntireRow.AutoFit();
            range1.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            // Расставляем рамки со всех сторон
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            //range1.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic);

            app.Visible = true;
            // save the application  
            //workbook.SaveAs("C:\\Users\\Banana\\Desktop\\Report\\dbExportPicToExp.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //app.Quit();
        }
    }
}
