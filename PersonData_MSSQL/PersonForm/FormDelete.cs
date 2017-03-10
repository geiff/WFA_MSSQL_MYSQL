using System;
using System.Windows.Forms;
using PersonControler;
using PersonModel;

namespace PersonForm
{
    public partial class FormDelete : Form
    {       
        private readonly PersonContext context;

        public FormDelete()
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
            FormUpdate form = new FormUpdate();
            form.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Delete Form!");
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

        private Person FindPerson()
        {
            int id = int.Parse(textBoxId.Text);
            Person person = context.Person.Find(id);
            return person;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = FindPerson();

                textBoxName.Text = person.FullName;
                textBoxBirthDate.Text = person.BirthDate.Day + "." + person.BirthDate.Month + "." +person.BirthDate.Year;
                textBoxEmail.Text = person.Email;
                textBoxPhoneNumber.Text = person.Email;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            context.Person.Remove(FindPerson());

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
    }
}