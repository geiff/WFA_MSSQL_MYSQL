using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DataBindingTest
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private BindingList<Student> studentList;

        public Form1()
        {
            InitializeComponent();
            studentList = new BindingList<Student>()
            {
                new Student() { FirstName = "Pesho", LastName = "Petrov" },
                new Student() { FirstName = "Gosho", LastName = "Kolev" },
                new Student() { FirstName = "Stamat", LastName = "Nikolov"}
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bindingSource.DataSource = studentList;
            this.dataGridView.DataSource =
                this.bindingSource;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                studentList.Add(new Student() { FirstName = textBoxFirstName.Text, LastName = textBoxLastName.Text });
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }      
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView.CurrentCell.RowIndex;
                
                studentList[index].FirstName = textBoxFirstName.Text;
                studentList[index].LastName = textBoxLastName.Text;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows.RemoveAt(index);
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            textBoxFirstName.Text = studentList[index].FirstName;
            textBoxLastName.Text = studentList[index].LastName;
        }
    }
}