
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
            this.getEntryPage1 = new GUI.GetEntryPage();
            this.createEntryPage1 = new GUI.CreateEntryPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button_UpdateCase = new System.Windows.Forms.Button();
            this.button_DeleteCase = new System.Windows.Forms.Button();
            this.textBox_CaseIdToDelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editEntryPage1 = new GUI.EditEntryPage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CreateCase
            // 
            this.button_CreateCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateCase.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_CreateCase.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_CreateCase.Location = new System.Drawing.Point(0, 220);
            this.button_CreateCase.Name = "button_CreateCase";
            this.button_CreateCase.Size = new System.Drawing.Size(205, 115);
            this.button_CreateCase.TabIndex = 0;
            this.button_CreateCase.Text = "Create case";
            this.button_CreateCase.UseVisualStyleBackColor = true;
            this.button_CreateCase.Click += new System.EventHandler(this.button_CreateCase_Click);
            // 
            // button_ShowCases
            // 
            this.button_ShowCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowCases.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ShowCases.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ShowCases.Location = new System.Drawing.Point(0, 341);
            this.button_ShowCases.Name = "button_ShowCases";
            this.button_ShowCases.Size = new System.Drawing.Size(205, 116);
            this.button_ShowCases.TabIndex = 1;
            this.button_ShowCases.Text = "Show cases";
            this.button_ShowCases.UseVisualStyleBackColor = true;
            this.button_ShowCases.Click += new System.EventHandler(this.button_ShowCases_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editEntryPage1);
            this.panel1.Controls.Add(this.getEntryPage1);
            this.panel1.Controls.Add(this.createEntryPage1);
            this.panel1.Location = new System.Drawing.Point(211, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 845);
            this.panel1.TabIndex = 2;
            // 
            // getEntryPage1
            // 
            this.getEntryPage1.BackColor = System.Drawing.Color.White;
            this.getEntryPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getEntryPage1.Location = new System.Drawing.Point(0, 0);
            this.getEntryPage1.Name = "getEntryPage1";
            this.getEntryPage1.Size = new System.Drawing.Size(1176, 845);
            this.getEntryPage1.TabIndex = 1;
            // 
            // createEntryPage1
            // 
            this.createEntryPage1.BackColor = System.Drawing.Color.White;
            this.createEntryPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createEntryPage1.Location = new System.Drawing.Point(8, 0);
            this.createEntryPage1.Margin = new System.Windows.Forms.Padding(4);
            this.createEntryPage1.Name = "createEntryPage1";
            this.createEntryPage1.Size = new System.Drawing.Size(1161, 845);
            this.createEntryPage1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cases";
            // 
            // button_UpdateCase
            // 
            this.button_UpdateCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateCase.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_UpdateCase.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_UpdateCase.Location = new System.Drawing.Point(0, 463);
            this.button_UpdateCase.Name = "button_UpdateCase";
            this.button_UpdateCase.Size = new System.Drawing.Size(205, 116);
            this.button_UpdateCase.TabIndex = 4;
            this.button_UpdateCase.Text = "Update case";
            this.button_UpdateCase.UseVisualStyleBackColor = true;
            this.button_UpdateCase.Click += new System.EventHandler(this.button_UpdateCase_Click);
            // 
            // button_DeleteCase
            // 
            this.button_DeleteCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteCase.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_DeleteCase.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_DeleteCase.Location = new System.Drawing.Point(0, 648);
            this.button_DeleteCase.Name = "button_DeleteCase";
            this.button_DeleteCase.Size = new System.Drawing.Size(205, 116);
            this.button_DeleteCase.TabIndex = 5;
            this.button_DeleteCase.Text = "Delete case";
            this.button_DeleteCase.UseVisualStyleBackColor = true;
            // 
            // textBox_CaseIdToDelete
            // 
            this.textBox_CaseIdToDelete.Location = new System.Drawing.Point(0, 789);
            this.textBox_CaseIdToDelete.Name = "textBox_CaseIdToDelete";
            this.textBox_CaseIdToDelete.Size = new System.Drawing.Size(198, 27);
            this.textBox_CaseIdToDelete.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(0, 767);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter case id to delete";
            // 
            // editEntryPage1
            // 
            this.editEntryPage1.BackColor = System.Drawing.Color.White;
            this.editEntryPage1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editEntryPage1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.editEntryPage1.Location = new System.Drawing.Point(0, 0);
            this.editEntryPage1.Name = "editEntryPage1";
            this.editEntryPage1.Size = new System.Drawing.Size(1176, 845);
            this.editEntryPage1.TabIndex = 2;
            // 
            // CasesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_CaseIdToDelete);
            this.Controls.Add(this.button_DeleteCase);
            this.Controls.Add(this.button_UpdateCase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_ShowCases);
            this.Controls.Add(this.button_CreateCase);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CasesPage";
            this.Size = new System.Drawing.Size(1408, 908);
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
        private CreateEntryPage createEntryPage1;
        private GetEntryPage getEntryPage1;
        private System.Windows.Forms.Button button_UpdateCase;
        private System.Windows.Forms.Button button_DeleteCase;
        private System.Windows.Forms.TextBox textBox_CaseIdToDelete;
        private System.Windows.Forms.Label label2;
        private EditEntryPage editEntryPage1;
    }
}
