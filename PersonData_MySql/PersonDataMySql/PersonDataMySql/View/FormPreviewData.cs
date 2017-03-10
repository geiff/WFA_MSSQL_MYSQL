using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
/// <summary>
/// Form for the presentation of data from the database
/// </summary>
namespace PersonDataMySql.View
{
    public partial class FormPreviewData : Form
    {
        public FormPreviewData()
        {
            InitializeComponent();
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

        //Menu loads form delete data
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelete form = new FormDelete();
            form.Show();
            this.Hide();
        }

        //Menu displays a message that we are in current form
        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in View Data Form!");
        }

        //Menu closes the application
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Loading Grid
        private void FormPreviewData_Load(object sender, EventArgs e)
        {
            this.Grid();
        }

        //Loading in Grid data from database
        private void Grid()
        {
            string conString = @"server=127.0.0.1;user id=root;database=personcontext;password=12345;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM person", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}