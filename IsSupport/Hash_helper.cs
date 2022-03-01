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

        Guid CreateHash(string password)
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
        bool CompareHash(string password)
        {
            var passwordHash = CreateHash(password);
            employees = Helper.GetIsSupportContext().Employees.ToList();
            bool flag = false;
            foreach (Employees employee in employees)
            {
                if (employee.Password == passwordHash)
                {
                    flag = true;
                    break;
                }
            }
            return flag; 
        }
        int ReturnUser(string password)
        {
            List<Employees> employees = Helper.GetIsSupportContext().Employees.ToList();
            int userID = 0;
            var hashPassword=CreateHash(password);
            if (CompareHash(password))
            {
                foreach(Employees employees1 in employees)
                {
                    if (employees1.Password == hashPassword)
                    {
                        userID = employees1.ID;
                        break;
                    }
                }                
            }
            return userID;
        } 

    }
}
