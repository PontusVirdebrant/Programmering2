using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    class BaseBullet:BaseObject
    {
        protected float speed =10;
        protected Vector2 direction;
        protected int Score = 0;

        public BaseBullet(Vector2 pos, Vector2 dir)
        {
            position = pos;
            direction = dir;
            texture = Assets.StandardTexture;
            color = Color.Black;
        }
        public override void Update()
        {
            position += direction * speed;
            if (position.X > 900 || position.X < -100 || position.Y < -100 | position.Y > 500)
                Remove = true;
        }

        public override void OnCollision(BaseObject col)
        {
            if(col is BaseEnemy)
            {
                Remove = true;
                Score += 100;
                Debug.WriteLine(Score);
            }
        }
    }
}
