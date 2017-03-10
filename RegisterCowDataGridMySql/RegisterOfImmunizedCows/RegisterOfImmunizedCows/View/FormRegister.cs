namespace RegisterOfImmunizedCows.View
{
    using System;
    using System.Data.Entity.Infrastructure;
    using System.Windows.Forms;
    using Controller;
    using System.Data.Entity.Core;

    public partial class FormRegister : Form
    {
        private RegisterData registerData;

        public FormRegister()
        {
            InitializeComponent();
            registerData = new RegisterData();
            DataGridPreview.Fill(dataGridView);
        }

        //Input data
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            bool isEmptyForm = ValidatorData.IsEmptyForm(textBoxNumberCow.Text, textBoxLocation.Text,
                textBoxImmunization.Text,
                textBoxDescription.Text, textBoxDate.Text);

            if (!isEmptyForm)
            {
                try
                {
                    int numberCow;
                    bool isNumberCow = int.TryParse(textBoxNumberCow.Text, out numberCow);
                    string populatedPlace = textBoxLocation.Text;
                    string immunizationName = textBoxImmunization.Text;
                    string immunizationDesxription = textBoxDescription.Text;
                    DateTime dateOnImmunization;
                    bool isDate = DateTime.TryParse(textBoxDate.Text, out dateOnImmunization);

                    if (isNumberCow)
                    {
                        registerData.SaveCow(numberCow, populatedPlace);
                    }
                    else
                    {
                        throw new FormatException("Невалиден маркировъчен номер на крава!");
                    }

                    registerData.SaveImmunization(immunizationName, immunizationDesxription);
                    if (isDate)
                    {
                        registerData.RegisterSave(dateOnImmunization);
                    }
                    else
                    {
                        throw new FormatException("Невалидна дата!");
                    }

                    MessageBox.Show($"Успешно записани данни с номер регистрация {registerData.NumberRegister}!");
                    DataGridPreview.Fill(dataGridView);
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Вече съществува запис с тези данни на същата дата");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EntityCommandExecutionException)
                {
                    MessageBox.Show("Моля използвайте латиница за попълване на входните полета!");
                }
            }
            else
            {
                MessageBox.Show(ValidatorData.MessageString(textBoxNumberCow.Text, textBoxLocation.Text,
                    textBoxImmunization.Text,
                    textBoxDescription.Text, textBoxDate.Text));
            }
        }

        //Menu
        private void regsterNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegister newRegister = new FormRegister();
            newRegister.Show();
            this.Hide();
        }

        private void searchByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByDate searchForm = new SearchByDate();
            searchForm.Show();
            this.Hide();
        }

        private void searchByNumberToolStripMenuItem_Click(object sender, EventArgs e)
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