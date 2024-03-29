﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1OOP
{
    public class Administrator : User
    {
        public List<string> Logs = new List<string>();

        public Administrator() { }

        public Administrator(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public Administrator GetAdmin(string id, string login, string password)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;
            return this;
        }

        public void CheckAllLogs()
        {
            foreach (string i in File.ReadAllLines("AllLogs.txt")) Logs.Add(i);
        }
    }
}
