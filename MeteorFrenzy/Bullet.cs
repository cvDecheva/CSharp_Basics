using System;
using System.Collections.Generic;
namespace MeteorFrenzy
{
    public class Bullet
    {
        public Vector2 Position;
        public Vector2 Velocity;
        public List<string> Elements;

        public Bullet(Vector2 position)
        {
            this.Position = position;
            this.Velocity = new Vector2(0, -1);
            this.Elements = new List<string>
            {
                " _",
                "/ \\",
                "\\ /",
                "||| ",
            };
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
                Console.Write("   ");
            }
        }

        public void MoveBullet()
        {
            this.Position.Add(this.Velocity);
        }
    }
}

