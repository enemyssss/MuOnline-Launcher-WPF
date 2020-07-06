using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuOnline_Launcher_WPF.Classes
{
    class Guild
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Members { get; private set; }
        public int Score { get; private set; }

        public Guild(int id, string name, int members, int score)
        {
            Id = id;
            Name = name;
            Members = members;
            Score = score;
        }
    }
}
