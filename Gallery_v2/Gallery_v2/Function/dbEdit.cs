using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gallery_v2
{
    class dbEdit
    {
        //РЕДАКТИРОВАТЬ ПОЛЬЗОВАТЕЛЯ
        public static bool UserEdit(Users usersEdit, Users usersEditor, TableContext tableContext)
        {
            try
            {
                if (usersEdit != usersEditor)
                {
                    usersEdit = usersEditor;
                }
                tableContext.Entry(usersEdit).State = EntityState.Modified;
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //РЕДАКТИРОВАТЬ КАРТИНУ
        public static bool PicturesEdit(Pictures picturesEdit, Pictures picturesEditor, TableContext tableContext)
        {
            try
            {
                if (picturesEdit != picturesEditor)
                {
                    picturesEdit = picturesEditor;
                }
                tableContext.Entry(picturesEdit).State = EntityState.Modified;
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //РЕДАКТИРОВАТЬ ЖАНР
        public static bool GenreEdit(Genres genreEdit, Genres genreEditor, TableContext tableContext)
        {
            try
            {
                if (genreEdit != genreEditor)
                {
                    genreEdit = genreEditor;
                }
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        //РЕДАКТИРОВАТЬ Автора
        public static bool AuthorEdit(Authors authorEdit, Authors authorEditor, TableContext tableContext)
        {
            try
            {
                if (authorEdit != authorEditor)
                {
                    authorEdit = authorEditor;
                }
                tableContext.Entry(authorEdit).State = EntityState.Modified;
                tableContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Потеряно соеденение с сервером.");
                return false;
            }
        }

        public static bool ExpositionEdit(Expositions expEdit, Expositions expEditor, TableContext tableContext)
        {
            try
            {
                if (expEdit != expEditor)
                {
                    expEdit = expEditor;
                }
                tableContext.Entry(expEdit).State = EntityState.Modified;
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
