using System;
using System.Linq;
using System.Windows.Forms;
/// <summary>
/// Form to change into the database
/// </summary>
namespace PersonDataMySql.View
{
    public partial class FormUpdate : Form
    {
        private readonly PersonContextEntities context;

        public FormUpdate()
        {
            InitializeComponent();
            context = new PersonContextEntities();
        }

        //Menu loads form data entry
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertData form = new FormInsertData();
            form.Show();
            this.Hide();
        }

        //Menu displays a message that we are in current form
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Update Form!");
        }

        //Menu loads form delete data 
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelete form = new FormDelete();
            form.Show();
            this.Hide();
        }

        //Menu loads form of presentation of data from the database
        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPreviewData form = new FormPreviewData();
            form.Show();
            this.Hide();
        }

        //Menu closes the application
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Returns Id on input text fields in the data rights, if valid ID message appears
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                person person = context.person.Find(id);

                textBoxFirstLastName.Text = person.Fullname;
                textBoxBirthDate.Text = person.BirthDate.Day + "." + person.BirthDate.Month + "." + person.BirthDate.Year;
                textBoxEmail.Text = person.Email;
                textBoxPhoneNumber.Text = person.PhoneNumber;
            }
            catch (FormatException)
            {
                MessageBox.Show($"The input \"{textBoxId.Text}\" is invalid format or empty, please input correct ID!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"\"{textBoxId.Text}\" is invalid ID, please input existing ID!");
            }
        }

        //Update-а the entry with the new changes
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string validForm = Validator.Validation(textBoxFirstLastName.Text, textBoxBirthDate.Text, textBoxEmail.Text,
                textBoxPhoneNumber.Text);
            if (validForm == "true")
            {
                try
                {
                    int id = int.Parse(textBoxId.Text);

                    var person = context.person
                        .Where(p => p.Id == id);

                    foreach (var p in person)
                    {
                        p.Fullname = textBoxFirstLastName.Text;
                        p.BirthDate = DateTime.Parse(textBoxBirthDate.Text);
                        p.Email = textBoxEmail.Text;
                        p.PhoneNumber = textBoxPhoneNumber.Text;
                    }

                    context.SaveChanges();
                    MessageBox.Show("Successfully updated data!");
                    ClearForm.Clearing(textBoxId, textBoxFirstLastName, textBoxBirthDate, textBoxEmail,
                        textBoxPhoneNumber);
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