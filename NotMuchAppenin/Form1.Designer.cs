namespace NotMuchAppenin
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
            System.Windows.Forms.Button submitBTN;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.snTB = new System.Windows.Forms.TextBox();
            this.udGB = new System.Windows.Forms.GroupBox();
            this.countryLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mRB = new System.Windows.Forms.RadioButton();
            this.fRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cCB = new System.Windows.Forms.CheckBox();
            this.jsCB = new System.Windows.Forms.CheckBox();
            this.pythonCB = new System.Windows.Forms.CheckBox();
            submitBTN = new System.Windows.Forms.Button();
            this.udGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(95, 36);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(100, 20);
            this.fnameTB.TabIndex = 2;
            // 
            // snTB
            // 
            this.snTB.Location = new System.Drawing.Point(95, 69);
            this.snTB.Name = "snTB";
            this.snTB.Size = new System.Drawing.Size(100, 20);
            this.snTB.TabIndex = 3;
            // 
            // submitBTN
            // 
            submitBTN.Location = new System.Drawing.Point(309, 278);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new System.Drawing.Size(75, 23);
            submitBTN.TabIndex = 4;
            submitBTN.Text = "submit";
            submitBTN.UseVisualStyleBackColor = true;
            submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // udGB
            // 
            this.udGB.Controls.Add(this.pythonCB);
            this.udGB.Controls.Add(this.jsCB);
            this.udGB.Controls.Add(this.cCB);
            this.udGB.Controls.Add(this.label4);
            this.udGB.Controls.Add(this.fRB);
            this.udGB.Controls.Add(this.mRB);
            this.udGB.Controls.Add(this.label3);
            this.udGB.Controls.Add(this.countryLB);
            this.udGB.Controls.Add(this.label1);
            this.udGB.Controls.Add(submitBTN);
            this.udGB.Controls.Add(this.fnameTB);
            this.udGB.Controls.Add(this.label2);
            this.udGB.Controls.Add(this.snTB);
            this.udGB.Location = new System.Drawing.Point(12, 12);
            this.udGB.Name = "udGB";
            this.udGB.Size = new System.Drawing.Size(390, 307);
            this.udGB.TabIndex = 5;
            this.udGB.TabStop = false;
            this.udGB.Text = "User Details";
            // 
            // countryLB
            // 
            this.countryLB.FormattingEnabled = true;
            this.countryLB.Items.AddRange(new object[] {
            "England ",
            "Scotland",
            "Wales ",
            "Northern Ireland"});
            this.countryLB.Location = new System.Drawing.Point(95, 97);
            this.countryLB.Name = "countryLB";
            this.countryLB.Size = new System.Drawing.Size(147, 56);
            this.countryLB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Country";
            // 
            // mRB
            // 
            this.mRB.AutoSize = true;
            this.mRB.Location = new System.Drawing.Point(95, 172);
            this.mRB.Name = "mRB";
            this.mRB.Size = new System.Drawing.Size(34, 17);
            this.mRB.TabIndex = 7;
            this.mRB.TabStop = true;
            this.mRB.Text = "M";
            this.mRB.UseVisualStyleBackColor = true;
            // 
            // fRB
            // 
            this.fRB.AutoSize = true;
            this.fRB.Location = new System.Drawing.Point(153, 172);
            this.fRB.Name = "fRB";
            this.fRB.Size = new System.Drawing.Size(31, 17);
            this.fRB.TabIndex = 8;
            this.fRB.TabStop = true;
            this.fRB.Text = "F";
            this.fRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender";
            // 
            // cCB
            // 
            this.cCB.AutoSize = true;
            this.cCB.Location = new System.Drawing.Point(95, 208);
            this.cCB.Name = "cCB";
            this.cCB.Size = new System.Drawing.Size(40, 17);
            this.cCB.TabIndex = 10;
            this.cCB.Text = "C#";
            this.cCB.UseVisualStyleBackColor = true;
            // 
            // jsCB
            // 
            this.jsCB.AutoSize = true;
            this.jsCB.Location = new System.Drawing.Point(95, 232);
            this.jsCB.Name = "jsCB";
            this.jsCB.Size = new System.Drawing.Size(76, 17);
            this.jsCB.TabIndex = 11;
            this.jsCB.Text = "JavaScript";
            this.jsCB.UseVisualStyleBackColor = true;
            // 
            // pythonCB
            // 
            this.pythonCB.AutoSize = true;
            this.pythonCB.Location = new System.Drawing.Point(95, 256);
            this.pythonCB.Name = "pythonCB";
            this.pythonCB.Size = new System.Drawing.Size(59, 17);
            this.pythonCB.TabIndex = 12;
            this.pythonCB.Text = "Python";
            this.pythonCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(696, 478);
            this.Controls.Add(this.udGB);
            this.Name = "Form1";
            this.udGB.ResumeLayout(false);
            this.udGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.TextBox snTB;
        private System.Windows.Forms.GroupBox udGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox countryLB;
        private System.Windows.Forms.CheckBox pythonCB;
        private System.Windows.Forms.CheckBox jsCB;
        private System.Windows.Forms.CheckBox cCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton fRB;
        private System.Windows.Forms.RadioButton mRB;
    }
}

