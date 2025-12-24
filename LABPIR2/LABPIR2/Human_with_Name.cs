using System;

namespace Lab2
{
    internal class Human_with_Name
    {
        private int hight;
        private string name;
        private string last_name;
        private string middle_name;

        public int Hight
        {
            get { return hight; }
            set { hight = value; }
        }

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

        public Human_with_Name(int hight, string name, string last_name, string middle_name)
        {
            this.name = name;
            this.last_name = last_name;
            this.middle_name = middle_name;
            this.hight = hight;
        }

        public override string ToString()
        {
            int situation = DetermineSituation();

            return GetFormattedString(situation);
        }

        private int DetermineSituation()
        {
            bool nameIsEmpty = string.IsNullOrEmpty(name);
            bool lastNameIsEmpty = string.IsNullOrEmpty(last_name);
            bool middleNameIsEmpty = string.IsNullOrEmpty(middle_name);

            if (nameIsEmpty && lastNameIsEmpty && middleNameIsEmpty)
            {
                return 7;
            }

            if (nameIsEmpty && lastNameIsEmpty)
            {
                return 5;
            }

            if (nameIsEmpty && middleNameIsEmpty)
            {
                return 6;
            }

            if (lastNameIsEmpty && middleNameIsEmpty)
            {
                return 4;
            }

            if (nameIsEmpty)
            {
                return 1;
            }

            if (lastNameIsEmpty)
            {
                return 2;
            }

            if (middleNameIsEmpty)
            {
                return 3;
            }

            return 0;
        }

        private string GetFormattedString(int situation)
        {
            switch (situation)
            {
                case 0:
                    return $"Человек с именем {last_name} {name} {middle_name} и ростом {hight}";
                case 1:
                    return $"Человек с именем {last_name} {middle_name} и ростом {hight}";
                case 2:
                    return $"Человек с именем {name} {middle_name} и ростом {hight}";
                case 3:
                    return $"Человек с именем {last_name} {name} и ростом {hight}";
                case 4:
                    return $"Человек с именем {name} и ростом {hight}";
                case 5:
                    return $"Человек с именем {middle_name} и ростом {hight}";
                case 6:
                    return $"Человек с именем {last_name} и ростом {hight}";
                case 7:
                    return "Вы ничего не написали";
                default:
                    return "Гойда";
            }
        }
    }
}