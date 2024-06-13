﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    internal class Enemy : Entity
    {
        public Enemy(string name) : base(name)
        {

        }
    }
    internal class Skeleton : Enemy
    {
        public Skeleton() : base("Skeleton")
        {
            hp = 5;
            strength = 6;
        }
    }
}
