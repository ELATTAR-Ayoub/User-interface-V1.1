using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Enterface_V1._1
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            IsLogin(Log_in_Register.Islogin);
        }
        private void IsLogin(Boolean login)
        {
            if (login == false)
            {
                SidePanelAfterLogin.Visible = false;
                
            }
            else
            {
                SidePanelAfterLogin.Visible = true;
                LabelUsername.Text = Log_in_Register.Username;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterSearchBox(object sender, EventArgs e)
        {
            if (SearchBox.Text.Equals("Search here"))
            {
                SearchBox.Text = "";
            }
        }

        private void LeaveSearchBox(object sender, EventArgs e)
        {
            if (SearchBox.Text.Equals(""))
            {
                SearchBox.Text = "Search here";
            }
        }

        private void buttLastUploads_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttLastUploads.Height;
            SidePanel.Top = buttLastUploads.Top;

        }

        private void buttAnimeList_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttAnimeList.Height;
            SidePanel.Top = buttAnimeList.Top;

        }

        private void buttBestAnimes_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttBestAnimes.Height;
            SidePanel.Top = buttBestAnimes.Top;

        }

        private void buttOngoingAnimes_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttOngoingAnimes.Height;
            SidePanel.Top = buttOngoingAnimes.Top;
        }

        private void buttBestSeries_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttBestSeries.Height;
            SidePanel.Top = buttBestSeries.Top;
        }

        private void buttBestMovies_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttBestMovies.Height;
            SidePanel.Top = buttBestMovies.Top;
        }

        private void buttFavorites_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttFavorites.Height;
            SidePanel.Top = buttFavorites.Top;
        }

        private void buttWatchingNow_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttWatchingNow.Height;
            SidePanel.Top = buttWatchingNow.Top;
        }

        private void buttIWannaWatch_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttIWannaWatch.Height;
            SidePanel.Top = buttIWannaWatch.Top;
        }

        private void buttDoneWatching_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttDoneWatching.Height;
            SidePanel.Top = buttDoneWatching.Top;
        }

        private void buttDontWannaWatch_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttDontWannaWatch.Height;
            SidePanel.Top = buttDontWannaWatch.Top;
        }

        private void buttLatestViews_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttLatestViews.Height;
            SidePanel.Top = buttLatestViews.Top;
        }

        private void buttDownloads_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttDownloads.Height;
            SidePanel.Top = buttDownloads.Top;
        }

        private void buttSettings_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttSettings.Height;
            SidePanel.Top = buttSettings.Top;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Log_in_Register Log = new Log_in_Register();
            Log.Show();
        }

        private void SidePanelAfterLogin_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
