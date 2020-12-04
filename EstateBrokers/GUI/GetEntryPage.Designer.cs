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
            this.dataGridView_ShowEntries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ShowEntries_CellContentClick);
            // 
            // button_Print
            // 
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Print.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Print.Location = new System.Drawing.Point(1009, 776);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(149, 59);
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
            this.button_Reload.Location = new System.Drawing.Point(13, 776);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(149, 59);
            this.button_Reload.TabIndex = 8;
            this.button_Reload.Text = "Reload";
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // textBox_CaseIDtoPrint
            // 
            this.textBox_CaseIDtoPrint.Location = new System.Drawing.Point(672, 800);
            this.textBox_CaseIDtoPrint.Name = "textBox_CaseIDtoPrint";
            this.textBox_CaseIDtoPrint.Size = new System.Drawing.Size(303, 27);
            this.textBox_CaseIDtoPrint.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 776);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Which case ID would you like to print?";
            // 
            // GetEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
    }
}
