namespace GUI
{
    partial class PostalCodeEstimates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostalCodeEstimates));
            this.button_check = new System.Windows.Forms.Button();
            this.listBox_AveragePricePerSquareMeter = new System.Windows.Forms.ListBox();
            this.textBox_AvaragePricePerSquareMeter = new System.Windows.Forms.TextBox();
            this.button_AddToList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_AreaCodes = new System.Windows.Forms.ComboBox();
            this.button_LoadAvailableAreaCodes = new System.Windows.Forms.Button();
            this.button_RemoveFromList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_check
            // 
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_check.Image = ((System.Drawing.Image)(resources.GetObject("button_check.Image")));
            this.button_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_check.Location = new System.Drawing.Point(86, 686);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(300, 78);
            this.button_check.TabIndex = 0;
            this.button_check.Text = "Check";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // listBox_AveragePricePerSquareMeter
            // 
            this.listBox_AveragePricePerSquareMeter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox_AveragePricePerSquareMeter.FormattingEnabled = true;
            this.listBox_AveragePricePerSquareMeter.ItemHeight = 25;
            this.listBox_AveragePricePerSquareMeter.Location = new System.Drawing.Point(86, 179);
            this.listBox_AveragePricePerSquareMeter.Name = "listBox_AveragePricePerSquareMeter";
            this.listBox_AveragePricePerSquareMeter.Size = new System.Drawing.Size(931, 354);
            this.listBox_AveragePricePerSquareMeter.TabIndex = 1;
            // 
            // textBox_AvaragePricePerSquareMeter
            // 
            this.textBox_AvaragePricePerSquareMeter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_AvaragePricePerSquareMeter.Location = new System.Drawing.Point(717, 565);
            this.textBox_AvaragePricePerSquareMeter.Name = "textBox_AvaragePricePerSquareMeter";
            this.textBox_AvaragePricePerSquareMeter.ReadOnly = true;
            this.textBox_AvaragePricePerSquareMeter.Size = new System.Drawing.Size(300, 33);
            this.textBox_AvaragePricePerSquareMeter.TabIndex = 3;
            // 
            // button_AddToList
            // 
            this.button_AddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddToList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AddToList.Image = ((System.Drawing.Image)(resources.GetObject("button_AddToList.Image")));
            this.button_AddToList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddToList.Location = new System.Drawing.Point(717, 602);
            this.button_AddToList.Name = "button_AddToList";
            this.button_AddToList.Size = new System.Drawing.Size(300, 78);
            this.button_AddToList.TabIndex = 4;
            this.button_AddToList.Text = "Add to list";
            this.button_AddToList.UseVisualStyleBackColor = true;
            this.button_AddToList.Click += new System.EventHandler(this.button_AddToList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(86, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Area code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(677, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Average price per square meter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(86, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "List of added area codes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Postal estimates";
            // 
            // comboBox_AreaCodes
            // 
            this.comboBox_AreaCodes.FormattingEnabled = true;
            this.comboBox_AreaCodes.Location = new System.Drawing.Point(86, 569);
            this.comboBox_AreaCodes.Name = "comboBox_AreaCodes";
            this.comboBox_AreaCodes.Size = new System.Drawing.Size(300, 29);
            this.comboBox_AreaCodes.TabIndex = 14;
            // 
            // button_LoadAvailableAreaCodes
            // 
            this.button_LoadAvailableAreaCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LoadAvailableAreaCodes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_LoadAvailableAreaCodes.Image = ((System.Drawing.Image)(resources.GetObject("button_LoadAvailableAreaCodes.Image")));
            this.button_LoadAvailableAreaCodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LoadAvailableAreaCodes.Location = new System.Drawing.Point(86, 602);
            this.button_LoadAvailableAreaCodes.Name = "button_LoadAvailableAreaCodes";
            this.button_LoadAvailableAreaCodes.Size = new System.Drawing.Size(300, 78);
            this.button_LoadAvailableAreaCodes.TabIndex = 15;
            this.button_LoadAvailableAreaCodes.Text = "     Load Available Area Codes";
            this.button_LoadAvailableAreaCodes.UseVisualStyleBackColor = true;
            this.button_LoadAvailableAreaCodes.Click += new System.EventHandler(this.button_LoadAvailableAreaCodes_Click);
            // 
            // button_RemoveFromList
            // 
            this.button_RemoveFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveFromList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_RemoveFromList.Image = ((System.Drawing.Image)(resources.GetObject("button_RemoveFromList.Image")));
            this.button_RemoveFromList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_RemoveFromList.Location = new System.Drawing.Point(717, 686);
            this.button_RemoveFromList.Name = "button_RemoveFromList";
            this.button_RemoveFromList.Size = new System.Drawing.Size(300, 78);
            this.button_RemoveFromList.TabIndex = 16;
            this.button_RemoveFromList.Text = "Remove from list";
            this.button_RemoveFromList.UseVisualStyleBackColor = true;
            this.button_RemoveFromList.Click += new System.EventHandler(this.button_RemoveFromList_Click);
            // 
            // PostalCodeEstimates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_RemoveFromList);
            this.Controls.Add(this.button_LoadAvailableAreaCodes);
            this.Controls.Add(this.comboBox_AreaCodes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddToList);
            this.Controls.Add(this.textBox_AvaragePricePerSquareMeter);
            this.Controls.Add(this.listBox_AveragePricePerSquareMeter);
            this.Controls.Add(this.button_check);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostalCodeEstimates";
            this.Size = new System.Drawing.Size(1165, 852);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.ListBox listBox_AveragePricePerSquareMeter;
        private System.Windows.Forms.TextBox textBox_AvaragePricePerSquareMeter;
        private System.Windows.Forms.Button button_AddToList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_AreaCodes;
        private System.Windows.Forms.Button button_LoadAvailableAreaCodes;
        private System.Windows.Forms.Button button_RemoveFromList;
    }
}
