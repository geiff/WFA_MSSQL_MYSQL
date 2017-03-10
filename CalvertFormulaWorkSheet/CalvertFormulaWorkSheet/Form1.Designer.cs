namespace CalvertFormulaWorkSheet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkIsFemale = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGfrResult = new System.Windows.Forms.Label();
            this.comboWeightOrPounds = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textSerum = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAuc = new System.Windows.Forms.TextBox();
            this.labelAucResult = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkIsFemale
            // 
            this.checkIsFemale.AutoSize = true;
            this.checkIsFemale.Location = new System.Drawing.Point(92, 60);
            this.checkIsFemale.Name = "checkIsFemale";
            this.checkIsFemale.Size = new System.Drawing.Size(74, 17);
            this.checkIsFemale.TabIndex = 4;
            this.checkIsFemale.Text = "Is Women";
            this.checkIsFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(194, 177);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Serum Creatinie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(391, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Result:";
            // 
            // labelGfrResult
            // 
            this.labelGfrResult.AutoSize = true;
            this.labelGfrResult.Location = new System.Drawing.Point(426, 41);
            this.labelGfrResult.Name = "labelGfrResult";
            this.labelGfrResult.Size = new System.Drawing.Size(0, 13);
            this.labelGfrResult.TabIndex = 12;
            // 
            // comboWeightOrPounds
            // 
            this.comboWeightOrPounds.FormattingEnabled = true;
            this.comboWeightOrPounds.Items.AddRange(new object[] {
            "kg",
            "pounds"});
            this.comboWeightOrPounds.Location = new System.Drawing.Point(210, 33);
            this.comboWeightOrPounds.Name = "comboWeightOrPounds";
            this.comboWeightOrPounds.Size = new System.Drawing.Size(59, 21);
            this.comboWeightOrPounds.TabIndex = 15;
            this.comboWeightOrPounds.Tag = "";
            this.comboWeightOrPounds.SelectedIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(290, 177);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "GFR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "AUC";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(90, 8);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 30;
            // 
            // textSerum
            // 
            this.textSerum.Location = new System.Drawing.Point(90, 93);
            this.textSerum.Name = "textSerum";
            this.textSerum.Size = new System.Drawing.Size(100, 20);
            this.textSerum.TabIndex = 31;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(90, 38);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 20);
            this.textWeight.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(41, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 35);
            this.label1.TabIndex = 33;
            this.label1.Text = "Target   AUC";
            // 
            // textAuc
            // 
            this.textAuc.Location = new System.Drawing.Point(90, 137);
            this.textAuc.Name = "textAuc";
            this.textAuc.Size = new System.Drawing.Size(100, 20);
            this.textAuc.TabIndex = 34;
            // 
            // labelAucResult
            // 
            this.labelAucResult.AutoSize = true;
            this.labelAucResult.Location = new System.Drawing.Point(426, 86);
            this.labelAucResult.Name = "labelAucResult";
            this.labelAucResult.Size = new System.Drawing.Size(0, 13);
            this.labelAucResult.TabIndex = 36;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(394, 177);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 37;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(611, 218);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelAucResult);
            this.Controls.Add(this.textAuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textSerum);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboWeightOrPounds);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelGfrResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkIsFemale);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
    
        private System.Windows.Forms.CheckBox checkIsFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGfrResult;
        private System.Windows.Forms.ComboBox comboWeightOrPounds;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textSerum;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAuc;
        private System.Windows.Forms.Label labelAucResult;
        private System.Windows.Forms.Button buttonClose;
    }
}

