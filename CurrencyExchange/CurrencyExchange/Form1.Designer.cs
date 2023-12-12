namespace CurrencyExchange
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private object btnConvert;

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
            this.cboSourceCurrency = new System.Windows.Forms.ComboBox();
            this.cboTargetCurrency = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // cboSourceCurrency
            this.cboSourceCurrency.FormattingEnabled = true;
            this.cboSourceCurrency.Location = new System.Drawing.Point(106, 151);
            this.cboSourceCurrency.Name = "cboSourceCurrency";
            this.cboSourceCurrency.Size = new System.Drawing.Size(151, 28);
            this.cboSourceCurrency.TabIndex = 0;

            // cboTargetCurrency
            this.cboTargetCurrency.FormattingEnabled = true;
            this.cboTargetCurrency.Location = new System.Drawing.Point(472, 151);
            this.cboTargetCurrency.Name = "cboTargetCurrency";
            this.cboTargetCurrency.Size = new System.Drawing.Size(151, 28);
            this.cboTargetCurrency.TabIndex = 1;

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(299, 152);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(125, 27);
            this.txtAmount.TabIndex = 2;

            // btnConvert
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnConvert.Location = new System.Drawing.Point(299, 245);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 29);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            this.Controls.Add(this.btnConvert);  // Add this line to ensure the button is added to the form


            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(322, 332);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(50, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add((Control)this.btnConvert);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cboTargetCurrency);
            this.Controls.Add(this.cboSourceCurrency);
            this.Name = "Form1";
            this.Text = "Currency Exchange";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
