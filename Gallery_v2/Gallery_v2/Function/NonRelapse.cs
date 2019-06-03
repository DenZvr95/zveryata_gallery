using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gallery_v2
{
    class NonRelapse
    {
        //Пользователи
        public static bool UsersNR(string Log)
        {
            try
            {
                TableContext tableContext = new TableContext();
                if (tableContext.Users.Where(c => c.Login == Log).FirstOrDefault() == null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //Жанры
        public static bool GenresNR(string name)
        {
            try
            {
                TableContext tableContext = new TableContext();
                if (tableContext.Genres.Where(c => c.Name == name).FirstOrDefault() == null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //Авторы
        public static bool AuthorsNR(string name)
        {
            try
            {
                TableContext tableContext = new TableContext();
                if (tableContext.Authors.Where(c => c.Name == name).FirstOrDefault() == null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //Экспозиции
        public static bool ExpositionsNR(string name)
        {
            try
            {
                TableContext tableContext = new TableContext();
                if (tableContext.Expositions.Where(c => c.Name == name).FirstOrDefault() == null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //Картины
        public static bool PictureNR(string InNum)
        {
            try
            {
                TableContext tableContext = new TableContext();
                if (tableContext.Pictures.Where(c => c.InventoryNumber == InNum).FirstOrDefault() == null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }


    }
}