using System;
using System.Linq;

namespace ProblemDeliveryNote
{
    public class Create
    {
        public Create()
        {
            DeliveryNoteModel.deliveryNoteID++;
        }
        public DeliveryNoteModel DeliveryNote { get; set; }

        public decimal CalculateTotalSum()
        {
            decimal sum = 0;
            sum += DeliveryNote.Items.Sum(x => x.TotalSum);
            return sum;
        }

        public string PrintData(string name, string address, string bulstat, string mol)
        {
           string result =
                "Име: " + name + Environment.NewLine + "Адрес: " +
                address + Environment.NewLine + "Булстат: " +
                bulstat + Environment.NewLine + "МОЛ: " +
                mol;

            return result;
        }

        public string PrintRow()
        {
            string result = " № "
                + "|" + " Код на Артикул " + "|" +
            " Артикул " + "|" + " Мер. Единица " + "|" +
            " Количество " + "|" + " Ед. Цена " + "|" + " Сума " + Environment.NewLine;

            for (int i = 0; i < this.DeliveryNote.Items.Count; i++)
            {
                result += (i + 1) + new string(' ', 3)  + new string(' ', 18) +
                                    this.DeliveryNote.Items[i].CodeАrticle  + new string(' ', 12) +
                                    this.DeliveryNote.Items[i].ArticleName + new string(' ', 15) + this.DeliveryNote.Items[i].Unit +
                                     new string(' ', 5) +
                                    this.DeliveryNote.Items[i].Quantity.ToString("0.00") + new string(' ', 5) +
                                    this.DeliveryNote.Items[i].SinglePrice.ToString("0.00") + " лв." + new string(' ', 5) +
                                    this.DeliveryNote.Items[i].TotalSum.ToString("0.00") + " лв." +
                                    Environment.NewLine;
            }

            return result;
        }
    }
}