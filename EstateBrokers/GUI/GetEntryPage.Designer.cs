﻿
namespace GUI
{
    partial class GetEntryPage
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
            this.dataGridView_ShowEntries = new System.Windows.Forms.DataGridView();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Reload = new System.Windows.Forms.Button();
            this.textBox_CaseIDtoPrint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CaseToDelete = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ShowEntries
            // 
            this.dataGridView_ShowEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShowEntries.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ShowEntries.Name = "dataGridView_ShowEntries";
            this.dataGridView_ShowEntries.RowTemplate.Height = 25;
            this.dataGridView_ShowEntries.Size = new System.Drawing.Size(1169, 762);
            this.dataGridView_ShowEntries.TabIndex = 0;
            // 
            // button_Print
            // 
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Print.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Print.Location = new System.Drawing.Point(1009, 774);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(149, 58);
            this.button_Print.TabIndex = 7;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_Reload
            // 
            this.button_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reload.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Reload.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Reload.Location = new System.Drawing.Point(0, 774);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(149, 59);
            this.button_Reload.TabIndex = 8;
            this.button_Reload.Text = "Reload";
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // textBox_CaseIDtoPrint
            // 
            this.textBox_CaseIDtoPrint.Location = new System.Drawing.Point(646, 803);
            this.textBox_CaseIDtoPrint.Name = "textBox_CaseIDtoPrint";
            this.textBox_CaseIDtoPrint.Size = new System.Drawing.Size(357, 27);
            this.textBox_CaseIDtoPrint.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(646, 772);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Which case ID would you like to print?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 765);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(236, 773);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Case id to delete";
            // 
            // textBox_CaseToDelete
            // 
            this.textBox_CaseToDelete.Location = new System.Drawing.Point(236, 804);
            this.textBox_CaseToDelete.Name = "textBox_CaseToDelete";
            this.textBox_CaseToDelete.Size = new System.Drawing.Size(169, 27);
            this.textBox_CaseToDelete.TabIndex = 13;
            // 
            // button_Delete
            // 
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Delete.Location = new System.Drawing.Point(411, 774);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(149, 60);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // GetEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_CaseToDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CaseIDtoPrint);
            this.Controls.Add(this.button_Reload);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.dataGridView_ShowEntries);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "GetEntryPage";
            this.Size = new System.Drawing.Size(1169, 845);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ShowCEntries;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.DataGridView dataGridView_ShowEntries;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.TextBox textBox_CaseIDtoPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CaseToDelete;
        private System.Windows.Forms.Button button_Delete;
    }
}
