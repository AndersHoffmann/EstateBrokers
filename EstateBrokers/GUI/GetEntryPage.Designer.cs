
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_CaseIDtoPrint = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CaseIDtoPrint)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(646, 779);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Which case ID would you like to print?";
            // 
            // numericUpDown_CaseIDtoPrint
            // 
            this.numericUpDown_CaseIDtoPrint.Location = new System.Drawing.Point(646, 805);
            this.numericUpDown_CaseIDtoPrint.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown_CaseIDtoPrint.Name = "numericUpDown_CaseIDtoPrint";
            this.numericUpDown_CaseIDtoPrint.Size = new System.Drawing.Size(357, 27);
            this.numericUpDown_CaseIDtoPrint.TabIndex = 11;
            // 
            // GetEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.numericUpDown_CaseIDtoPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Reload);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.dataGridView_ShowEntries);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "GetEntryPage";
            this.Size = new System.Drawing.Size(1169, 845);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CaseIDtoPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ShowCEntries;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.DataGridView dataGridView_ShowEntries;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_CaseIDtoPrint;
    }
}
