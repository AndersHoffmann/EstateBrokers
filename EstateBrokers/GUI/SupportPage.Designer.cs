namespace GUI
{
    partial class SupportPage
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
            this.button_cases = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_OpenHouse = new System.Windows.Forms.Button();
            this.button_Estimates = new System.Windows.Forms.Button();
            this.button_NotOnTheList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cases
            // 
            this.button_cases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cases.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cases.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_cases.Location = new System.Drawing.Point(0, 187);
            this.button_cases.Name = "button_cases";
            this.button_cases.Size = new System.Drawing.Size(1408, 107);
            this.button_cases.TabIndex = 0;
            this.button_cases.Text = "Cases";
            this.button_cases.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "- Which page would you like help with?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Support";
            // 
            // button_OpenHouse
            // 
            this.button_OpenHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OpenHouse.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_OpenHouse.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_OpenHouse.Location = new System.Drawing.Point(0, 336);
            this.button_OpenHouse.Name = "button_OpenHouse";
            this.button_OpenHouse.Size = new System.Drawing.Size(1408, 107);
            this.button_OpenHouse.TabIndex = 3;
            this.button_OpenHouse.Text = "Open house";
            this.button_OpenHouse.UseVisualStyleBackColor = true;
            // 
            // button_Estimates
            // 
            this.button_Estimates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Estimates.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Estimates.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Estimates.Location = new System.Drawing.Point(0, 485);
            this.button_Estimates.Name = "button_Estimates";
            this.button_Estimates.Size = new System.Drawing.Size(1408, 107);
            this.button_Estimates.TabIndex = 4;
            this.button_Estimates.Text = "Estimates";
            this.button_Estimates.UseVisualStyleBackColor = true;
            // 
            // button_NotOnTheList
            // 
            this.button_NotOnTheList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_NotOnTheList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_NotOnTheList.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_NotOnTheList.Location = new System.Drawing.Point(0, 631);
            this.button_NotOnTheList.Name = "button_NotOnTheList";
            this.button_NotOnTheList.Size = new System.Drawing.Size(1408, 107);
            this.button_NotOnTheList.TabIndex = 5;
            this.button_NotOnTheList.Text = "Not on the list? ";
            this.button_NotOnTheList.UseVisualStyleBackColor = true;
            // 
            // SupportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_NotOnTheList);
            this.Controls.Add(this.button_Estimates);
            this.Controls.Add(this.button_OpenHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cases);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SupportPage";
            this.Size = new System.Drawing.Size(1408, 908);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_OpenHouse;
        private System.Windows.Forms.Button button_Estimates;
        private System.Windows.Forms.Button button_NotOnTheList;
    }
}
