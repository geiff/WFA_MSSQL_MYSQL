namespace RegisterOfImmunizedCows.View
{
    using System;
    using System.Windows.Forms;

    public partial class SearchByDate : Form
    {
        public SearchByDate()
        {
            InitializeComponent();
        }

        //Filling Grid with data from database
        private void SearchByDate_Load(object sender, EventArgs e)
        {
            DataGridPreview.Fill(dataGridView1);
        }

        //Search for data and their visualization
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime dateParse;
            bool isDateValid = DateTime.TryParse(textBoxDate.Text, out dateParse);
            if (isDateValid)
            {
                try
                {
                    string[] dataInput = textBoxDate.Text.Split(new char[] { '.', '-' });
                    string date = $"{dataInput[2]}-{dataInput[1]}-{dataInput[0]}";
                    DataGridPreview.FillWirhSearchData(date, dataGridView1);
                }
                catch (IndexOutOfRangeException)
                {

                    MessageBox.Show("Некоректно въведена дата! Моля въведе дата в следния формат: дд-мм-гггг или дд.мм.гггг");
                }
            }
            else
            {
                MessageBox.Show("Невалидна дата!");
            }
        }

        //Menu
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.Show();
            this.Hide();
        }

        private void searchByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вие се намирате в Модул Търсене по дата!");
        }

        private void SearchByNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchByNumber searchForm = new FormSearchByNumber();
            searchForm.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}