using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2
{
    public class MedicalModel
    {
        private string name;
        private List<int> days;
        public MedicalModel(string name, List<int> days)
        {
            this.Name = name;
            this.Days = days;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new IndexOutOfRangeException();
                }

                this.name = value;
            }
        }

        public List<int> Days
        {
            get
            {
                return this.days;
            }
            set
            {
                if (value.Count < 1)
                {
                    throw new IndexOutOfRangeException();
                }

                this.days = value;
            }
        }
    }
}