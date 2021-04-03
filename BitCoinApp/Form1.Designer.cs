namespace BitCoinApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates_Click = new System.Windows.Forms.Button();
            this.amountOfCoinBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrencyCombo
            // 
            this.CurrencyCombo.FormattingEnabled = true;
            this.CurrencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.CurrencyCombo.Location = new System.Drawing.Point(102, 130);
            this.CurrencyCombo.Name = "CurrencyCombo";
            this.CurrencyCombo.Size = new System.Drawing.Size(143, 24);
            this.CurrencyCombo.TabIndex = 0;
            this.CurrencyCombo.Text = "Select currency";
            // 
            // btnGetRates_Click
            // 
            this.btnGetRates_Click.Location = new System.Drawing.Point(301, 130);
            this.btnGetRates_Click.Name = "btnGetRates_Click";
            this.btnGetRates_Click.Size = new System.Drawing.Size(75, 23);
            this.btnGetRates_Click.TabIndex = 1;
            this.btnGetRates_Click.Text = "Get rates";
            this.btnGetRates_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGetRates_Click.UseVisualStyleBackColor = true;
            this.btnGetRates_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountOfCoinBox
            // 
            this.amountOfCoinBox.Location = new System.Drawing.Point(102, 211);
            this.amountOfCoinBox.Name = "amountOfCoinBox";
            this.amountOfCoinBox.Size = new System.Drawing.Size(143, 22);
            this.amountOfCoinBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(109, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of Bitcoins";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.ForeColor = System.Drawing.Color.Transparent;
            this.resultLabel.Location = new System.Drawing.Point(109, 260);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 17);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            this.resultLabel.Visible = false;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(102, 280);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(140, 22);
            this.ResultTextBox.TabIndex = 5;
            this.ResultTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 440);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountOfCoinBox);
            this.Controls.Add(this.btnGetRates_Click);
            this.Controls.Add(this.CurrencyCombo);
            this.Name = "Form1";
            this.Text = "BitCoinCalculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyCombo;
        private System.Windows.Forms.Button btnGetRates_Click;
        private System.Windows.Forms.TextBox amountOfCoinBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

