
namespace GUI
{
    partial class CreateEntryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEntryPage));
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_RealtorID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textbox_PostalCode = new System.Windows.Forms.TextBox();
            this.textbox_AddressLine1 = new System.Windows.Forms.TextBox();
            this.textBox_AddressLine2 = new System.Windows.Forms.TextBox();
            this.textBox_OwnershipCost = new System.Windows.Forms.TextBox();
            this.textBox_ExteriorArea = new System.Windows.Forms.TextBox();
            this.textBox_InteriorArea = new System.Windows.Forms.TextBox();
            this.textBox_BuildYear = new System.Windows.Forms.TextBox();
            this.checkBox_AreYouSure = new System.Windows.Forms.CheckBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_EstimatedPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Save.Image = ((System.Drawing.Image)(resources.GetObject("button_Save.Image")));
            this.button_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Save.Location = new System.Drawing.Point(705, 741);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(183, 80);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("button_Cancel.Image")));
            this.button_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cancel.Location = new System.Drawing.Point(956, 741);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(183, 80);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(120, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(456, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Build year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(800, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listed price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(456, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exterior area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(456, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Interior area";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(456, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ownership cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(800, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Estimated Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(120, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Realtor ID";
            // 
            // textBox_RealtorID
            // 
            this.textBox_RealtorID.Location = new System.Drawing.Point(120, 180);
            this.textBox_RealtorID.Name = "textBox_RealtorID";
            this.textBox_RealtorID.Size = new System.Drawing.Size(141, 27);
            this.textBox_RealtorID.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(120, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Postal code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(120, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 23);
            this.label13.TabIndex = 17;
            this.label13.Text = "Address line 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(120, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "Address line 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(456, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "House information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(800, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Price informations";
            // 
            // textbox_PostalCode
            // 
            this.textbox_PostalCode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_PostalCode.Location = new System.Drawing.Point(120, 320);
            this.textbox_PostalCode.Name = "textbox_PostalCode";
            this.textbox_PostalCode.Size = new System.Drawing.Size(222, 31);
            this.textbox_PostalCode.TabIndex = 21;
            // 
            // textbox_AddressLine1
            // 
            this.textbox_AddressLine1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_AddressLine1.Location = new System.Drawing.Point(120, 400);
            this.textbox_AddressLine1.Name = "textbox_AddressLine1";
            this.textbox_AddressLine1.Size = new System.Drawing.Size(222, 31);
            this.textbox_AddressLine1.TabIndex = 22;
            // 
            // textBox_AddressLine2
            // 
            this.textBox_AddressLine2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_AddressLine2.Location = new System.Drawing.Point(120, 460);
            this.textBox_AddressLine2.Name = "textBox_AddressLine2";
            this.textBox_AddressLine2.Size = new System.Drawing.Size(222, 31);
            this.textBox_AddressLine2.TabIndex = 23;
            // 
            // textBox_OwnershipCost
            // 
            this.textBox_OwnershipCost.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_OwnershipCost.Location = new System.Drawing.Point(456, 250);
            this.textBox_OwnershipCost.Name = "textBox_OwnershipCost";
            this.textBox_OwnershipCost.Size = new System.Drawing.Size(222, 31);
            this.textBox_OwnershipCost.TabIndex = 24;
            // 
            // textBox_ExteriorArea
            // 
            this.textBox_ExteriorArea.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ExteriorArea.Location = new System.Drawing.Point(456, 390);
            this.textBox_ExteriorArea.Name = "textBox_ExteriorArea";
            this.textBox_ExteriorArea.Size = new System.Drawing.Size(222, 31);
            this.textBox_ExteriorArea.TabIndex = 25;
            // 
            // textBox_InteriorArea
            // 
            this.textBox_InteriorArea.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_InteriorArea.Location = new System.Drawing.Point(456, 324);
            this.textBox_InteriorArea.Name = "textBox_InteriorArea";
            this.textBox_InteriorArea.Size = new System.Drawing.Size(222, 31);
            this.textBox_InteriorArea.TabIndex = 26;
            // 
            // textBox_BuildYear
            // 
            this.textBox_BuildYear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_BuildYear.Location = new System.Drawing.Point(456, 458);
            this.textBox_BuildYear.Name = "textBox_BuildYear";
            this.textBox_BuildYear.Size = new System.Drawing.Size(222, 31);
            this.textBox_BuildYear.TabIndex = 27;
            // 
            // checkBox_AreYouSure
            // 
            this.checkBox_AreYouSure.AutoSize = true;
            this.checkBox_AreYouSure.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_AreYouSure.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_AreYouSure.Location = new System.Drawing.Point(705, 708);
            this.checkBox_AreYouSure.Name = "checkBox_AreYouSure";
            this.checkBox_AreYouSure.Size = new System.Drawing.Size(434, 27);
            this.checkBox_AreYouSure.TabIndex = 28;
            this.checkBox_AreYouSure.Text = "Are you sure the case information is currect?";
            this.checkBox_AreYouSure.UseVisualStyleBackColor = true;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Price.Location = new System.Drawing.Point(800, 269);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(222, 31);
            this.textBox_Price.TabIndex = 29;
            // 
            // textBox_EstimatedPrice
            // 
            this.textBox_EstimatedPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_EstimatedPrice.Location = new System.Drawing.Point(800, 343);
            this.textBox_EstimatedPrice.Name = "textBox_EstimatedPrice";
            this.textBox_EstimatedPrice.Size = new System.Drawing.Size(222, 31);
            this.textBox_EstimatedPrice.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(17, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 44);
            this.label12.TabIndex = 31;
            this.label12.Text = "Create case";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 652);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 181);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // CreateEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_EstimatedPrice);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.checkBox_AreYouSure);
            this.Controls.Add(this.textBox_BuildYear);
            this.Controls.Add(this.textBox_InteriorArea);
            this.Controls.Add(this.textBox_ExteriorArea);
            this.Controls.Add(this.textBox_OwnershipCost);
            this.Controls.Add(this.textBox_AddressLine2);
            this.Controls.Add(this.textbox_AddressLine1);
            this.Controls.Add(this.textbox_PostalCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_RealtorID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateEntryPage";
            this.Size = new System.Drawing.Size(1169, 845);
            this.Load += new System.EventHandler(this.CreateCasePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_RealtorID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textbox_PostalCode;
        private System.Windows.Forms.TextBox textbox_AddressLine1;
        private System.Windows.Forms.TextBox textBox_AddressLine2;
        private System.Windows.Forms.TextBox textBox_OwnershipCost;
        private System.Windows.Forms.TextBox textBox_ExteriorArea;
        private System.Windows.Forms.TextBox textBox_InteriorArea;
        private System.Windows.Forms.TextBox textBox_BuildYear;
        private System.Windows.Forms.CheckBox checkBox_AreYouSure;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_EstimatedPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
