
namespace GUI
{
    partial class CasesPage
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
            this.button_CreateCase = new System.Windows.Forms.Button();
            this.button_ShowCases = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OnCasesPage_createEntryPage = new GUI.CreateEntryPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CreateCase
            // 
            this.button_CreateCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateCase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_CreateCase.Location = new System.Drawing.Point(0, 332);
            this.button_CreateCase.Name = "button_CreateCase";
            this.button_CreateCase.Size = new System.Drawing.Size(205, 115);
            this.button_CreateCase.TabIndex = 0;
            this.button_CreateCase.Text = "Create case";
            this.button_CreateCase.UseVisualStyleBackColor = true;
            // 
            // button_ShowCases
            // 
            this.button_ShowCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowCases.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ShowCases.Location = new System.Drawing.Point(0, 453);
            this.button_ShowCases.Name = "button_ShowCases";
            this.button_ShowCases.Size = new System.Drawing.Size(205, 116);
            this.button_ShowCases.TabIndex = 1;
            this.button_ShowCases.Text = "Show cases";
            this.button_ShowCases.UseVisualStyleBackColor = true;
            this.button_ShowCases.Click += new System.EventHandler(this.button_ShowCases_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OnCasesPage_createEntryPage);
            this.panel1.Location = new System.Drawing.Point(204, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 845);
            this.panel1.TabIndex = 2;
            // 
            // OnCasesPage_createEntryPage
            // 
            this.OnCasesPage_createEntryPage.BackColor = System.Drawing.Color.White;
            this.OnCasesPage_createEntryPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnCasesPage_createEntryPage.Location = new System.Drawing.Point(0, 0);
            this.OnCasesPage_createEntryPage.Margin = new System.Windows.Forms.Padding(4);
            this.OnCasesPage_createEntryPage.Name = "OnCasesPage_createEntryPage";
            this.OnCasesPage_createEntryPage.Size = new System.Drawing.Size(1169, 845);
            this.OnCasesPage_createEntryPage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cases";
            // 
            // CasesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_ShowCases);
            this.Controls.Add(this.button_CreateCase);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CasesPage";
            this.Size = new System.Drawing.Size(1408, 908);
            this.Load += new System.EventHandler(this.CasesPage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateCase;
        private System.Windows.Forms.Button button_ShowCases;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CreateEntryPage OnCasesPage_createEntryPage;
    }
}
