﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuOnline_Launcher_WPF.Classes
{
    class Character
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Resets { get; private set; }
        public int GR { get; private set; }

        public Character(int id, string name, int level, int resets, int gr)
        {
            Id = id;
            Name = name;
            Level = level;
            Resets = resets;
            GR = gr;
        }
    }
}
