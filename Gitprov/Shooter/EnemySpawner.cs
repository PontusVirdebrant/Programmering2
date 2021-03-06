﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    class EnemySpawner
    {
        Random rand = new Random();
        public void Update()
        {
            int chance = rand.Next(0, 1000);
            Vector2 pos = new Vector2(rand.Next(-100,0),rand.Next(-100,0));
            if(chance <= 10)
            {
                ObjectManager.AddObject(new EnemyFollowPlayer(pos, ObjectManager.FindObject<Player>()));
            }

        }
    }
}
