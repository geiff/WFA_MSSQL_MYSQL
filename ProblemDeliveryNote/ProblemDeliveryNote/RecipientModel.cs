using System;

namespace ProblemDeliveryNote
{
    public class RecipientModel
    {
        private string address;
        private string bulstat;
        private string name;
        private string mol;

        public RecipientModel(string address, string bulstat, string name, string mol)
        {
            this.Address = address;
            this.Bulstat = bulstat;
            this.Name = name;
            this.Mol = mol;
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Попълнете полете за адрес на Получателя!");
                }

                this.address = value;
            }
        }

        public string Bulstat
        {
            get { return this.bulstat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Попълнете полете за булстат на Получателя!");
                }

                this.bulstat = value;
            }
        }
        public string Name {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Попълнете полете за Име на Получателя!");
                }

                this.name = value;
            }
        }
        public string Mol {
            get { return this.mol; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Попълнете полете за Мол на Получателя!");
                }

                this.mol = value;
            }
        }
    }
}