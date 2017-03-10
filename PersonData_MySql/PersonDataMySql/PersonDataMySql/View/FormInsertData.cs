using System;
using System.Linq;
using System.Windows.Forms;
/// <summary>
/// Form data input database
/// </summary>
namespace PersonDataMySql.View
{
    public partial class FormInsertData : Form
    {
        private readonly PersonContextEntities context;
        public FormInsertData()
        {
            InitializeComponent();
            context = new PersonContextEntities();
        }

        //Menu displays a message that we are in current form
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Insert Form!");
        }

        //Menu loads the form to change data
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdate form = new FormUpdate();
            form.Show();
            this.Hide();
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

        //Pressing the button checks whether the data are valid by calling the appropriate methods and apply them if recorded
        //if not prints appropriate error
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string validForm = Validator.Validation(textBoxFullName.Text, textBoxBirthDate.Text, textBoxEmail.Text, textBoxPhoneNumber.Text);
            if (validForm == "true")
            {
                try
                {
                    person people = new person
                    {
                        Fullname = textBoxFullName.Text,
                        BirthDate = DateTime.Parse(textBoxBirthDate.Text),
                        Email = textBoxEmail.Text,
                        PhoneNumber = textBoxPhoneNumber.Text
                    };

                   if (context.person.Any(x => x.Fullname.Equals(people.Fullname) && x.BirthDate.Equals(people.BirthDate)
                         && x.Email.Equals(people.Email) && x.PhoneNumber.Equals(people.PhoneNumber)))
                    {
                        if (MessageBox.Show("This entity already exists in database! Do you want to save it again?", 
                            "Attention", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            ClearForm.Clearing(textBoxFullName, textBoxBirthDate, textBoxEmail, textBoxPhoneNumber);
                        }
                        else
                        {
                            SavingDataInDatabase(people);
                        }
                    }
                    else
                    {
                        SavingDataInDatabase(people);
                    }
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

        //Method of recording in database
        private void SavingDataInDatabase(person p)
        {
            context.person.Add(p);
            context.SaveChanges();
            MessageBox.Show("Successfully recorded data!");
            ClearForm.Clearing(textBoxFullName, textBoxBirthDate, textBoxEmail, textBoxPhoneNumber);
        }
    }
}