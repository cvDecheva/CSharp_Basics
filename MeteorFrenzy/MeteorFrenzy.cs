//Cvetelina Decheva
using System;
using System.Collections.Generic;
using System.Threading;

namespace MeteorFrenzy
{
    class MeteorFrenzy
    {
        public static int SpaceFromWalls = 8;
        public static Random rng = new Random();
        public static bool isGameOver = false;
        public static int bulletCount = 3;
        public static int playField = Console.BufferWidth - 20;
        public static int startTimer = 0;
        public static int threadSleep = 200;
        public static Difficulty currentDifficulty = Difficulty.EASY;
        public static int score = 0;
        public static int destroyedMeteors = 0;
        public static int respawnTime = 20;
        public static int countOfMeteors = 0;

        static void Main()
        {
            Console.BufferWidth = Console.WindowWidth = 120;
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.CursorVisible = false;

            Spacecraft spacecraft = new Spacecraft();
            List<PowerUps> powerUps = new List<PowerUps>();
            List<Meteor> meteors = new List<Meteor>();
            UI ui = new UI(currentDifficulty);

            ui.DrawFloors(spacecraft);

            while (!isGameOver)
            {
                startTimer++;
                MovePowerUps(powerUps);
                MoveBullets(spacecraft);
                MoveMeteors(meteors);
                MeteorGenerator(meteors, spacecraft);
                PowerUpsGenerator(powerUps, spacecraft, meteors);
                InputHandler(spacecraft);
                ui.UpdateUI(score);

                spacecraft.Draw();
                ui.Draw();
                foreach (var bullet in spacecraft.Clip)
                {
                    bullet.Draw();
                }
                foreach (var meteor in meteors)
                {
                    meteor.Draw();
                }
                foreach (var powerUp in powerUps)
                {
                    powerUp.Draw(powerUp.Type);
                }

                Thread.Sleep(threadSleep);

                SpacecraftMeteorsCollision(spacecraft, meteors);
                BulletMeteorCollision(spacecraft.Clip, meteors, powerUps);
                SpacecraftPowerUpCollision(spacecraft, powerUps);

                spacecraft.Delete();
                ui.Delete();
                foreach (var bullet in spacecraft.Clip)
                {
                    bullet.Delete();
                }
                foreach (var meteor in meteors)
                {
                    meteor.Delete();
                }
                foreach (var powerUp in powerUps)
                {
                    powerUp.Delete();
                }

                score++;
                ChangeDifficulty();
            }
        }

        public static void ChangeDifficulty()
        {
            int changeDifficulty = 200;
            if (score % changeDifficulty == 0 && currentDifficulty == Difficulty.EASY)
            {
                currentDifficulty = Difficulty.MEDIUM;
                threadSleep = 100;
                respawnTime = 15;
            }
            else if (score % changeDifficulty == 0 && currentDifficulty == Difficulty.MEDIUM)
            {
                currentDifficulty = Difficulty.HARD;
                threadSleep = 50;
                respawnTime = 10;
            }
        }

        public static void InputHandler(Spacecraft spacecraft)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey();
                }

