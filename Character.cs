using System;
using System.Collections.Generic;
using System.Text;

namespace MazeOfMalice
{
    class Character
    {
        protected string _name;
        protected int _str;
        protected int _dex;
        protected int _con;
        protected int _hitPoint;
        protected int _armourClass;
        protected int _attackBonus;
        int[] AttributeBonusTable = new int[21] { -5, -5, -4, -4, -3, -3, -2, -2, -1, -1, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5};

        public Character(string Name, int Str, int Dex, int Con, int HitPoint, int ArmourClass, int AttackBonus)
        {
            _name = Name;
            _str = Str;
            _dex = Dex;
            _con = Con;
            _hitPoint = HitPoint;
            _armourClass = ArmourClass;
            _attackBonus = AttackBonus;
            int strbonus = AttributeBonusTable[_str];
        }

        public override string ToString()
        {
            return $"{_name} - {_str}";
        }

    }
}
