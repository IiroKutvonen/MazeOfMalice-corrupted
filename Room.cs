using System;
using System.Collections.Generic;
using System.Text;

namespace MazeOfMalice
{
    class Room
    {
        string _description;
        List<Monster> Bestiary = new List<Monster>();

        public Room(string description)
        {
            _description = description;
            Bestiary = new List<Monster>();
            CreateMonsters(3);
        }

        private void CreateMonsters(int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                Bestiary.Add(new Monster("Goblin" + i, rnd.Next(0, 21), 14, 12, 10, 10, 2, 1, 0));
            }
        }

        private string RoomMonsters()
        {
            string retValue="";
            foreach (var M in Bestiary)
            {
                retValue += M.ToString();
            }
            return retValue;
        }

        public override string ToString()
        {
            return $"Nimi: {_description}\n" +
                $"Monsterit : {RoomMonsters()}";
        }
    }
}
