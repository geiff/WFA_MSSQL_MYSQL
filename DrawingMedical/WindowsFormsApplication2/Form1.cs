using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1200;
            Height = 600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = panel1.CreateGraphics();

                List<MedicalModel> medicals = new List<MedicalModel>();
                for (int i = 0; i < richTextBox1.Lines.Length; i++)
                {
                    string name = richTextBox1.Lines[i].Split('-')[0];
                    string[] value = richTextBox1.Lines[i].Split('-')[1].Split(' ');
                    List<int> days = new List<int>();

                    for (int j = 0; j < value.Length; j++)
                    {
                        days.Add(int.Parse(value[j]));
                    }

                    medicals.Add(new MedicalModel(name, days));
                }

                int cikul = int.Parse(textBox2.Text);
                int protokolId = int.Parse(textBox1.Text);

                Create create = new Create(new List<ProtokolModel>() {new ProtokolModel(cikul, medicals, protokolId)});

                panel1.CreateGraphics();

                create.DrawGrafic(g);
            }

          
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Невалидно попълнено име на лекарство или дни на прием! Данните се попълват в ред: \"Име на лекарство-Ден Ден Ден\"");
            }

            catch (FormatException)
            {
                MessageBox.Show("Има полета с непопълнени данни или с не коректно попълнени данни!");
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = default(string);
            textBox2.Text = default(string);           
            richTextBox1.Text = default(string);            
            panel1.Invalidate();
        }
    }
}