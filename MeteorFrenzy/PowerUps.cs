using System;

namespace MeteorFrenzy
{
    public class PowerUps
    {
        public Vector2 Position;
        public Vector2 Velocity;
        public string Element;
        public int Type;

        public PowerUps(Vector2 position, int type)
        {
            this.Position = position;
            this.Velocity = new Vector2(0, 1);
            this.Type = type;
            if (type == 1)
            {
                this.Element = "->";
            }
            else
            {
                this.Element = "==>";
            }
        }

        public void Draw(int type)
        {
            Console.SetCursorPosition(this.Position.X, this.Position.Y);
            if (type == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(this.Element);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Delete()
        {
            Console.SetCursorPosition(this.Position.X, this.Position.Y);
            Console.Write("    ");
        }

        public void Move()
        {
            this.Position.Add(this.Velocity);
        }
    }
}
