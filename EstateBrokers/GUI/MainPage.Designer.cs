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
            this.panel_top_mainpage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Close_FrontPage = new System.Windows.Forms.Button();
            this.button_Home_FrontPage = new System.Windows.Forms.Button();
            this.panel_left_mainpage = new System.Windows.Forms.Panel();
            this.panel_botton_mainpage = new System.Windows.Forms.Panel();
            this.panel_right_mainpage = new System.Windows.Forms.Panel();
            this.panel_MainContainer = new System.Windows.Forms.Panel();
            this.loginPage1 = new GUI.LoginPage();
            this.button_support_mainpage = new System.Windows.Forms.Button();
            this.button_estimates_mainpage = new System.Windows.Forms.Button();
            this.button_openhouse_mainpage = new System.Windows.Forms.Button();
            this.button_cases_mainpage = new System.Windows.Forms.Button();
            this.casesPage1 = new GUI.EntryPage();
            this.estimatesPage1 = new GUI.EstimatesPage();
            this.supportPage1 = new GUI.SupportPage();
            this.openHousePage1 = new GUI.OpenHousePage();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.panel_top_mainpage.SuspendLayout();
            this.panel_MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top_mainpage
            // 
            this.panel_top_mainpage.BackColor = System.Drawing.Color.Black;
            this.panel_top_mainpage.Controls.Add(this.button_LogOut);
            this.panel_top_mainpage.Controls.Add(this.label1);
            this.panel_top_mainpage.Controls.Add(this.button_Close_FrontPage);
            this.panel_top_mainpage.Controls.Add(this.button_Home_FrontPage);
            this.panel_top_mainpage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_mainpage.Location = new System.Drawing.Point(0, 0);
            this.panel_top_mainpage.Name = "panel_top_mainpage";
            this.panel_top_mainpage.Size = new System.Drawing.Size(1500, 40);
            this.panel_top_mainpage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1210, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "EstateBrokers";
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
            this.button_Close_FrontPage.Click += new System.EventHandler(this.button_Close_FrontPage_Click);
            // 
            // button_Home_FrontPage
            // 
            this.button_Home_FrontPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home_FrontPage.ForeColor = System.Drawing.Color.White;
            this.button_Home_FrontPage.Image = ((System.Drawing.Image)(resources.GetObject("button_Home_FrontPage.Image")));
            this.button_Home_FrontPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home_FrontPage.Location = new System.Drawing.Point(46, 1);
            this.button_Home_FrontPage.Name = "button_Home_FrontPage";
            this.button_Home_FrontPage.Size = new System.Drawing.Size(126, 40);
            this.button_Home_FrontPage.TabIndex = 4;
            this.button_Home_FrontPage.Text = "Home";
            this.button_Home_FrontPage.UseVisualStyleBackColor = true;
            this.button_Home_FrontPage.Click += new System.EventHandler(this.button_Home_FrontPage_Click);
            // 
            // panel_left_mainpage
            // 
            this.panel_left_mainpage.BackColor = System.Drawing.Color.Black;
            this.panel_left_mainpage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left_mainpage.Location = new System.Drawing.Point(0, 40);
            this.panel_left_mainpage.Name = "panel_left_mainpage";
            this.panel_left_mainpage.Size = new System.Drawing.Size(40, 960);
            this.panel_left_mainpage.TabIndex = 1;
            // 
            // panel_botton_mainpage
            // 
            this.panel_botton_mainpage.BackColor = System.Drawing.Color.Black;
            this.panel_botton_mainpage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botton_mainpage.Location = new System.Drawing.Point(40, 960);
            this.panel_botton_mainpage.Name = "panel_botton_mainpage";
            this.panel_botton_mainpage.Size = new System.Drawing.Size(1460, 40);
            this.panel_botton_mainpage.TabIndex = 2;
            // 
            // panel_right_mainpage
            // 
            this.panel_right_mainpage.BackColor = System.Drawing.Color.Black;
            this.panel_right_mainpage.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right_mainpage.Location = new System.Drawing.Point(1460, 40);
            this.panel_right_mainpage.Name = "panel_right_mainpage";
            this.panel_right_mainpage.Size = new System.Drawing.Size(40, 920);
            this.panel_right_mainpage.TabIndex = 3;
            // 
            // panel_MainContainer
            // 
            this.panel_MainContainer.BackColor = System.Drawing.Color.White;
            this.panel_MainContainer.Controls.Add(this.loginPage1);
            this.panel_MainContainer.Controls.Add(this.button_support_mainpage);
            this.panel_MainContainer.Controls.Add(this.button_estimates_mainpage);
            this.panel_MainContainer.Controls.Add(this.button_openhouse_mainpage);
            this.panel_MainContainer.Controls.Add(this.button_cases_mainpage);
            this.panel_MainContainer.Controls.Add(this.casesPage1);
            this.panel_MainContainer.Controls.Add(this.estimatesPage1);
            this.panel_MainContainer.Controls.Add(this.supportPage1);
            this.panel_MainContainer.Controls.Add(this.openHousePage1);
            this.panel_MainContainer.Location = new System.Drawing.Point(46, 43);
            this.panel_MainContainer.Name = "panel_MainContainer";
            this.panel_MainContainer.Size = new System.Drawing.Size(1423, 920);
            this.panel_MainContainer.TabIndex = 4;
            // 
            // loginPage1
            // 
            this.loginPage1.BackColor = System.Drawing.Color.White;
            this.loginPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPage1.Location = new System.Drawing.Point(-1, -3);
            this.loginPage1.Margin = new System.Windows.Forms.Padding(4);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.Size = new System.Drawing.Size(1424, 923);
            this.loginPage1.TabIndex = 9;
            // 
            // button_support_mainpage
            // 
            this.button_support_mainpage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_support_mainpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_support_mainpage.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_support_mainpage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_support_mainpage.Image = ((System.Drawing.Image)(resources.GetObject("button_support_mainpage.Image")));
            this.button_support_mainpage.Location = new System.Drawing.Point(1090, 0);
            this.button_support_mainpage.Name = "button_support_mainpage";
            this.button_support_mainpage.Size = new System.Drawing.Size(331, 908);
            this.button_support_mainpage.TabIndex = 1;
            this.button_support_mainpage.Text = "\r\n\r\nSupport";
            this.button_support_mainpage.UseVisualStyleBackColor = false;
            this.button_support_mainpage.Click += new System.EventHandler(this.button_support_mainpage_Click);
            // 
            // button_estimates_mainpage
            // 
            this.button_estimates_mainpage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_estimates_mainpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_estimates_mainpage.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_estimates_mainpage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_estimates_mainpage.Image = ((System.Drawing.Image)(resources.GetObject("button_estimates_mainpage.Image")));
            this.button_estimates_mainpage.Location = new System.Drawing.Point(727, 0);
            this.button_estimates_mainpage.Name = "button_estimates_mainpage";
            this.button_estimates_mainpage.Size = new System.Drawing.Size(331, 908);
            this.button_estimates_mainpage.TabIndex = 2;
            this.button_estimates_mainpage.Text = "\r\n\r\nEstimates";
            this.button_estimates_mainpage.UseVisualStyleBackColor = false;
            this.button_estimates_mainpage.Click += new System.EventHandler(this.button_estimates_mainpage_Click);
            // 
            // button_openhouse_mainpage
            // 
            this.button_openhouse_mainpage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_openhouse_mainpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openhouse_mainpage.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_openhouse_mainpage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_openhouse_mainpage.Image = ((System.Drawing.Image)(resources.GetObject("button_openhouse_mainpage.Image")));
            this.button_openhouse_mainpage.Location = new System.Drawing.Point(364, 0);
            this.button_openhouse_mainpage.Name = "button_openhouse_mainpage";
            this.button_openhouse_mainpage.Size = new System.Drawing.Size(331, 908);
            this.button_openhouse_mainpage.TabIndex = 3;
            this.button_openhouse_mainpage.Text = " \r\n\r\n   \r\nOpen  house";
            this.button_openhouse_mainpage.UseVisualStyleBackColor = false;
            this.button_openhouse_mainpage.Click += new System.EventHandler(this.button_openhouse_mainpage_Click);
            // 
            // button_cases_mainpage
            // 
            this.button_cases_mainpage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_cases_mainpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cases_mainpage.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cases_mainpage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_cases_mainpage.Image = ((System.Drawing.Image)(resources.GetObject("button_cases_mainpage.Image")));
            this.button_cases_mainpage.Location = new System.Drawing.Point(0, 0);
            this.button_cases_mainpage.Name = "button_cases_mainpage";
            this.button_cases_mainpage.Size = new System.Drawing.Size(331, 908);
            this.button_cases_mainpage.TabIndex = 4;
            this.button_cases_mainpage.Text = "\r\n\r\nCases";
            this.button_cases_mainpage.UseVisualStyleBackColor = false;
            this.button_cases_mainpage.Click += new System.EventHandler(this.button_cases_mainpage_Click);
            // 
            // casesPage1
            // 
            this.casesPage1.BackColor = System.Drawing.Color.White;
            this.casesPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.casesPage1.Location = new System.Drawing.Point(-6, -3);
            this.casesPage1.Margin = new System.Windows.Forms.Padding(4);
            this.casesPage1.Name = "casesPage1";
            this.casesPage1.Size = new System.Drawing.Size(1427, 920);
            this.casesPage1.TabIndex = 5;
            // 
            // estimatesPage1
            // 
            this.estimatesPage1.BackColor = System.Drawing.Color.White;
            this.estimatesPage1.Location = new System.Drawing.Point(0, 0);
            this.estimatesPage1.Name = "estimatesPage1";
            this.estimatesPage1.Size = new System.Drawing.Size(1423, 908);
            this.estimatesPage1.TabIndex = 6;
            // 
            // supportPage1
            // 
            this.supportPage1.BackColor = System.Drawing.Color.White;
            this.supportPage1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supportPage1.Location = new System.Drawing.Point(-2, 0);
            this.supportPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.supportPage1.Name = "supportPage1";
            this.supportPage1.Size = new System.Drawing.Size(1423, 908);
            this.supportPage1.TabIndex = 7;
            // 
            // openHousePage1
            // 
            this.openHousePage1.BackColor = System.Drawing.Color.White;
            this.openHousePage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openHousePage1.Location = new System.Drawing.Point(-6, 0);
            this.openHousePage1.Name = "openHousePage1";
            this.openHousePage1.Size = new System.Drawing.Size(1429, 917);
            this.openHousePage1.TabIndex = 8;
            // 
            // button_LogOut
            // 
            this.button_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LogOut.ForeColor = System.Drawing.Color.White;
            this.button_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("button_LogOut.Image")));
            this.button_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_LogOut.Location = new System.Drawing.Point(178, 1);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(126, 40);
            this.button_LogOut.TabIndex = 6;
            this.button_LogOut.Text = "Logout";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.panel_MainContainer);
            this.Controls.Add(this.panel_right_mainpage);
            this.Controls.Add(this.panel_botton_mainpage);
            this.Controls.Add(this.panel_left_mainpage);
            this.Controls.Add(this.panel_top_mainpage);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel_top_mainpage.ResumeLayout(false);
            this.panel_top_mainpage.PerformLayout();
            this.panel_MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top_mainpage;
        private System.Windows.Forms.Panel panel_left_mainpage;
        private System.Windows.Forms.Panel panel_botton_mainpage;
        private System.Windows.Forms.Panel panel_right_mainpage;
        private System.Windows.Forms.Button button_Home_FrontPage;
        private System.Windows.Forms.Button button_Close_FrontPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel_MainContainer;
        private System.Windows.Forms.Button button_support_mainpage;
        private System.Windows.Forms.Button button_estimates_mainpage;
        private System.Windows.Forms.Button button_openhouse_mainpage;
        private System.Windows.Forms.Button button_cases_mainpage;
        private EntryPage casesPage1;
        private EstimatesPage estimatesPage1;
        private SupportPage supportPage1;
        private OpenHousePage openHousePage1;
        private LoginPage loginPage1;
        private PropertyValuationPage propertyValuationPage1;
        private System.Windows.Forms.Button button_LogOut;
    }
}