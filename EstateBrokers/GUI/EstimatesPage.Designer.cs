
namespace GUI
{
    partial class EstimatesPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstimatesPage));
            this.label4 = new System.Windows.Forms.Label();
            this.button_PostalEstimates = new System.Windows.Forms.Button();
            this.button_PropertyValuation = new System.Windows.Forms.Button();
            this.MainPanelForEstimatePage = new System.Windows.Forms.Panel();
            this.panel_coverpanel = new System.Windows.Forms.Panel();
            this.panel_HidePage = new System.Windows.Forms.Panel();
            this.propertyValuationPage1 = new GUI.PropertyValuationPage();
            this.postalCodeEstimates1 = new GUI.PostalCodeEstimates();
            this.button_LoanEstimate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PricePerMonth = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown_HousePrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_NumberOfPayments = new System.Windows.Forms.NumericUpDown();
            this.MainPanelForEstimatePage.SuspendLayout();
            this.panel_coverpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HousePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estimates";
            // 
            // button_PostalEstimates
            // 
            this.button_PostalEstimates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PostalEstimates.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_PostalEstimates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_PostalEstimates.Image = ((System.Drawing.Image)(resources.GetObject("button_PostalEstimates.Image")));
            this.button_PostalEstimates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PostalEstimates.Location = new System.Drawing.Point(0, 772);
            this.button_PostalEstimates.Name = "button_PostalEstimates";
            this.button_PostalEstimates.Size = new System.Drawing.Size(222, 87);
            this.button_PostalEstimates.TabIndex = 8;
            this.button_PostalEstimates.Text = " Postal estimates";
            this.button_PostalEstimates.UseVisualStyleBackColor = true;
            this.button_PostalEstimates.Click += new System.EventHandler(this.button_PostalEstimates_Click);
            // 
            // button_PropertyValuation
            // 
            this.button_PropertyValuation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PropertyValuation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_PropertyValuation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_PropertyValuation.Image = ((System.Drawing.Image)(resources.GetObject("button_PropertyValuation.Image")));
            this.button_PropertyValuation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PropertyValuation.Location = new System.Drawing.Point(0, 682);
            this.button_PropertyValuation.Name = "button_PropertyValuation";
            this.button_PropertyValuation.Size = new System.Drawing.Size(222, 84);
            this.button_PropertyValuation.TabIndex = 9;
            this.button_PropertyValuation.Text = "     Property valuation";
            this.button_PropertyValuation.UseVisualStyleBackColor = true;
            this.button_PropertyValuation.Click += new System.EventHandler(this.button_PropertyValuation_Click);
            // 
            // MainPanelForEstimatePage
            // 
            this.MainPanelForEstimatePage.CausesValidation = false;
            this.MainPanelForEstimatePage.Controls.Add(this.panel_coverpanel);
            this.MainPanelForEstimatePage.Location = new System.Drawing.Point(228, 12);
            this.MainPanelForEstimatePage.Name = "MainPanelForEstimatePage";
            this.MainPanelForEstimatePage.Size = new System.Drawing.Size(1165, 852);
            this.MainPanelForEstimatePage.TabIndex = 10;
            // 
            // panel_coverpanel
            // 
            this.panel_coverpanel.Controls.Add(this.panel_HidePage);
            this.panel_coverpanel.Controls.Add(this.propertyValuationPage1);
            this.panel_coverpanel.Controls.Add(this.postalCodeEstimates1);
            this.panel_coverpanel.Location = new System.Drawing.Point(0, 0);
            this.panel_coverpanel.Name = "panel_coverpanel";
            this.panel_coverpanel.Size = new System.Drawing.Size(1180, 896);
            this.panel_coverpanel.TabIndex = 20;
            // 
            // panel_HidePage
            // 
            this.panel_HidePage.Location = new System.Drawing.Point(0, -12);
            this.panel_HidePage.Name = "panel_HidePage";
            this.panel_HidePage.Size = new System.Drawing.Size(1180, 908);
            this.panel_HidePage.TabIndex = 20;
            // 
            // propertyValuationPage1
            // 
            this.propertyValuationPage1.BackColor = System.Drawing.Color.White;
            this.propertyValuationPage1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.propertyValuationPage1.Location = new System.Drawing.Point(0, 0);
            this.propertyValuationPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.propertyValuationPage1.Name = "propertyValuationPage1";
            this.propertyValuationPage1.Size = new System.Drawing.Size(1165, 852);
            this.propertyValuationPage1.TabIndex = 1;
            // 
            // postalCodeEstimates1
            // 
            this.postalCodeEstimates1.BackColor = System.Drawing.Color.White;
            this.postalCodeEstimates1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalCodeEstimates1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.postalCodeEstimates1.Location = new System.Drawing.Point(1, 0);
            this.postalCodeEstimates1.Margin = new System.Windows.Forms.Padding(4);
            this.postalCodeEstimates1.Name = "postalCodeEstimates1";
            this.postalCodeEstimates1.Size = new System.Drawing.Size(1165, 852);
            this.postalCodeEstimates1.TabIndex = 0;
            // 
            // button_LoanEstimate
            // 
            this.button_LoanEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LoanEstimate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_LoanEstimate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_LoanEstimate.Image = ((System.Drawing.Image)(resources.GetObject("button_LoanEstimate.Image")));
            this.button_LoanEstimate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LoanEstimate.Location = new System.Drawing.Point(13, 353);
            this.button_LoanEstimate.Name = "button_LoanEstimate";
            this.button_LoanEstimate.Size = new System.Drawing.Size(207, 87);
            this.button_LoanEstimate.TabIndex = 11;
            this.button_LoanEstimate.Text = "Loan estimate";
            this.button_LoanEstimate.UseVisualStyleBackColor = true;
            this.button_LoanEstimate.Click += new System.EventHandler(this.button_LoanEstimate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(13, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "House price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number of payments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(9, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price per month";
            // 
            // textBox_PricePerMonth
            // 
            this.textBox_PricePerMonth.BackColor = System.Drawing.Color.White;
            this.textBox_PricePerMonth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_PricePerMonth.Location = new System.Drawing.Point(13, 475);
            this.textBox_PricePerMonth.Name = "textBox_PricePerMonth";
            this.textBox_PricePerMonth.ReadOnly = true;
            this.textBox_PricePerMonth.Size = new System.Drawing.Size(207, 31);
            this.textBox_PricePerMonth.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 10);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 10);
            this.panel2.TabIndex = 19;
            // 
            // numericUpDown_HousePrice
            // 
            this.numericUpDown_HousePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_HousePrice.ForeColor = System.Drawing.Color.DodgerBlue;
            this.numericUpDown_HousePrice.Location = new System.Drawing.Point(13, 230);
            this.numericUpDown_HousePrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown_HousePrice.Name = "numericUpDown_HousePrice";
            this.numericUpDown_HousePrice.Size = new System.Drawing.Size(208, 33);
            this.numericUpDown_HousePrice.TabIndex = 20;
            // 
            // numericUpDown_NumberOfPayments
            // 
            this.numericUpDown_NumberOfPayments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_NumberOfPayments.ForeColor = System.Drawing.Color.DodgerBlue;
            this.numericUpDown_NumberOfPayments.Location = new System.Drawing.Point(13, 306);
            this.numericUpDown_NumberOfPayments.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_NumberOfPayments.Name = "numericUpDown_NumberOfPayments";
            this.numericUpDown_NumberOfPayments.Size = new System.Drawing.Size(208, 33);
            this.numericUpDown_NumberOfPayments.TabIndex = 21;
            // 
            // EstimatesPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.numericUpDown_NumberOfPayments);
            this.Controls.Add(this.numericUpDown_HousePrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_PricePerMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_LoanEstimate);
            this.Controls.Add(this.MainPanelForEstimatePage);
            this.Controls.Add(this.button_PropertyValuation);
            this.Controls.Add(this.button_PostalEstimates);
            this.Controls.Add(this.label4);
            this.Name = "EstimatesPage";
            this.Size = new System.Drawing.Size(1408, 908);
            this.MainPanelForEstimatePage.ResumeLayout(false);
            this.panel_coverpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HousePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_PostalEstimates;
        private System.Windows.Forms.Button button_PropertyValuation;
        private System.Windows.Forms.Panel MainPanelForEstimatePage;
        private System.Windows.Forms.Button button_LoanEstimate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PricePerMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_coverpanel;
        private System.Windows.Forms.Panel panel_HidePage;
        private PropertyValuationPage propertyValuationPage1;
        private PostalCodeEstimates postalCodeEstimates1;
        private System.Windows.Forms.NumericUpDown numericUpDown_HousePrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfPayments;
    }
}
