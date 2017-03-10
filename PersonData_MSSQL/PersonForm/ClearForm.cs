using System;
using System.Windows.Forms;

namespace PersonForm
{
    public class ClearForm
    {
        public static void Clearing(params TextBox[] textBoxName)
        {
            foreach (TextBox t in textBoxName)
            {
                t.Text = String.Empty;
            }
        }
    }
}