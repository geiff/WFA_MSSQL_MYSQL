using System;
using System.Windows.Forms;

namespace CalvertFormulaWorkSheet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {
                try
                {
                    GfrFormula gfrFormula = new GfrFormula();
                    GfrModel gfrModel = new GfrModel();

                    gfrModel.Age = int.Parse(textAge.Text);
                    gfrModel.Weight = double.Parse(textWeight.Text);
                    gfrModel.WeightOrPound = comboWeightOrPounds.Text;
                    gfrModel.IsFemale = checkIsFemale.Checked;
                    gfrModel.SerumCreatinine = int.Parse(textSerum.Text);
                    AucModel auc = new AucModel();
                    auc.GfrModel = gfrModel;
                    AucFormula aucFormula = new AucFormula(gfrFormula, auc);
                  
                    auc.Target = int.Parse(textAuc.Text);

                    labelGfrResult.Text = aucFormula.GFR_RESULT.ToString("0.00 mL/min");
                    labelAucResult.Text = aucFormula.Calculate(auc).ToString("0.00 mg");
                }

                catch (FormatException)
                {
                    MessageBox.Show("There are fields that are filled invalid data!");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid values in all fields!");
            }
        }

        private bool ValidForm()
        {
            if (textAge.Text == String.Empty || textWeight.Text == String.Empty ||
                comboWeightOrPounds.Text == String.Empty || textSerum.Text == String.Empty ||
                textAuc.Text == String.Empty)
            {
                return false;
            }

            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textAge.Text = String.Empty;
            textWeight.Text = String.Empty;
            comboWeightOrPounds.SelectedIndex = 0;
            checkIsFemale.Checked = false;
            textSerum.Text = String.Empty;
            textAuc.Text = String.Empty;
            labelGfrResult.Text = String.Empty;
            labelAucResult.Text = String.Empty;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}