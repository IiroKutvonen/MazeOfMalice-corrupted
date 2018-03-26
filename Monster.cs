using System;
using System.Collections.Generic;
using System.Text;

namespace MazeOfMalice
{
    class Monster : Character
    {
        int _treasureClass;
        int _challengeRating;

        public Monster(string Name, int Str, int Dex, int Con, int HitPoint, int ArmourClass, int AttackBonus, int TreasureClass, int ChallengeRating) : base(Name, Str, Dex, Con, HitPoint, ArmourClass, AttackBonus)
        {
            _treasureClass = TreasureClass;
            _challengeRating = ChallengeRating;
        }
      

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
