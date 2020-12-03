
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
            this.button_LoadEntries = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // button_LoadEntries
            // 
            this.button_LoadEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LoadEntries.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_LoadEntries.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_LoadEntries.Location = new System.Drawing.Point(1009, 776);
            this.button_LoadEntries.Name = "button_LoadEntries";
            this.button_LoadEntries.Size = new System.Drawing.Size(149, 59);
            this.button_LoadEntries.TabIndex = 7;
            this.button_LoadEntries.Text = "Print";
            this.button_LoadEntries.UseVisualStyleBackColor = true;
            this.button_LoadEntries.Click += new System.EventHandler(this.button_LoadEntries_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(13, 776);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GetEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_LoadEntries);
            this.Controls.Add(this.dataGridView_ShowEntries);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "GetEntryPage";
            this.Size = new System.Drawing.Size(1169, 845);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowEntries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ShowCEntries;
        private System.Windows.Forms.Button button_LoadEntries;
        private System.Windows.Forms.DataGridView dataGridView_ShowEntries;
        private System.Windows.Forms.Button button1;
    }
}
