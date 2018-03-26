using System;
using System.Collections.Generic;
using System.Text;

namespace MazeOfMalice
{
    class Hero : Character
    {
        int _characterLevel;
        

        public Hero(string Name, int Str, int Dex, int Con, int HitPoint, int ArmourClass, int AttackBonus, int CharacterLevel) : base(Name, Str, Dex, Con, HitPoint, ArmourClass, AttackBonus)
        {
            _characterLevel = CharacterLevel;
            
        }


    }
}
