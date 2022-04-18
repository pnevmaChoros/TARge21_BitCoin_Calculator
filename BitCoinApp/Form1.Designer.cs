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
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.BitcoinAmountTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.currencyAmountLabel = new System.Windows.Forms.Label();
            this.currencyResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR to BTC",
            "USD to BTC",
            "BTC to EUR",
            "BTC to USD"});
            this.currencyCombo.Location = new System.Drawing.Point(40, 80);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(121, 24);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            this.currencyCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnGetRates
            // 
            this.btnGetRates.Location = new System.Drawing.Point(200, 80);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(75, 23);
            this.btnGetRates.TabIndex = 0;
            this.btnGetRates.Text = "Get Rates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            this.btnGetRates.Click += new System.EventHandler(this.btnGetRates_Click);
            // 
            // BitcoinAmountTextBox
            // 
            this.BitcoinAmountTextBox.Location = new System.Drawing.Point(40, 164);
            this.BitcoinAmountTextBox.Name = "BitcoinAmountTextBox";
            this.BitcoinAmountTextBox.Size = new System.Drawing.Size(121, 22);
            this.BitcoinAmountTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(40, 234);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(121, 22);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "Result";
            this.resultTextBox.Visible = false;
            // 
            // currencyAmountLabel
            // 
            this.currencyAmountLabel.AutoSize = true;
            this.currencyAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.currencyAmountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currencyAmountLabel.Location = new System.Drawing.Point(37, 145);
            this.currencyAmountLabel.Name = "currencyAmountLabel";
            this.currencyAmountLabel.Size = new System.Drawing.Size(108, 16);
            this.currencyAmountLabel.TabIndex = 3;
            this.currencyAmountLabel.Text = "Currency Amount";
            // 
            // currencyResultLabel
            // 
            this.currencyResultLabel.AutoSize = true;
            this.currencyResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.currencyResultLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currencyResultLabel.Location = new System.Drawing.Point(37, 215);
            this.currencyResultLabel.Name = "currencyResultLabel";
            this.currencyResultLabel.Size = new System.Drawing.Size(45, 16);
            this.currencyResultLabel.TabIndex = 4;
            this.currencyResultLabel.Text = "Result";
            this.currencyResultLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currencyResultLabel);
            this.Controls.Add(this.currencyAmountLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.BitcoinAmountTextBox);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.currencyCombo);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.TextBox BitcoinAmountTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label currencyAmountLabel;
        private System.Windows.Forms.Label currencyResultLabel;
    }
}

