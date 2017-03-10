using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2
{
    public class ProtokolModel
    {
        private int circle;
        private List<MedicalModel> medicals;
        private int protokolID;
        public ProtokolModel(int circle, List<MedicalModel> medical, int protokolID)
        {
            this.Circle = circle;
            this.Medicals = medical;
            this.ProtokolID = protokolID;
        }

        public int Circle
        {
            get
            {
                return this.circle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Повторният прием не може да бъде отрицателно число!");
                }

                this.circle = value;
            }
        }

        public List<MedicalModel> Medicals { get { return this.medicals; } set { this.medicals = value; } }

        public int ProtokolID
        {
            get
            {
                return this.protokolID;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Номерът на протокола не може да бъде отрицателно число!");
                }

                this.protokolID = value;
            }
        }

    }
}