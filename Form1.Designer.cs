namespace Assignment_2
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
            this.lableHeading = new System.Windows.Forms.Label();
            this.lableFirstNumber = new System.Windows.Forms.Label();
            this.lableSecondNumber = new System.Windows.Forms.Label();
            this.txtBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.txtBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.labelOperation = new System.Windows.Forms.Label();
            this.dropDownCombo = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lableHeading
            // 
            this.lableHeading.AutoSize = true;
            this.lableHeading.Location = new System.Drawing.Point(659, 38);
            this.lableHeading.Name = "lableHeading";
            this.lableHeading.Size = new System.Drawing.Size(313, 37);
            this.lableHeading.TabIndex = 0;
            this.lableHeading.Text = "ASSIGNMENT 2 - CALCULATOR";
            // 
            // lableFirstNumber
            // 
            this.lableFirstNumber.AutoSize = true;
            this.lableFirstNumber.Location = new System.Drawing.Point(244, 268);
            this.lableFirstNumber.Name = "lableFirstNumber";
            this.lableFirstNumber.Size = new System.Drawing.Size(325, 37);
            this.lableFirstNumber.TabIndex = 1;
            this.lableFirstNumber.Text = "OPERAND 1";
            // 
            // lableSecondNumber
            // 
            this.lableSecondNumber.AutoSize = true;
            this.lableSecondNumber.Location = new System.Drawing.Point(244, 478);
            this.lableSecondNumber.Name = "lableSecondNumber";
            this.lableSecondNumber.Size = new System.Drawing.Size(376, 37);
            this.lableSecondNumber.TabIndex = 2;
            this.lableSecondNumber.Text = "OPERAND 2";
            // 
            // txtBoxFirstNumber
            // 
            this.txtBoxFirstNumber.Location = new System.Drawing.Point(757, 221);
            this.txtBoxFirstNumber.Multiline = true;
            this.txtBoxFirstNumber.Name = "txtBoxFirstNumber";
            this.txtBoxFirstNumber.Size = new System.Drawing.Size(674, 110);
            this.txtBoxFirstNumber.TabIndex = 3;
            // 
            // txtBoxSecondNumber
            // 
            this.txtBoxSecondNumber.Location = new System.Drawing.Point(757, 428);
            this.txtBoxSecondNumber.Multiline = true;
            this.txtBoxSecondNumber.Name = "txtBoxSecondNumber";
            this.txtBoxSecondNumber.Size = new System.Drawing.Size(674, 110);
            this.txtBoxSecondNumber.TabIndex = 4;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(244, 671);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(254, 37);
            this.labelOperation.TabIndex = 5;
            this.labelOperation.Text = "OPERATION";
            // 
            // dropDownCombo
            // 
            this.dropDownCombo.FormattingEnabled = true;
            this.dropDownCombo.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.dropDownCombo.Location = new System.Drawing.Point(769, 668);
            this.dropDownCombo.Name = "dropDownCombo";
            this.dropDownCombo.Size = new System.Drawing.Size(168, 45);
            this.dropDownCombo.TabIndex = 6;
            this.dropDownCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(757, 862);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(235, 71);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(292, 1057);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(218, 37);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "RESULT : ";
            this.labelResult.Visible = false;
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(757, 1004);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ReadOnly = true;
            this.txtBoxResult.Size = new System.Drawing.Size(674, 110);
            this.txtBoxResult.TabIndex = 9;
            this.txtBoxResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2069, 1220);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dropDownCombo);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.txtBoxSecondNumber);
            this.Controls.Add(this.txtBoxFirstNumber);
            this.Controls.Add(this.lableSecondNumber);
            this.Controls.Add(this.lableFirstNumber);
            this.Controls.Add(this.lableHeading);
            this.Name = "Form1";
            this.Text = "ASSIGNMENT 2 - CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableHeading;
        private System.Windows.Forms.Label lableFirstNumber;
        private System.Windows.Forms.Label lableSecondNumber;
        private System.Windows.Forms.TextBox txtBoxFirstNumber;
        private System.Windows.Forms.TextBox txtBoxSecondNumber;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.ComboBox dropDownCombo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox txtBoxResult;
    }
}

