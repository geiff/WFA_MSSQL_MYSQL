using System;
using System.Windows.Forms;
using PersonControler;
using PersonModel;

namespace PersonForm
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Insert Form!");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdate form = new FormUpdate();
            form.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelete form = new FormDelete();
            form.Show();
            this.Hide();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPreviewData form = new FormPreviewData();
            form.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string validForm = Validator.Validation(textBoxName.Text, textBoxBirthDate.Text, textBoxEmail.Text, textBoxPhoneNumber.Text);
            if (validForm == "true")
            {
                try
                {
                    var context = new PersonContext();
                    Person person = new Person()
                    {
                        FullName = textBoxName.Text,
                        BirthDate = DateTime.Parse(textBoxBirthDate.Text),
                        Email = textBoxEmail.Text,
                        PhoneNumber = textBoxPhoneNumber.Text
                    };

                    context.Person.Add(person);
                    context.SaveChanges();
                    MessageBox.Show("Successfully recorded data!");
                    ClearForm.Clearing(textBoxName, textBoxBirthDate, textBoxEmail, textBoxPhoneNumber);
                }
                catch (FormatException)
                {

                    MessageBox.Show("Invalid Date format!");
                }
            }
            else
            {
                MessageBox.Show(validForm);
            }
        }
    }
}