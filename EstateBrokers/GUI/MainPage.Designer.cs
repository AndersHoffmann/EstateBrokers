namespace GUI
{
    partial class MainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Close_FrontPage = new System.Windows.Forms.Button();
            this.button_Home_FrontPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button_Close_FrontPage);
            this.panel1.Controls.Add(this.button_Home_FrontPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 40);
            this.panel1.TabIndex = 0;
            // 
            // button_Close_FrontPage
            // 
            this.button_Close_FrontPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close_FrontPage.Image = ((System.Drawing.Image)(resources.GetObject("button_Close_FrontPage.Image")));
            this.button_Close_FrontPage.Location = new System.Drawing.Point(1460, 6);
            this.button_Close_FrontPage.Name = "button_Close_FrontPage";
            this.button_Close_FrontPage.Size = new System.Drawing.Size(32, 31);
            this.button_Close_FrontPage.TabIndex = 4;
            this.button_Close_FrontPage.UseVisualStyleBackColor = true;
            // 
            // button_Home_FrontPage
            // 
            this.button_Home_FrontPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home_FrontPage.ForeColor = System.Drawing.Color.White;
            this.button_Home_FrontPage.Image = ((System.Drawing.Image)(resources.GetObject("button_Home_FrontPage.Image")));
            this.button_Home_FrontPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home_FrontPage.Location = new System.Drawing.Point(40, 0);
            this.button_Home_FrontPage.Name = "button_Home_FrontPage";
            this.button_Home_FrontPage.Size = new System.Drawing.Size(126, 40);
            this.button_Home_FrontPage.TabIndex = 4;
            this.button_Home_FrontPage.Text = "Home";
            this.button_Home_FrontPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 960);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(40, 960);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1460, 40);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1460, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 920);
            this.panel4.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_Home_FrontPage;
        private System.Windows.Forms.Button button_Close_FrontPage;
    }
}