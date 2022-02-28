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
        Guid CreateHash(string password)
        {
            byte[] bytes=Encoding.Unicode.GetBytes(password);
            MD5CryptoServiceProvider MCP = new MD5CryptoServiceProvider();
            byte[] byteshash=MCP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach(byte b in byteshash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return new Guid(hash);
        }
        bool CompareHash(Guid password)
        {

        }
    }
}
