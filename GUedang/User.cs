using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GUedang
{
    internal class User
    {

        public string Username { get; set; }
        public string Password { get; set; }



        public  User() { }


        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        
        public void SaveToJson(string filePath)
        {
            List<User> users = new List<User>();

            
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }

            
            users.Add(this);

            
            var options = new JsonSerializerOptions { WriteIndented = true };
            string updatedJson = JsonSerializer.Serialize(users, options);

            
            File.WriteAllText(filePath, updatedJson);
        }
    }
}