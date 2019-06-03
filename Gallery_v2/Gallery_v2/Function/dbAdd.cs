using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gallery_v2
{
    class dbAdd
    {

        //ДОБАВИТЬ Cвязь Экспозиция - выставка
        public static bool ExpToPicAdd(int expId, int picId, TableContext tableContext)
        {
            try
            {
                ExpToPic expToPic = new ExpToPic
                {
                    IdExp = expId,
                    IdPic = picId
                };
                tableContext.ExpToPics.Add(expToPic);
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //ДОБАВИТЬ пользователя
        public static bool UserAdd(Users usr, TableContext tableContext)
        {
            try
            {
                tableContext.Users.Add(usr);
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //ДОБАВИТЬ ЖАНР
        public static bool GenreAdd(Genres gen, TableContext tableContext)
        {
            try
            {
                tableContext.Genres.Add(gen);
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //ДОБАВИТЬ КАРТИНУ
        public static bool PictureAdd(Pictures pic, TableContext tableContext)
        {
            try
            {
                tableContext.Pictures.Add(pic);
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }


        //ДОБАВИТЬ Автора
        public static bool AuthorAdd(Authors aut, TableContext tableContext)
        {
            try
            {
                tableContext.Authors.Add(aut);
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //ДОБАВИТЬ  Выставку
        public static bool ExpositionAdd(Expositions exp, TableContext tableContext)
        {
            try
            {
                tableContext.Expositions.Add(exp);
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }
    }
}
