using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEaters.Defenders;
using WorldEaters.Eaters;
using WorldEaters.Levels;
using WorldEaters.Utils;

namespace WorldEaters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new Map (X coordinate, Y coordinate)
            World world = new World(8, 5);
            Score player = new Score();
            player.AddName("Zeus");


            try
            {
                //Create a path for the player
                Path path = new Path(
                    new[] {
                        new WorldLocation(0, 2, world),
                        new WorldLocation(1, 2, world),
                        new WorldLocation(2, 2, world),
                        new WorldLocation(3, 2, world),
                        new WorldLocation(4, 2, world),
                        new WorldLocation(5, 2, world),
                        new WorldLocation(6, 2, world),
                        new WorldLocation(7, 2, world)
                    }
                );

                //Create new invaders to go down the path
                IEater[] eaters =
                {
                    new BasicEater(path),
                    new ArmoredEater(path),
                    new FastEater(path),
                    new SpectralEater(path)

                };

                //Place The towers
                Defender[] defenders =
                {
                    new Defender(new WorldLocation(1, 3, world), path, player),
                    new Flamer(new WorldLocation(2, 3, world), path, player),
                    new Sniper(new WorldLocation(3, 3, world), path, player)
                   
                };



                //Start the Game
                Level1 level = new Level1(eaters)
                {
                    Defenders = defenders
                };

                bool playerWon = level.Play();
                Console.WriteLine(playerWon ? "Congrats You Won " + player.PlayerName : "Sorry You lost " + player.PlayerName);
                Console.WriteLine("Press 1 to save score, 2 to display scores");
                int userSel = Convert.ToInt32(Console.ReadLine());
                switch (userSel)
                {
                    case 1:
                        player.SaveScore();
                        Console.WriteLine("Score Saved!");
                        break;

                    case 2:
                        player.GetScore();
                        break;
                }
            }

            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OnPathException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WordlEatersExceptions)
            {
                Console.WriteLine("Unhandled EWException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception " + ex);
            }
        }
    }
}
