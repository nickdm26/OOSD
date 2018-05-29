using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_N_Match
{
    public class MonsterFactory : IMonsterFactory
    {
        public Monster CreateMonster(string monsterCode)
        {
            Monster newMonster = null;
            switch(monsterCode)
            {
                case "Fairy":
                    newMonster = new Fairy();
                    break;
                case "Frankenstein":
                    newMonster = new Frankenstein();
                    break;
                case "Skeleton":
                    newMonster = new Skeleton();
                    break;
                case "Vampire":
                    newMonster = new Vampire();
                    break;
                case "Werewolf":
                    newMonster = new Werewolf();
                    break;
                case "Witch":
                    newMonster = new Witch();
                    break;
            }
            newMonster.SetBitmaps();
            return newMonster;
        }
    }
}
