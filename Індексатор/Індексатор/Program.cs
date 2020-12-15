using System;
namespace Індексатор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Team person = new Team();
            person[10] = new Player { Name = "Andrey", Number = 77 };
            if (person[10] == null)
            {
                Console.WriteLine($"Некоректно введені дані ");
            }
            else
            {
                person[10].GetPlayer();
            }

        }
    }
    class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public void GetPlayer()
        {
            Console.WriteLine($"{Name} - {Number}");
        }
    }
    class Team
    {
        Player[] players = new Player[11];
        public Player this[int index]
        {
            get
            {
                if (index >= 0 && index < players.Length)
                {
                    return players[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < players.Length)
                {
                    players[index] = value;
                }
            }
        }
    }
}

