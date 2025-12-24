using System;

namespace Lab2
{
    internal class Human_with_Father : Human_with_Name
    {
        private Human_with_Father father;

        public Human_with_Father Father
        {
            get { return father; }
            set { father = value; }
        }

        public Human_with_Father(
            int hight,
            string name,
            string last_name,
            string middle_name,
            Human_with_Father father = null
        ) : base(hight, name, last_name, middle_name)
        {
            this.father = father;
            ApplyFathersInfo();
        }

        private void ApplyFathersInfo()
        {
            if (father != null)
            {
                if (string.IsNullOrEmpty(base.Last_Name) &&
                    !string.IsNullOrEmpty(father.Last_Name))
                {
                    base.Last_Name = father.Last_Name;
                }

                if (string.IsNullOrEmpty(base.Middle_Name) &&
                    !string.IsNullOrEmpty(father.Name))
                {
                    base.Middle_Name = father.Name + "ович";
                }
            }
        }

        public override string ToString()
        {
            ApplyFathersInfo();

            Names nameObj = new Names(base.Name, base.Last_Name, base.Middle_Name);

            return "Человек с Именем " + nameObj.ToString() + " и ростом " + base.Hight;
        }
    }
}