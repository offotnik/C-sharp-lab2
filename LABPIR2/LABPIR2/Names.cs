using System;

namespace Lab2
{
    internal class Names
    {
        private string name;
        private string last_name;
        private string middle_name;

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }

        public string Last_Name
        {
            get 
            { 
                return last_name; 
            }
            set 
            { 
                last_name = value; 
            }
        }

        public string Middle_Name
        {
            get 
            { 
                return middle_name; 
            }
            set 
            { 
                middle_name = value; 
            }
        }

        public Names(string name, string last_name, string middle_name)
        {
            this.name = name;
            this.last_name = last_name;
            this.middle_name = middle_name;
        }

        public override string ToString()
        {
            int situation = DetermineSituation();
            return GetFormattedString(situation);
        }

        private int DetermineSituation()
        {
            bool nameIsEmpty = string.IsNullOrWhiteSpace(name);
            bool lastNameIsEmpty = string.IsNullOrWhiteSpace(last_name);
            bool middleNameIsEmpty = string.IsNullOrWhiteSpace(middle_name);

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
                    return $"{last_name} {name} {middle_name}";
                case 1:
                    return $"{last_name} {middle_name}";
                case 2:
                    return $"{name} {middle_name}";
                case 3:
                    return $"{last_name} {name}";
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
