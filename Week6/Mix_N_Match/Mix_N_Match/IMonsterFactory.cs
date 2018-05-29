using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_N_Match
{
    public interface IMonsterFactory
    {
        Monster CreateMonster(string monsterCode);
    }
}
