namespace RegisterOfImmunizedCows.View
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Windows.Forms;
    using Controller;

    public partial class FormSearchByNumber : Form
    {
        private readonly SearchData searchData;
        private readonly RegisterData registerData;
        private int id;
        public FormSearchByNumber()
        {
            InitializeComponent();
            searchData = new SearchData();
            registerData = new RegisterData();
        }

        //Search for data and their visualization
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(textBoxIdRegister.Text);
                List<string> resultData = searchData.SearchingDataOnNumberRegistur(id);
                textBoxNumberCow.Text = resultData[0];
                textBoxLocation.Text = resultData[1];
                textBoxImmunization.Text = resultData[2];
                textBoxDescription.Text = resultData[3];
                textBoxDate.Text = resultData[4];
            }
            catch (FormatException)
            {
                MessageBox.Show("Невалиден входящ номер!");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Несъществуващ входящ номер!");
            }
        }

        //Update data
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool isValidForma = ValidatorData.IsEmptyForm(textBoxNumberCow.Text, textBoxLocation.Text, textBoxImmunization.Text,
               textBoxDescription.Text, textBoxDate.Text);

            if (!isValidForma)
            {
                try
                {
                    registerData.UpdateData(id, int.Parse(textBoxNumberCow.Text), textBoxLocation.Text,
                        textBoxImmunization.Text, textBoxDescription.Text,
                        DateTime.Parse(textBoxDate.Text));
                    MessageBox.Show("Успешно обноваване на данни!");
                    ClearForm.Clearing(textBoxIdRegister, textBoxNumberCow, textBoxLocation, textBoxImmunization,
                        textBoxDescription, textBoxDate);
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Вече съществува запис с тези данни на същата дата");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Има полета с неправилно полълнени входни данни!");
                }
            }
            else
            {
                MessageBox.Show(ValidatorData.MessageString(textBoxNumberCow.Text, textBoxLocation.Text, textBoxImmunization.Text,
                    textBoxDescription.Text, textBoxDate.Text));
            }
        }

        //Deleting data
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Внимание данни ще бъдат изтрити!!! Сигурни ли сте, че желаете да ги изтриете?",
                "Изтриване", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                registerData.DeleteData(id);
                MessageBox.Show("Успешно изтрити данни!");
                ClearForm.Clearing(textBoxIdRegister, textBoxNumberCow, textBoxLocation, textBoxImmunization,
               textBoxDescription, textBoxDate);
            }
            else
            {
                MessageBox.Show("Данните не бяха изтрити!");
            }
        }

        //Menu
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.Show();
            this.Hide();
        }

        private void searchByDatelStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByDate searchForm = new SearchByDate();
            searchForm.Show();
            this.Hide();
        }

        private void searchByNumberStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вие се намирате в Модул Търсене по номер на регистрация!");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}