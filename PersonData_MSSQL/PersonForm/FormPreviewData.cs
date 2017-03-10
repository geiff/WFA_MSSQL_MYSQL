using System;
using System.Windows.Forms;

namespace PersonForm
{
    public partial class FormPreviewData : Form
    {
        public FormPreviewData()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            FormDelete formData = new FormDelete();
            formData.Show();
            this.Hide();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in View Data Form!");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personContextDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.personContextDataSet.People);
        }
    }
}