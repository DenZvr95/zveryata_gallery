using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gallery_v2
{
    class DBFunction
    {

        //АВТОРИЗАЦИЯ
        public static Users Auth(string login, string password)
        {
            try
            {
                TableContext TabCon = new TableContext();
                Users User = TabCon.Users.Include("Position").Where(c => c.Login == login).FirstOrDefault();
                if (User.Password.Equals(password))
                {
                    return User;
                }
                else
                {
                    MessageBox.Show("Проверьте правильность Логина/Пароля");
                    return null;
                }
                   
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте соединение с сервером.");
                return null;
            }
        }



        public static bool Session(Users sess)
        {
            try
            {
                TableContext TabCon = new TableContext();
                Users usr = TabCon.Users.Where(c => c.Login == sess.Login).FirstOrDefault();
                if (usr.Password.Equals(sess.Password))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
