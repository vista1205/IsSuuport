using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IsSupport
{
    internal class Hash_helper
    {/// <summary>
     /// Функция для создания хеша пароля
     /// </summary>
     /// <param name="password"> Входные данные, которые ввел пользователь</param>
     /// <returns>Возваращает пароль в виде хеш-суммы</returns>
        List<Employees> employees;

        public Guid CreateHash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            MD5CryptoServiceProvider MCP = new MD5CryptoServiceProvider();
            byte[] byteshash = MCP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteshash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return new Guid(hash);
        }
        public bool CompareHash(string password)
        {
            var passwordHash = CreateHash(password);
            employees = Helper.GetIsSupportContext().Employees.ToList();
            bool flag = false;
            foreach (Employees employee in employees)
            {
                if (employee.Password.Equals(passwordHash))
                {
                    flag = true;
                    break;
                }
            }
            return flag; 
        }
        public void ReturnUser(string login)
        {
            int userId = 0;
            foreach(Employees employees in Helper.GetIsSupportContext().Employees)
            {
                if (employees.Login.Equals(login))
                {
                    userId = employees.ID;
                    break;
                }
            }
            UserSecret userSecret = new UserSecret();
            userSecret.AddUserSecert(userId);
        }

        public bool LoginCorrect(string login)
        {
            bool flag = false;
            foreach(Employees employees in Helper.GetIsSupportContext().Employees)
            {
                if (employees.Login.Equals(login))
                {
                    flag = true;
                }
            }
            return flag;
        }

    }
}
