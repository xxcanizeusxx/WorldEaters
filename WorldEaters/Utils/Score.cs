using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Utils
{
    class Score
    {

        private string[] _playerData;
        private readonly string _docPath = @"C:\EndlessWaves\scores.txt";

        //Constructor checks for a file, if not found it will create a default one.
        public Score()
        {
            if (!File.Exists(_docPath))
            {
                TextWriter tw = new StreamWriter(_docPath);
                tw.Write("Name  " + "Kills  " + "Score" + Environment.NewLine);
                tw.Close();
            }
        }

        //Properties and methods of the Score class
        public string PlayerName { get; private set; }
        public int InvadersKilled { get; private set; } = 0;
        public int PlayerScore { get; private set; } = 0;

        public void AddName(string name)
        {
            PlayerName = name;
        }

        public void IncreaseScore(int amnt)
        {
            PlayerScore += amnt;
        }

        public void setInvadersKilled(int amnt)
        {
            InvadersKilled += amnt;
        }

        //Saves the player score
        public void SaveScore()
        {
            _playerData = new string[] { PlayerName, InvadersKilled.ToString(), PlayerScore.ToString() };

            TextWriter tw = new StreamWriter(_docPath, true);
            for (int i = 0; i < _playerData.Length; i++)
            {
                tw.Write(_playerData[i] + "\t");
            }
            tw.WriteLine();
            tw.Close();
        }

        //Gets the High-Scores from the text file
        public void GetScore()
        {
            int count = 0;
            string line;
            StreamReader sr = new StreamReader(_docPath);
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                count++;
            }
            sr.Close();
        }
    }
}
