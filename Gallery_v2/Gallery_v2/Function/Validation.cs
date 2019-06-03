using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gallery_v2
{
    class Validation
    {
        //ЗАПОЛНЕНИЕ КАРТИНЫ
        public static string PictureVal(string inventoryNum, string name, string authorName, string genre, decimal cost, string status)
        {
                try
                {
                    if (inventoryNum == "")
                        return "Не введен инвентарыный номер";

                    if (name == "")
                        return "Не введено наименование картины";

                    if (authorName == "")
                        return "Не введен автор картины";

                    if (genre == "")
                        return "Не выбран жандр";

                    if (status == "")
                        return "Не выбран статус картины";

                    return null;
                }
                catch
                {
                    return null;
                }
        }

        //ПРОВЕРКА ДАТ
        public static bool DataCheck(DateTime date1, DateTime date2)
        {
            try
            {
                if (date1.Year < date2.Year)
                {
                    return true;
                }
                else if (date1.Month < date2.Month)
                {
                    if (date1.Year > date2.Year)
                        return false;
                    return true;
                }
                else if (date1.Day < date2.Day)
                {
                    if (date1.Year > date2.Year)
                        return false;
                    if (date1.Month > date2.Month)
                        return false;
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
