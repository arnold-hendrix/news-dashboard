// icons by Icons8 and Iweb Makers
// UI template by Iweb Makers.
// main page images by TransparentPng, fusion medical animation on Unsplash, Braden Collum on Unsplash, and Alexandre Debiève on Unsplash

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace HomeDashboard
{
    public partial class DashboardForm : Form
    {
        Label NewsArticlesLabel = new Label();  // news category runtime display label.
        Panel ArticlesDisplayPanel = new Panel();  // runtime display panel.


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]  // dll for creating a round rectangular edge around the form.

        private static extern IntPtr CreateRoundRectRgn  // create a round rectangular edge around the form.
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

          );
        public DashboardForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));  // set up round rectangular form 
            // on form init.
            NavPanel.Height = HomeBtn.Height;  // give home button the focus on program start-up.
            NavPanel.Top = HomeBtn.Top;
            NavPanel.Left = HomeBtn.Left;
            HomeBtn.BackColor = Color.FromArgb(46, 51, 73);  // highlight the home button by changing its BackColor property.
            ApiHelper.InitializeClient();  // initialize HttpClient at the start of the application.
            NewsArticlesLabel.Location = new Point(250, 65);  // define properties for news category label.
            NewsArticlesLabel.Size = new Size(517, 58);
            NewsArticlesLabel.BackColor = Color.FromArgb(46, 51, 73);
            NewsArticlesLabel.ForeColor = Color.FromArgb(0, 156, 149);
            NewsArticlesLabel.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            Controls.Add(NewsArticlesLabel);  // add label to form.
            NewsArticlesLabel.Visible = false;  // hide news category label until a news category is selected. 
            ArticlesDisplayPanel.Location = new Point(250, 125); // define properties for news category panel.
            ArticlesDisplayPanel.BackColor = Color.FromArgb(37, 42, 64);
            ArticlesDisplayPanel.Size = new Size(555, 425);
            Controls.Add(ArticlesDisplayPanel);  // add panel to form.
            ArticlesDisplayPanel.Visible = false;  // hide news category panel until a news category is selected.
        }

        // requests articles from the news api using the "general" category param, and then creates labels whose text properties are set
        // to the "title" property of the json object, before being added to the display panel
        private async Task LoadGeneralNewsArticles(string category = "general", string keyword = null)
        {
            int i = 0;
            ApiResponseProcessor processor = new ApiResponseProcessor();
            var newsArticles = await processor.LoadArticles(category, keyword);
            foreach (var article in newsArticles)  // create a label for each of the returned articles.
            {
                ArticlesDisplayPanel.Controls.Add(new Label
                {
                    Text = article.Title,
                    ForeColor = Color.White,
                    Left = 10,
                    Top = (i + 1) * 20,
                    AutoSize = true,
                    MaximumSize = new Size (550, 20)
                });
                i++;
            }


        }

        // requests articles from the news api using the "q" keyword param, and then creates labels whose text properties are set to the
        // "title" property of the json object, before being added to the display panel
        private async Task LoadCovid19NewsArticles(string category = null, string keyword = "covid")
        {
            int i = 0;
            ApiResponseProcessor processor = new ApiResponseProcessor();
            var covid19NewsArticles = await processor.LoadArticles(category, keyword);
            foreach (var article in covid19NewsArticles)
            {
                ArticlesDisplayPanel.Controls.Add(new Label
                {
                    Text = article.Title,
                    ForeColor = Color.White,
                    Left = 10,
                    Top = (i + 1) * 20,
                    AutoSize = true,
                    MaximumSize = new Size(550, 20)
                });
                i++;
            }
        }

        // requests articles from the news api using the "sports" category param, and then creates labels whose text properties are set
        // to the "title" property of the json object, before being added to the display panel
        private async Task LoadSportsNewsArticles(string category = "sports", string keyword = null)
        {
            int i = 0;
            ApiResponseProcessor processor = new ApiResponseProcessor();
            var sportsNewsArticles = await processor.LoadArticles(category, keyword);
            foreach (var article in sportsNewsArticles)
            {
                ArticlesDisplayPanel.Controls.Add(new Label
                {
                    Text = article.Title,
                    ForeColor = Color.White,
                    Left = 10,
                    Top = (i + 1) * 20,
                    AutoSize = true,
                    MaximumSize = new Size(550, 20)
                });
                i++;
            }
        }

        // requests articles from the news api using the "technology" category param, and then creates labels whose text properties are set
        // to the "title" property of the json object, before being added to the display panel
        private async Task LoadTechNewsArticles(string category = "technology", string keyword = null)
        {
            int i = 0;
            ApiResponseProcessor processor = new ApiResponseProcessor();
            var techNewsArticles = await processor.LoadArticles(category, keyword);
            foreach (var article in techNewsArticles)
            {
                ArticlesDisplayPanel.Controls.Add(new Label
                {
                    Text = article.Title,
                    ForeColor = Color.White,
                    Left = 10,
                    Top = (i + 1) * 20,
                    AutoSize = true,
                    MaximumSize = new Size(550, 20)
                });
                i++;
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)  // click event for home button
        {
            NavPanel.Height = HomeBtn.Height;  // place focus on the current button when it's clicked.
            NavPanel.Top = HomeBtn.Top;
            NavPanel.Left = HomeBtn.Left;
            HomeBtn.BackColor = Color.FromArgb(46, 51, 73);  // highlight the button being clicked by changing its BackColor property.
            NewsArticlesLabel.Visible = false;
            ArticlesDisplayPanel.Visible = false;
            LocalNewsPicBox.Visible = true;
            Covid19NewsPicBox.Visible = true;
            SportsNewsPicBox.Visible = true;
            TechNewsPicBox.Visible = true;
            MainPageLbl.Visible = true;
        }

        private async void NewsBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Height = NewsBtn.Height;
            NavPanel.Top = NewsBtn.Top;
            NewsBtn.BackColor = Color.FromArgb(46, 51, 73);
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Latest Local News";  // change display label text to correspond with the selected category.
            NewsArticlesLabel.Visible = true;  // show display label.
            ArticlesDisplayPanel.Visible = true;  //  show panel that hosts news article headlines.
            ArticlesDisplayPanel.Controls.Clear();  // clear previous panel output before adding current output.
            await LoadGeneralNewsArticles();  // news articles retrieved and loaded asynchronously to form.
        }

        private async void Covid19NewsBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Height = Covid19NewsBtn.Height;
            NavPanel.Top = Covid19NewsBtn.Top;
            Covid19NewsBtn.BackColor = Color.FromArgb(46, 51, 73);
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Latest COVID-19 News";
            NewsArticlesLabel.Visible = true;
            ArticlesDisplayPanel.Visible = true;
            ArticlesDisplayPanel.Controls.Clear();
            await LoadCovid19NewsArticles();

        }

        private async void SportsNewsBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Height = SportsNewsBtn.Height;
            NavPanel.Top = SportsNewsBtn.Top;
            SportsNewsBtn.BackColor = Color.FromArgb(46, 51, 73);
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Latest Sports News";
            NewsArticlesLabel.Visible = true;
            ArticlesDisplayPanel.Visible = true;
            ArticlesDisplayPanel.Controls.Clear();
            await LoadSportsNewsArticles();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Height = SettingsBtn.Height;
            NavPanel.Top = SettingsBtn.Top;
            SettingsBtn.BackColor = Color.FromArgb(46, 51, 73);
            ArticlesDisplayPanel.Controls.Clear();
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Settings";
            NewsArticlesLabel.Visible = true;
        }

        private void HomeBtn_Leave(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.FromArgb(24, 30, 54);  // reset BackColor property when focus shifts to another element.
        }

        private void NewsBtn_Leave(object sender, EventArgs e)
        {
            NewsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Covid19NewsBtn_Leave(object sender, EventArgs e)
        {
            Covid19NewsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void SportsNewsBtn_Leave(object sender, EventArgs e)
        {
            SportsNewsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void SettingsBtn_Leave(object sender, EventArgs e)
        {
            SettingsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private async void TechNewsBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Height = TechNewsBtn.Height;
            NavPanel.Top = TechNewsBtn.Top;
            TechNewsBtn.BackColor = Color.FromArgb(46, 51, 73);
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Latest Tech News";
            NewsArticlesLabel.Visible = true;
            ArticlesDisplayPanel.Visible = true;
            ArticlesDisplayPanel.Controls.Clear();
            await LoadTechNewsArticles();
        }

        private void TechNewsBtn_Leave(object sender, EventArgs e)
        {
            TechNewsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private async void LocalNewsPicBox_Click(object sender, EventArgs e)
        {
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Latest Local News";
            NewsArticlesLabel.Visible = true;
            ArticlesDisplayPanel.Visible = true;
            ArticlesDisplayPanel.Controls.Clear();
            await LoadGeneralNewsArticles();
        }

        private async void Covid19NewsPicBox_Click(object sender, EventArgs e)
        {
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Latest COVID-19 News";
            NewsArticlesLabel.Visible = true;
            ArticlesDisplayPanel.Visible = true;
            ArticlesDisplayPanel.Controls.Clear();
            await LoadCovid19NewsArticles();
        }

        private async void SportsNewsPicBox_Click(object sender, EventArgs e)
        {
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Latest Sports News";
            NewsArticlesLabel.Visible = true;
            ArticlesDisplayPanel.Visible = true;
            ArticlesDisplayPanel.Controls.Clear();
            await LoadSportsNewsArticles();
        }

        private async void TechNewsPicBox_Click(object sender, EventArgs e)
        {
            LocalNewsPicBox.Visible = false;
            Covid19NewsPicBox.Visible = false;
            SportsNewsPicBox.Visible = false;
            TechNewsPicBox.Visible = false;
            MainPageLbl.Visible = false;
            NewsArticlesLabel.Text = "Latest Tech News";
            NewsArticlesLabel.Visible = true;
            ArticlesDisplayPanel.Visible = true;
            ArticlesDisplayPanel.Controls.Clear();
            await LoadTechNewsArticles();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
