using System;
using System.Collections.Generic;

namespace MeteorFrenzy
{
    public class Spacecraft
    {
        public Vector2 Position;
        public List<string> Elements;
        public List<Bullet> Clip;

        public Spacecraft()
        {
            this.Elements = new List<string>
            {
                "    .    ",
                "   / \\   ",
                "  .|||.  ",
                " /|...|\\ ",
                "/ |   | \\",
                "\\/\\|||/\\/",
                "  ((.))  "
            };
            this.Position = new Vector2(MeteorFrenzy.SpaceFromWalls, Console.BufferHeight - Elements.Count - 2);
            this.Clip = new List<Bullet>();
        }

        public void Draw()
        {
            for (int i = 0; i < this.Elements.Count; i++)
            {
                Console.SetCursorPosition(this.Position.X, this.Position.Y + i);
                Console.Write(this.Elements[i]);
            }
        }

        public void Delete()
        {
            for (int i = 0; i < this.Elements.Count; i++)
            {
                Console.SetCursorPosition(this.Position.X, this.Position.Y + i);
                Console.Write(new string(' ', this.Elements[i].Length));
            }
        }

        public void Move(int floor)
        {
            this.Position.X = floor * MeteorFrenzy.SpaceFromWalls +
                (floor - 1) * MeteorFrenzy.SpaceFromWalls + (floor - 1) * this.Elements.Count - floor;
        }
    }
}
