namespace RegisterOfImmunizedCows.View
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Clear input fields after operation
    /// </summary>
    public class ClearForm
    {
        //The method receives a different number of parameters depending on current need in his invocation
        public static void Clearing(params TextBox[] textBoxName)
        {
            foreach (TextBox t in textBoxName)
            {
                t.Text = String.Empty;
            }
        }
    }
}