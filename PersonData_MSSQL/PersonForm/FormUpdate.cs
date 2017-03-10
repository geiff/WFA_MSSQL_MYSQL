using System;
using System.Linq;
using System.Windows.Forms;
using PersonModel;
using PersonControler;

namespace PersonForm
{
    public partial class FormUpdate : Form
    {
        private readonly PersonContext context;
        public FormUpdate()
        {
            InitializeComponent();
            context = new PersonContext();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormData formData = new FormData();
            formData.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Update Form!");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelete formData = new FormDelete();
            formData.Show();
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxUpdate.Text);
                Person person = context.Person.Find(id);

                textBoxName.Text = person.FullName;
                textBoxBirthDate.Text = person.BirthDate.Day + "." + person.BirthDate.Month + "." + person.BirthDate.Year;
                textBoxEmail.Text = person.Email;
                textBoxPhoneNumber.Text = person.Email;
            }
            catch (FormatException)
            {
                MessageBox.Show($"The input \"{textBoxUpdate.Text}\" is invalid format or empty, please input correct ID!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"\"{textBoxUpdate.Text}\" is invalid ID, please input existing ID!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string validForm = Validator.Validation(textBoxName.Text, textBoxBirthDate.Text, textBoxEmail.Text, textBoxPhoneNumber.Text);
            if (validForm == "true")
            {
                try
                {
                    int id = int.Parse(textBoxUpdate.Text);
                   
                    var person = context.Person
                        .Where(p => p.Id == id);

                    foreach (var p in person)
                    {
                        p.FullName = textBoxName.Text;
                        p.BirthDate = DateTime.Parse(textBoxBirthDate.Text);
                        p.Email = textBoxEmail.Text;
                        p.PhoneNumber = textBoxPhoneNumber.Text;
                    }
                 
                    context.SaveChanges();
                    MessageBox.Show("Successfully updated data!");
                    ClearForm.Clearing(textBoxUpdate, textBoxName, textBoxBirthDate, textBoxEmail, textBoxPhoneNumber);
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