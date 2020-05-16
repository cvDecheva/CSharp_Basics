using System;

namespace MeteorFrenzy
{
    public class UI
    {
        public int Score;
        public int BulletCount;
        public Difficulty Difficulty;

        public UI(Difficulty difficulty)
        {
            this.Score = MeteorFrenzy.score;
            this.BulletCount = MeteorFrenzy.bulletCount;
            this.Difficulty = difficulty;
        }

        public void Draw()
        {
            Console.SetCursorPosition(MeteorFrenzy.playField, 0);
            Console.WriteLine("Score: {0}", this.Score.ToString());
            Console.SetCursorPosition(MeteorFrenzy.playField, 1);
            Console.WriteLine("Bullets: {0}", this.BulletCount.ToString());
            Console.SetCursorPosition(MeteorFrenzy.playField, 2);
            Console.WriteLine("Difficulty: {0}   ", this.Difficulty);
        }

        public void DrawFloors(Spacecraft spacecraft)
        {
            for (int j = 1; j < 5; j++)
            {
                for (int i = 0; i < Console.BufferHeight; i++)
                {
                    Console.SetCursorPosition((MeteorFrenzy.SpaceFromWalls * 2 + spacecraft.Elements.Count)*j -j, i);
                    Console.Write("|");
                }
            }
        }

        public void Delete()
        {
            Console.SetCursorPosition(MeteorFrenzy.playField, 0);
            Console.WriteLine(" ");
            Console.SetCursorPosition(MeteorFrenzy.playField, 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(MeteorFrenzy.playField, 2);
            Console.Write(" ");
        }

        public void UpdateUI(int score)
        {
            this.Score = score;
            this.BulletCount = MeteorFrenzy.bulletCount;
            this.Difficulty = MeteorFrenzy.currentDifficulty;
        }
    }
}
