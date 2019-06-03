using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gallery_v2
{
    class dbDelete
    {

        //УДАЛИТЬ ПОЛЬЗОВАТЕЛЯ
        public static bool DelExpToPic(int idExp, int idPic, TableContext tableContext)
        //public static bool GenreDel(int id)
        {
            try
            {
                //TableContext tableContext = new TableContext();

                if (idExp != 0 && idPic != 0)
                {
                    ExpToPic expToPic = tableContext.ExpToPics.Where(c => c.IdExp == idExp).Where(c => c.IdPic == idPic).FirstOrDefault();
                    tableContext.ExpToPics.Remove(expToPic);
                    tableContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления.");
                return false;
            }
        }


        //УДАЛИТЬ ПОЛЬЗОВАТЕЛЯ
        public static bool UserDel(Users usr, TableContext tableContext)
        //public static bool GenreDel(int id)
        {
            try
            {
                //TableContext tableContext = new TableContext();

                if (usr != null)
                {
                    tableContext.Users.Remove(usr);
                    tableContext.SaveChanges();
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

        //УДАЛИТЬ КАРТИНУ
        public static bool PictureDel(Pictures pic, TableContext tableContext)
        //public static bool GenreDel(int id)
        {
            try
            {
                //TableContext tableContext = new TableContext();

                if (pic != null)
                {
                    tableContext.Pictures.Remove(pic);
                    tableContext.SaveChanges();
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


        //УДАЛИТЬ ЖАНР
        public static bool GenreDel(Genres genre, TableContext tableContext)
        //public static bool GenreDel(int id)
        {
            try
            {
                //TableContext tableContext = new TableContext();

                if (genre != null)
                {
                    tableContext.Genres.Remove(genre);
                    tableContext.SaveChanges();
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

        //УДАЛИТЬ Автора
        public static bool AuthorDel(Authors author, TableContext tableContext)
        {
            try
            {
                if (author != null)
                {
                    tableContext.Authors.Remove(author);
                    tableContext.SaveChanges();
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

        //УДАЛИТЬ Выставку
        public static bool ExpositionDel(Expositions exposition, TableContext tableContext)
        {
            try
            {
                if (exposition != null)
                {
                    tableContext.Expositions.Remove(exposition);
                    tableContext.SaveChanges();
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
