using System;

namespace Lab2
{
    internal class Names
    {
        private string _name;
        private string _last_name;
        private string _middle_name;

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

        public Names(string name, string last_name, string middle_name)
        {
            _name = name;
            _last_name = last_name;
            _middle_name = middle_name;
        }

        public override string ToString()
        {
            int situation = DetermineSituation();
            return GetFormattedString(situation);
        }

        private int DetermineSituation()
        {
            bool nameIsEmpty = string.IsNullOrWhiteSpace(_name);
            bool lastNameIsEmpty = string.IsNullOrWhiteSpace(_last_name);
            bool middleNameIsEmpty = string.IsNullOrWhiteSpace(_middle_name);

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
                    return $"{_last_name} {_name} {_middle_name}";
                case 1:
                    return $"{_last_name} {_middle_name}";
                case 2:
                    return $"{_name} {_middle_name}";
                case 3:
                    return $"{_last_name} {_name}";
                case 4:
                    return _name;
                case 5:
                    return _middle_name;
                case 6:
                    return _last_name;
                case 7:
                    return "Вы ничего не написали";
                default:
                    return "Гойда";
            }
        }
    }
}
