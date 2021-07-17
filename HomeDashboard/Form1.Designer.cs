
namespace HomeDashboard
{
    partial class DashboardForm
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.UserLogInfoLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.DashLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MainPageLbl = new System.Windows.Forms.Label();
            this.SportsNewsPicBox = new System.Windows.Forms.PictureBox();
            this.TechNewsPicBox = new System.Windows.Forms.PictureBox();
            this.LocalNewsPicBox = new System.Windows.Forms.PictureBox();
            this.Covid19NewsPicBox = new System.Windows.Forms.PictureBox();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.TechNewsBtn = new System.Windows.Forms.Button();
            this.SportsNewsBtn = new System.Windows.Forms.Button();
            this.Covid19NewsBtn = new System.Windows.Forms.Button();
            this.NewsBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SportsNewsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechNewsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalNewsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19NewsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.LeftPanel.Controls.Add(this.SettingsBtn);
            this.LeftPanel.Controls.Add(this.TechNewsBtn);
            this.LeftPanel.Controls.Add(this.SportsNewsBtn);
            this.LeftPanel.Controls.Add(this.Covid19NewsBtn);
            this.LeftPanel.Controls.Add(this.NewsBtn);
            this.LeftPanel.Controls.Add(this.HomeBtn);
            this.LeftPanel.Controls.Add(this.UserPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(209, 577);
            this.LeftPanel.TabIndex = 0;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.NavPanel);
            this.UserPanel.Controls.Add(this.UserLogInfoLabel);
            this.UserPanel.Controls.Add(this.UserLabel);
            this.UserPanel.Controls.Add(this.UserPictureBox);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(209, 207);
            this.UserPanel.TabIndex = 0;
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NavPanel.Location = new System.Drawing.Point(0, 193);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(3, 100);
            this.NavPanel.TabIndex = 3;
            // 
            // UserLogInfoLabel
            // 
            this.UserLogInfoLabel.AutoSize = true;
            this.UserLogInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.UserLogInfoLabel.Location = new System.Drawing.Point(74, 170);
            this.UserLogInfoLabel.Name = "UserLogInfoLabel";
            this.UserLogInfoLabel.Size = new System.Drawing.Size(44, 15);
            this.UserLogInfoLabel.TabIndex = 2;
            this.UserLogInfoLabel.Text = "Active";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.UserLabel.Location = new System.Drawing.Point(73, 141);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(49, 20);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "User";
            // 
            // DashLabel
            // 
            this.DashLabel.AutoSize = true;
            this.DashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DashLabel.Location = new System.Drawing.Point(225, 17);
            this.DashLabel.Name = "DashLabel";
            this.DashLabel.Size = new System.Drawing.Size(296, 39);
            this.DashLabel.TabIndex = 1;
            this.DashLabel.Text = "News Dashboard";
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(905, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 39);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MainPageLbl
            // 
            this.MainPageLbl.AutoSize = true;
            this.MainPageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.MainPageLbl.Location = new System.Drawing.Point(325, 65);
            this.MainPageLbl.Name = "MainPageLbl";
            this.MainPageLbl.Size = new System.Drawing.Size(517, 58);
            this.MainPageLbl.TabIndex = 1;
            this.MainPageLbl.Text = "Get up to date with the latest in local news, \r\n       COVID-19, sports, and tech" +
    "nology.";
            // 
            // SportsNewsPicBox
            // 
            this.SportsNewsPicBox.Image = global::HomeDashboard.Properties.Resources.braden_collum_9HI8UJMSdZA_unsplash;
            this.SportsNewsPicBox.Location = new System.Drawing.Point(299, 365);
            this.SportsNewsPicBox.Name = "SportsNewsPicBox";
            this.SportsNewsPicBox.Size = new System.Drawing.Size(235, 180);
            this.SportsNewsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SportsNewsPicBox.TabIndex = 3;
            this.SportsNewsPicBox.TabStop = false;
            this.SportsNewsPicBox.Click += new System.EventHandler(this.SportsNewsPicBox_Click);
            // 
            // TechNewsPicBox
            // 
            this.TechNewsPicBox.Image = global::HomeDashboard.Properties.Resources.alexandre_debieve_FO7JIlwjOtU_unsplash;
            this.TechNewsPicBox.Location = new System.Drawing.Point(607, 365);
            this.TechNewsPicBox.Name = "TechNewsPicBox";
            this.TechNewsPicBox.Size = new System.Drawing.Size(235, 180);
            this.TechNewsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TechNewsPicBox.TabIndex = 3;
            this.TechNewsPicBox.TabStop = false;
            this.TechNewsPicBox.Click += new System.EventHandler(this.TechNewsPicBox_Click);
            // 
            // LocalNewsPicBox
            // 
            this.LocalNewsPicBox.Image = global::HomeDashboard.Properties.Resources.icons8_maple_leaf_90;
            this.LocalNewsPicBox.Location = new System.Drawing.Point(299, 141);
            this.LocalNewsPicBox.Name = "LocalNewsPicBox";
            this.LocalNewsPicBox.Size = new System.Drawing.Size(235, 180);
            this.LocalNewsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LocalNewsPicBox.TabIndex = 3;
            this.LocalNewsPicBox.TabStop = false;
            this.LocalNewsPicBox.Click += new System.EventHandler(this.LocalNewsPicBox_Click);
            // 
            // Covid19NewsPicBox
            // 
            this.Covid19NewsPicBox.Image = global::HomeDashboard.Properties.Resources.fusion_medical_animation_rnr8D3FNUNY_unsplash;
            this.Covid19NewsPicBox.Location = new System.Drawing.Point(607, 141);
            this.Covid19NewsPicBox.Name = "Covid19NewsPicBox";
            this.Covid19NewsPicBox.Size = new System.Drawing.Size(235, 180);
            this.Covid19NewsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Covid19NewsPicBox.TabIndex = 3;
            this.Covid19NewsPicBox.TabStop = false;
            this.Covid19NewsPicBox.Click += new System.EventHandler(this.Covid19NewsPicBox_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SettingsBtn.Image = global::HomeDashboard.Properties.Resources.icons8_services_30;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 535);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(209, 42);
            this.SettingsBtn.TabIndex = 1;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            this.SettingsBtn.Leave += new System.EventHandler(this.SettingsBtn_Leave);
            // 
            // TechNewsBtn
            // 
            this.TechNewsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TechNewsBtn.FlatAppearance.BorderSize = 0;
            this.TechNewsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TechNewsBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechNewsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TechNewsBtn.Image = global::HomeDashboard.Properties.Resources.icons8_mind_map_30;
            this.TechNewsBtn.Location = new System.Drawing.Point(0, 375);
            this.TechNewsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TechNewsBtn.Name = "TechNewsBtn";
            this.TechNewsBtn.Size = new System.Drawing.Size(209, 42);
            this.TechNewsBtn.TabIndex = 1;
            this.TechNewsBtn.Text = "Tech   ";
            this.TechNewsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TechNewsBtn.UseVisualStyleBackColor = true;
            this.TechNewsBtn.Click += new System.EventHandler(this.TechNewsBtn_Click);
            this.TechNewsBtn.Leave += new System.EventHandler(this.TechNewsBtn_Leave);
            // 
            // SportsNewsBtn
            // 
            this.SportsNewsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SportsNewsBtn.FlatAppearance.BorderSize = 0;
            this.SportsNewsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SportsNewsBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SportsNewsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SportsNewsBtn.Image = global::HomeDashboard.Properties.Resources.icons8_soccer_ball_30;
            this.SportsNewsBtn.Location = new System.Drawing.Point(0, 333);
            this.SportsNewsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SportsNewsBtn.Name = "SportsNewsBtn";
            this.SportsNewsBtn.Size = new System.Drawing.Size(209, 42);
            this.SportsNewsBtn.TabIndex = 1;
            this.SportsNewsBtn.Text = "Sports";
            this.SportsNewsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SportsNewsBtn.UseVisualStyleBackColor = true;
            this.SportsNewsBtn.Click += new System.EventHandler(this.SportsNewsBtn_Click);
            this.SportsNewsBtn.Leave += new System.EventHandler(this.SportsNewsBtn_Leave);
            // 
            // Covid19NewsBtn
            // 
            this.Covid19NewsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Covid19NewsBtn.FlatAppearance.BorderSize = 0;
            this.Covid19NewsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Covid19NewsBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Covid19NewsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Covid19NewsBtn.Image = global::HomeDashboard.Properties.Resources.icons8_sneezing_in_a_tissue_30;
            this.Covid19NewsBtn.Location = new System.Drawing.Point(0, 291);
            this.Covid19NewsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Covid19NewsBtn.Name = "Covid19NewsBtn";
            this.Covid19NewsBtn.Size = new System.Drawing.Size(209, 42);
            this.Covid19NewsBtn.TabIndex = 1;
            this.Covid19NewsBtn.Text = "Covid19";
            this.Covid19NewsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Covid19NewsBtn.UseVisualStyleBackColor = true;
            this.Covid19NewsBtn.Click += new System.EventHandler(this.Covid19NewsBtn_Click);
            this.Covid19NewsBtn.Leave += new System.EventHandler(this.Covid19NewsBtn_Leave);
            // 
            // NewsBtn
            // 
            this.NewsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewsBtn.FlatAppearance.BorderSize = 0;
            this.NewsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NewsBtn.Image = global::HomeDashboard.Properties.Resources.icons8_europe_news_32;
            this.NewsBtn.Location = new System.Drawing.Point(0, 249);
            this.NewsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewsBtn.Name = "NewsBtn";
            this.NewsBtn.Size = new System.Drawing.Size(209, 42);
            this.NewsBtn.TabIndex = 1;
            this.NewsBtn.Text = "Breaking";
            this.NewsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NewsBtn.UseVisualStyleBackColor = true;
            this.NewsBtn.Click += new System.EventHandler(this.NewsBtn_Click);
            this.NewsBtn.Leave += new System.EventHandler(this.NewsBtn_Leave);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HomeBtn.Image = global::HomeDashboard.Properties.Resources.icons8_home_26;
            this.HomeBtn.Location = new System.Drawing.Point(0, 207);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(209, 42);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home ";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            this.HomeBtn.Leave += new System.EventHandler(this.HomeBtn_Leave);
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UserPictureBox.Image = global::HomeDashboard.Properties.Resources.Untitled_11;
            this.UserPictureBox.Location = new System.Drawing.Point(68, 32);
            this.UserPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(71, 91);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.SportsNewsPicBox);
            this.Controls.Add(this.TechNewsPicBox);
            this.Controls.Add(this.LocalNewsPicBox);
            this.Controls.Add(this.Covid19NewsPicBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MainPageLbl);
            this.Controls.Add(this.DashLabel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SportsNewsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechNewsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalNewsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19NewsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label UserLogInfoLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button SportsNewsBtn;
        private System.Windows.Forms.Button Covid19NewsBtn;
        private System.Windows.Forms.Button NewsBtn;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button TechNewsBtn;
        private System.Windows.Forms.Label DashLabel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label MainPageLbl;
        private System.Windows.Forms.PictureBox Covid19NewsPicBox;
        private System.Windows.Forms.PictureBox TechNewsPicBox;
        private System.Windows.Forms.PictureBox LocalNewsPicBox;
        private System.Windows.Forms.PictureBox SportsNewsPicBox;
    }
}

