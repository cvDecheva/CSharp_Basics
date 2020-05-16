using System;
using System.Collections.Generic;

namespace MeteorFrenzy
{
    public class Meteor
    {
        public Vector2 Position;
        public Vector2 Velocity;
        public List<string> Elements;

        public Meteor(Vector2 position, int typeMeteor)
        {
            this.Position = position;
            this.Velocity = new Vector2(0, 1);
            switch (typeMeteor)
            {
                case 1:
                    this.Elements = new List<string>
            {
                " __  ",
                "|o  \\",
                "|___/"
            }; break;
                case 2:
                    this.Elements = new List<string>
            {
                " ___ ",
                "|  o|",
                "|__/ "
            }; break;
                case 3:
                    this.Elements = new List<string>
            {
                " ___ ",
                "|   |",
                " \\_o|"
            }; break;
                case 4:
                    this.Elements = new List<string>
            {
                "  __ ",
                " /  |",
                "|o__|"
            }; break;
            }
        }

        public void Draw()
        {
            try
            {
                switch (MeteorFrenzy.countOfMeteors%4+1)
                {
                    case 1:
                        this.Elements = new List<string>
            {
                " __  ",
                "|o  \\",
                "|___/"
            }; break;
                    case 2:
                        this.Elements = new List<string>
            {
                " ___ ",
                "|  o|",
                "|__/ "
            }; break;
                    case 3:
                        this.Elements = new List<string>
            {
                " ___ ",
                "|   |",
                " \\_o|"
            }; break;
                    case 4:
                        this.Elements = new List<string>
            {
                "  __ ",
                " /  |",
                "|o__|"
            }; break;
                }
                for (int i = 0; i < this.Elements.Count; i++)
                {
                    Console.SetCursorPosition(this.Position.X, this.Position.Y + i);
                    Console.Write(this.Elements[i]);
                }
            }
            catch { }
        }

        public void Delete()
        {
            try
            {
                for (int i = 0; i < this.Elements.Count; i++)
                {
                    Console.SetCursorPosition(this.Position.X, this.Position.Y + i);
                    Console.Write("     ");
                }
            }
            catch { }
        }

        public void MoveMeteor()
        {
            this.Position.Add(this.Velocity);
        }
    }
}