                if (userInput.Key == ConsoleKey.Q)
                {
                    spacecraft.Move(1);
                }
                else if (userInput.Key == ConsoleKey.W)
                {
                    spacecraft.Move(2);
                }
                else if (userInput.Key == ConsoleKey.E)
                {
                    spacecraft.Move(3);
                }
                else if (userInput.Key == ConsoleKey.R)
                {
                    spacecraft.Move(4);
                }
                else if (userInput.Key == ConsoleKey.Spacebar)
                {
                    if (bulletCount > 0)
                    {
                        Bullet bullet = new Bullet(new Vector2(spacecraft.Position.X + spacecraft.Elements[0].Length / 2 - 1, spacecraft.Position.Y));
                        spacecraft.Clip.Add(bullet);
                        bulletCount--;
                    }
                }
            }
        }

        #region Collision methods
        public static void BulletMeteorCollision(List<Bullet> bullets, List<Meteor> meteors, List<PowerUps> powerUps)
        {
            for (int k = 0; k < bullets.Count; k++)
            {
                for (int i = 0; i < meteors.Count; i++)
                {
                    if (meteors[i].Position.IsColliding(bullets[k].Position, 1, 1))
                    {
                        destroyedMeteors++;
                        if (destroyedMeteors % 5 == 0)
                        {
                            PowerUpsGenerator(powerUps, meteors[i]);
                        }
                        meteors[i].Delete();
                        meteors.Remove(meteors[i]);
                        bullets[k].Delete();
                        bullets.Remove(bullets[k]);
                        score += 20;

                        return;
                    }
                }
            }
        }

        public static void SpacecraftPowerUpCollision(Spacecraft spacecraft, List<PowerUps> powerUps)
        {
            for (int i = 0; i < powerUps.Count; i++)
            {
                if (powerUps[i].Position.IsColliding(spacecraft.Position, spacecraft.Elements[0].Length, spacecraft.Elements.Count))
                {
                    if (powerUps[i].Type == 1)
                    {
                        bulletCount++;
                    }
                    else
                    {
                        bulletCount += 4;
                    }
                    powerUps[i].Delete();
                    powerUps.Remove(powerUps[i]);
                }
            }
        }

        public static void SpacecraftMeteorsCollision(Spacecraft spacecraft, List<Meteor> meteors)
        {
            foreach (var meteor in meteors)
            {
                if (meteor.Position.IsColliding(spacecraft.Position, spacecraft.Elements[0].Length, spacecraft.Elements.Count))
                {
                    isGameOver = true;
                    Console.Clear();
                    Console.WriteLine("You Lost");
                    Console.WriteLine("Score: {0}", score);
                    Thread.Sleep(1000);
                }
            }
        }
        #endregion

        #region Move methods
        public static void MoveBullets(Spacecraft spacecraft)
        {
            for (int i = 0; i < spacecraft.Clip.Count; i++)
            {
                if (spacecraft.Clip[i].Position.Y == 0)
                {
                    spacecraft.Clip[i].Delete();
                    spacecraft.Clip.Remove(spacecraft.Clip[i]);
                    i--;
                }
                else
                {
                    spacecraft.Clip[i].MoveBullet();
                }
            }
        }

        public static void MovePowerUps(List<PowerUps> powerUps)
        {
            for (int i = 0; i < powerUps.Count; i++)
            {
                if (powerUps[i].Position.Y == Console.BufferHeight - powerUps.Count)
                {
                    powerUps[i].Delete();
                    powerUps.Remove(powerUps[i]);
                    i--;
                }
                else
                {
                    powerUps[i].Move();
                }
            }
        }

        public static void MoveMeteors(List<Meteor> meteors)
        {
            for (int i = 0; i < meteors.Count; i++)
            {
                if (meteors[i].Position.Y == Console.BufferHeight - meteors.Count)
                {
                    meteors[i].Delete();
                    meteors.Remove(meteors[i]);
                    i--;
                }
                else
                {
                    meteors[i].MoveMeteor();
                }
            }
        }
        #endregion

        #region Generator methods
        public static void MeteorGenerator(List<Meteor> meteors, Spacecraft spacecraft)
        {

            if (startTimer % respawnTime == 0)
            {
                int floor = rng.Next(1, 5);
                int widthOfFloor = (SpaceFromWalls * 2 + spacecraft.Elements.Count) - 1;
                meteors.Add(new Meteor(new Vector2(((SpaceFromWalls * 2 + spacecraft.Elements.Count) * floor - floor) - widthOfFloor / 2, 0),
                    1));//rng.Next(1, 5)));
            }
            countOfMeteors++;
        }

        public static void PowerUpsGenerator(List<PowerUps> powerUps, Spacecraft spacecraft, List<Meteor> meteors)
        {
            int respawnTime = rng.Next(1, 500);
            if (startTimer % respawnTime == 0)
            {
                int floor = rng.Next(1, 5);
                int widthOfFloor = (SpaceFromWalls * 2 + spacecraft.Elements.Count) - 1;
                powerUps.Add(new PowerUps(new Vector2(((SpaceFromWalls * 2 + spacecraft.Elements.Count) * floor - floor) - widthOfFloor / 2, 0), 1));
            }
        }

        public static void PowerUpsGenerator(List<PowerUps> powerUps, Meteor meteor)
        {
            powerUps.Add(new PowerUps(meteor.Position, 2));
        }
        #endregion
    }
}
