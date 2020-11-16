namespace GUI
{
    partial class Form_MainPage
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
            this.TopPanelMainPage = new System.Windows.Forms.Panel();
            this.LeftSidePanelMainPage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BottomPanelMainPage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TopPanelMainPage
            // 
            this.TopPanelMainPage.BackColor = System.Drawing.Color.Black;
            this.TopPanelMainPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelMainPage.Location = new System.Drawing.Point(0, 0);
            this.TopPanelMainPage.Name = "TopPanelMainPage";
            this.TopPanelMainPage.Size = new System.Drawing.Size(1500, 40);
            this.TopPanelMainPage.TabIndex = 0;
            // 
            // LeftSidePanelMainPage
            // 
            this.LeftSidePanelMainPage.BackColor = System.Drawing.Color.Black;
            this.LeftSidePanelMainPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidePanelMainPage.Location = new System.Drawing.Point(0, 40);
            this.LeftSidePanelMainPage.Name = "LeftSidePanelMainPage";
            this.LeftSidePanelMainPage.Size = new System.Drawing.Size(40, 960);
            this.LeftSidePanelMainPage.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1460, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 960);
            this.panel1.TabIndex = 2;
            // 
            // BottomPanelMainPage
            // 
            this.BottomPanelMainPage.BackColor = System.Drawing.Color.Black;
            this.BottomPanelMainPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanelMainPage.Location = new System.Drawing.Point(40, 960);
            this.BottomPanelMainPage.Name = "BottomPanelMainPage";
            this.BottomPanelMainPage.Size = new System.Drawing.Size(1420, 40);
            this.BottomPanelMainPage.TabIndex = 3;
            // 
            // Form_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.BottomPanelMainPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LeftSidePanelMainPage);
            this.Controls.Add(this.TopPanelMainPage);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_MainPage";
            this.Text = "Form_MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanelMainPage;
        private System.Windows.Forms.Panel LeftSidePanelMainPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BottomPanelMainPage;
    }
}