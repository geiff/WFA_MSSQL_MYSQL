using System;
using System.Windows.Forms;
/// <summary>
/// Clears the form fields of data.
/// </summary>
namespace PersonDataMySql.View
{
   public class ClearForm
    {
        //The method receives a different number of parameters depending on current need in his invocation.
        public static void Clearing(params TextBox[] textBoxName)
        {
            foreach (TextBox t in textBoxName)
            {
                t.Text = String.Empty;
            }
        }
    }
}