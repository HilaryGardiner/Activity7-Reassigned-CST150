namespace Activity7App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterTermsLabel1 = new System.Windows.Forms.Label();
            this.PI_ResultValueLabel3 = new System.Windows.Forms.Label();
            this.PI_TextResponseLabel2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.calculateNumberOfTermsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterTermsLabel1
            // 
            this.EnterTermsLabel1.AutoSize = true;
            this.EnterTermsLabel1.Location = new System.Drawing.Point(52, 29);
            this.EnterTermsLabel1.Name = "EnterTermsLabel1";
            this.EnterTermsLabel1.Size = new System.Drawing.Size(94, 15);
            this.EnterTermsLabel1.TabIndex = 0;
            this.EnterTermsLabel1.Text = "Enter # of terms:";
            // 
            // PI_ResultValueLabel3
            // 
            this.PI_ResultValueLabel3.AutoSize = true;
            this.PI_ResultValueLabel3.Location = new System.Drawing.Point(52, 272);
            this.PI_ResultValueLabel3.Name = "PI_ResultValueLabel3";
            this.PI_ResultValueLabel3.Size = new System.Drawing.Size(94, 15);
            this.PI_ResultValueLabel3.TabIndex = 1;
            this.PI_ResultValueLabel3.Text = "Enter # of terms:";
            // 
            // PI_TextResponseLabel2
            // 
            this.PI_TextResponseLabel2.AutoSize = true;
            this.PI_TextResponseLabel2.Location = new System.Drawing.Point(52, 177);
            this.PI_TextResponseLabel2.Name = "PI_TextResponseLabel2";
            this.PI_TextResponseLabel2.Size = new System.Drawing.Size(94, 15);
            this.PI_TextResponseLabel2.TabIndex = 2;
            this.PI_TextResponseLabel2.Text = "Enter # of terms:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(201, 29);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(121, 23);
            this.textBoxInput.TabIndex = 3;
            // 
            // calculateNumberOfTermsButton
            // 
            this.calculateNumberOfTermsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateNumberOfTermsButton.Location = new System.Drawing.Point(52, 88);
            this.calculateNumberOfTermsButton.Name = "calculateNumberOfTermsButton";
            this.calculateNumberOfTermsButton.Size = new System.Drawing.Size(94, 52);
            this.calculateNumberOfTermsButton.TabIndex = 4;
            this.calculateNumberOfTermsButton.Text = "CALCULATE";
            this.calculateNumberOfTermsButton.UseVisualStyleBackColor = false;
            this.calculateNumberOfTermsButton.Click += new System.EventHandler(this.calculateNumberOfTermsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 331);
            this.Controls.Add(this.calculateNumberOfTermsButton);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.PI_TextResponseLabel2);
            this.Controls.Add(this.PI_ResultValueLabel3);
            this.Controls.Add(this.EnterTermsLabel1);
            this.Name = "Form1";
            this.Text = "π Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EnterTermsLabel1;
        private Label PI_ResultValueLabel3;
        private Label PI_TextResponseLabel2;
        private TextBox textBoxInput;
        private Button calculateNumberOfTermsButton;
    }
}