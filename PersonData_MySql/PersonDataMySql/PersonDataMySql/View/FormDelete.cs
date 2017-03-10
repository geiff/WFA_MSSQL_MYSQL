using System;
using System.Windows.Forms;
/// <summary>
/// Form to delete the data from the database
/// </summary>
namespace PersonDataMySql.View
{
    public partial class FormDelete : Form
    {
        private readonly PersonContextEntities context;
        public FormDelete()
        {
            InitializeComponent();
            context = new PersonContextEntities();
        }

        //Returns record of Person on an ID
        private person FindPerson()
        {
            int id = int.Parse(textBoxId.Text);
            person person = context.person.Find(id);
            return person;
        }

        //Loading data into text fields on people who will be delete.
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                person person = FindPerson();

                textBoxName.Text = person.Fullname;
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

        //Deletes data from the database before it asks for confirmation
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            context.person.Remove(FindPerson());

            if (MessageBox.Show("Are you sure want to delete this data?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.SaveChanges();
                MessageBox.Show("Successfully Deleted Data!");
            }
            else
            {
                MessageBox.Show("This data not are deleted!");
            }

            ClearForm.Clearing(textBoxId, textBoxName, textBoxBirthDate, textBoxEmail, textBoxPhoneNumber);
        }

        //Menu loads form data entry
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertData form = new FormInsertData();
            form.Show();
            this.Hide();
        }

        //Menu loads the form to change data
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdate form = new FormUpdate();
            form.Show();
            this.Hide();
        }

        //Menu displays a message that we are in current form
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Delete Form!");
        }

        //Menu loaded form of presentation of data from the database
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
    }
}