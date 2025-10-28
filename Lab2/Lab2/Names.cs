﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Names
    {
        private string name;
        private string last_name;
        private string middle_name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Last_Name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Middle_Name
        {
            get { return middle_name; }
            set { middle_name = value; }
        }

        public Names(string name, string last_name, string middle_name)  
        {
            this.name = name;
            this.last_name = last_name; 
            this.middle_name = middle_name;
        }

        public override string ToString()
        {
            int situation = 0;

            if (name == null || name == "")
            {
                situation = 1;
            }

            if (last_name == null || last_name == "") 
            { 
                situation = 2; 
            }
            
            if (middle_name == null || middle_name == "")
            {
                situation = 3;
            }

            if ((middle_name == null && last_name == null) || (middle_name == "" && last_name == ""))
            {
                situation = 4;
            }

            if ((name == null && last_name == null) || (name == "" && last_name == ""))
            {
                situation = 5;
            }

            if ((name == null && middle_name == null) || (name == "" && middle_name == ""))
            {
                situation = 6;
            }
            if ((name == "" || name == " " || name == null) && (middle_name == "" || middle_name == " " || middle_name == null) && (last_name == "" || last_name == " " || last_name == null))
            {
                situation = 7;
            }

            switch (situation) 
            {
                case 0:
                    return last_name + " " + name + " " + middle_name;
                case 1:
                    return last_name + " " + middle_name; 
                case 2:
                    return name + " " + middle_name;
                case 3:
                    return last_name + " " + name;
                case 4:
                    return name;
                case 5:
                    return middle_name;
                case 6:
                    return last_name;
                case 7:
                    return "Вы ничего не написали";
                default:
                    return "Гойда";
            }
        }
    }
}
