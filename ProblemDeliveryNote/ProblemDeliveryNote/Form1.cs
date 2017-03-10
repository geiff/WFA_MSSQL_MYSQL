using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProblemDeliveryNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ItemModel> items = new List<ItemModel>();
        private void button1_Click(object sender, EventArgs e)
        {

            Create create = new Create();
            try
            {
                create.DeliveryNote =
                    new DeliveryNoteModel(
                        new PublisherModel(publisherAddress.Text, publisherBulstat.Text, publisherName.Text,
                            publisherMol.Text),
                        new RecipientModel(receptionAddress.Text, receptionBulstat.Text, receptionName.Text,
                            receptionMol.Text), items);


                label19.Text = DeliveryNoteModel.deliveryNoteID.ToString().PadLeft(10, '0');
                label20.Text = create.DeliveryNote.Date;

                label13.Text = create.PrintData(create.DeliveryNote.Publisher.Name,
                    create.DeliveryNote.Publisher.Address,
                    create.DeliveryNote.Publisher.Bulstat, create.DeliveryNote.Publisher.Mol);

                label14.Text = create.PrintData(create.DeliveryNote.Recipient.Name,
                    create.DeliveryNote.Recipient.Address,
                    create.DeliveryNote.Recipient.Bulstat, create.DeliveryNote.Recipient.Mol);


                textBox1.AppendText(create.PrintRow());

                label27.Text = create.CalculateTotalSum().ToString("0.00 лв.");
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1200;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            items.Add(new ItemModel(int.Parse(itemCodeArticle.Text), articelName.Text, unit.Text,
                double.Parse(quantity.Text), decimal.Parse(singlePrice.Text)));

            itemCodeArticle.Text = default(string);
            articelName.Text = default(string);
            unit.Text = default(string);
            quantity.Text = default(string);
            singlePrice.Text = default(string);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            items.Clear();
            receptionAddress.Text = default(string);
            receptionBulstat.Text = default(string);
            receptionName.Text = default(string);
            receptionMol.Text = default(string);

            publisherAddress.Text = default(string);
            publisherBulstat.Text = default(string);
            publisherName.Text = default(string);
            publisherMol.Text = default(string);

            itemCodeArticle.Text = default(string);
            articelName.Text = default(string);
            unit.Text = default(string);
            quantity.Text = default(string);
            singlePrice.Text = default(string);

            textBox1.Text = default(string);
            label20.Text = default(string);
            label19.Text = default(string);
            label27.Text = default(string);
            label14.Text = default(string);
            label13.Text = default(string);
        }
    }
}