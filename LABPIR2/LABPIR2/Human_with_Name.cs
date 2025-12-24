using System;

namespace Lab2
{
    internal class Human_with_Name
    {
        private int _hight;
        private string _name;
        private string _last_name;
        private string _middle_name;

        public int Hight
        {
            get { return _hight; }
            set { _hight = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Last_Name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        public string Middle_Name
        {
            get { return _middle_name; }
            set { _middle_name = value; }
        }

        public Human_with_Name(int hight, string name, string last_name, string middle_name)
        {
            _name = name;
            _last_name = last_name;
            _middle_name = middle_name;
            _hight = hight;
        }

        public override string ToString()
        {
            int situation = DetermineSituation();

            return GetFormattedString(situation);
        }

        private int DetermineSituation()
        {
            bool nameIsEmpty = string.IsNullOrEmpty(_name);
            bool lastNameIsEmpty = string.IsNullOrEmpty(_last_name);
            bool middleNameIsEmpty = string.IsNullOrEmpty(_middle_name);

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
                    return $"Человек с именем {_last_name} {_name} {_middle_name} и ростом {_hight}";
                case 1:
                    return $"Человек с именем {_last_name} {_middle_name} и ростом {_hight}";
                case 2:
                    return $"Человек с именем {_name} {_middle_name} и ростом {_hight}";
                case 3:
                    return $"Человек с именем {_last_name} {_name} и ростом {_hight}";
                case 4:
                    return $"Человек с именем {_name} и ростом {_hight}";
                case 5:
                    return $"Человек с именем {_middle_name} и ростом {_hight}";
                case 6:
                    return $"Человек с именем {_last_name} и ростом {_hight}";
                case 7:
                    return "Вы ничего не написали";
                default:
                    return "Гойда";
            }
        }
    }
}
