using HeartStoneBattlegrounds.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartStoneBattlegrounds.Classes
{
    class Minion: Card
    {
        public int ActualHealth { get; set; }
        public void DoeAttack(Minion target)
        {
            target.ActualHealth -= Attack;
            ActualHealth -= target.Attack;
        }
    }
}
