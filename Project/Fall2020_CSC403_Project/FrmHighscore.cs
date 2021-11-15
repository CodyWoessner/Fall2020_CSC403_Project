using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Fall2020_CSC403_Project
{
    
    public partial class FrmHighscore : Form
    {
        private String time;
        private String playerName;
        private String strpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\HighScores\","HighScores.dat");
        private List<string> highscoreData = new List<string>();

        public static FrmHighscore instance = null;
        public FrmHighscore()
        {
            InitializeComponent();
        }
        public static FrmHighscore GetInstance(string playtime)
        {
            if (instance == null)
            {
                instance = new FrmHighscore();
                instance.time = playtime;//gets the ingame time from game
                instance.Setup();
            }
            return instance;
        }
        private void Setup()
        {
            getHighscoreData();
            showHighscores();
            playerInput.Show();
            enternameBtn.Show();
            
        }
        // gets the highscore data that is stored locally 
        private void getHighscoreData()
        {

            StreamReader strReader = new StreamReader(strpath);
            while (true)
            {
                String rstring = strReader.ReadLine();
                if (rstring != null && rstring != "/n" )
                {
                    highscoreData.Add(rstring);
                }
                else
                {
                    strReader.Close();
                    
                    return;
                }
            }
        }
        //writes high scores to file
        private void writeHighscoreData()
        {
            //NOTE you must set this path to the path of the highscores.dat file in the project before starting game else the highscores will not be written
            StreamWriter strWriter = new StreamWriter(@"C:\Users\Zoe Semifero\Source\Repos\CodyWoessner\Fall2020_CSC403_Project\Project\Fall2020_CSC403_Project\data\HighScores\Highscores.dat");
            for(int i = 0; i <= highscoreData.Count-1; i++)
            {
                if (i<=5)
                {
                    strWriter.WriteLine(highscoreData[i]);
                }
            }
            strWriter.Close();
        }
        // Shows the highscores 
        private void showHighscores()
        {

            //4 cases based on how many high scores there are currently
            if (highscoreData.Count == 0)
            {
                player1label.Hide();
                rank1label.Hide();
                timeplayer1.Hide();
                player2label.Hide();
                rank2label.Hide();
                timeplayer2.Hide();
                player3label.Hide();
                rank3label.Hide();
                timeplayer3.Hide();
            }
            else if(highscoreData.Count == 2)
            {
                player1label.Show();
                rank1label.Show();
                timeplayer1.Show();
                player2label.Hide();
                rank2label.Hide();
                timeplayer2.Hide();
                player3label.Hide();
                rank3label.Hide();
                timeplayer3.Hide();

                player1label.Text = highscoreData[1];
                timeplayer1.Text = highscoreData[0];

            }
            else if (highscoreData.Count == 4)
            {
                player1label.Show();
                rank1label.Show();
                timeplayer1.Show();
                player2label.Show();
                rank2label.Show();
                timeplayer2.Show();
                player3label.Hide();
                rank3label.Hide();
                timeplayer3.Hide(); 
                player2label.Text = highscoreData[3];
                player1label.Text = highscoreData[1];
                timeplayer1.Text = highscoreData[0];
                timeplayer2.Text = highscoreData[2];

            }
           else if (highscoreData.Count >= 6)
            {
                player1label.Show();
                rank1label.Show();
                timeplayer1.Show();
                player2label.Show();
                rank2label.Show();
                timeplayer2.Show();
                player3label.Show();
                rank3label.Show();
                timeplayer3.Show();
                player2label.Text = highscoreData[3];
                player1label.Text = highscoreData[1];
                player3label.Text = highscoreData[5];
                timeplayer1.Text = highscoreData[0];
                timeplayer2.Text = highscoreData[2];
                timeplayer3.Text = highscoreData[4];
            }
        }
        // calculates the high scores based on the players time
        private void calculateHighscores()
        {
            if (Timefaster(1))
            {
                highscoreData.Insert(0, time);
                highscoreData.Insert(1, playerName);
                
            }
            else if (Timefaster(2))
            {
                highscoreData.Insert(2, time);
                highscoreData.Insert(3, playerName);
                

            }
            else if (Timefaster(3))
            {
                highscoreData.Insert(4, time);
                highscoreData.Insert(5, playerName);
                

            }
            showHighscores();
        }
        // function that returns true if player's time is faster than the player rank given to the function 1st,2nd,3rd
        private bool Timefaster(int player)
        {
            if(player == 1 && highscoreData.Count>=2)
            {
                if (TimeSpan.ParseExact(time, @"hh\:mm\:ss", CultureInfo.InvariantCulture) <= TimeSpan.ParseExact(highscoreData[0], @"hh\:mm\:ss", CultureInfo.InvariantCulture))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (player == 2 && highscoreData.Count >= 4)
            {
                if (TimeSpan.ParseExact(time, @"hh\:mm\:ss", CultureInfo.InvariantCulture) <= TimeSpan.ParseExact(highscoreData[2], @"hh\:mm\:ss", CultureInfo.InvariantCulture))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (player == 3 && highscoreData.Count >= 6)
            {
                if (TimeSpan.ParseExact(time, @"hh\:mm\:ss", CultureInfo.InvariantCulture) <= TimeSpan.ParseExact(highscoreData[4], @"hh\:mm\:ss", CultureInfo.InvariantCulture))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
           
        }
        // When player enters name the new high scores are calculated and displayed for the player
        private void enternameBtn_Click(object sender, EventArgs e)
        {
            playerName = playerInput.Text;
            enternameBtn.Hide();
            playerInput.Hide();
            calculateHighscores();
            showHighscores();
            writeHighscoreData();
        }
    }
}
