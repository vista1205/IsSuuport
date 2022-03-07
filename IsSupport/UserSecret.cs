using System.Linq;
using System.IO;
using System.Text.Json;
using System;

namespace IsSupport
{
    internal class UserSecret
    {
        public string PathSecret()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string path = @"%APPDATA%\microsoft\UserSecrets";
            string pathAll = Path.Combine(path, @"Microsoft\UserSecret\0B098861-6467-4A2D-ACF5-E8E60B62A65B");
            if (!Directory.Exists(pathAll))
            {
                Directory.CreateDirectory(pathAll);
            }
            return pathAll;
            
        }
        public string FileSecret()
        {
            string fileName = Path.Combine(PathSecret(), "secrets.json");
            if (!File.Exists(fileName))
            {
                fileName = Path.Combine(PathSecret(), "secrets.json");
            }
            
            return fileName;
        }
        public async void AddUserSecert(int id)
        {
           var employees=Helper.GetIsSupportContext().Employees.Where(x=>x.ID==id).FirstOrDefault();
            using(FileStream fs = new FileStream(FileSecret(), FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Employees>(fs, employees);
            }
        }
        public int ReturnUserID()
        {
            using(FileStream fs = new FileStream(FileSecret(), FileMode.OpenOrCreate))
            {
                var employees = JsonSerializer.Deserialize<Employees>(fs);
                return (int)employees?.ID;
            }
        }
    }
}
