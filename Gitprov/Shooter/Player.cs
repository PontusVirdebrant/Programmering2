using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shooter
{
    class Player: BaseObject
    {
        float speed = 5f;
        Vector2 velocity = Vector2.Zero;
        KeyboardState keybord;
        float shootTime = 20;
        float timer = 60;
        int Health = 5;

        public Player()
        {
            position = new Vector2(100,200);
            texture = Assets.Player;
        }

        public override void Update()
        {
            keybord = Keyboard.GetState();
            velocity = Vector2.Zero;
            Movement();
            if(Mouse.GetState().LeftButton == ButtonState.Pressed && timer >=shootTime)
            {
                Shoot();
                timer = 0;
            }
            timer++;
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        private void Movement()
        {
            if (keybord.IsKeyDown(Keys.W) && position.Y > 0)
            {
                velocity.Y -= 1;
            }
            if (keybord.IsKeyDown(Keys.S) && position.Y < 600)
            {
                velocity.Y += 1;
            }
            if (keybord.IsKeyDown(Keys.D) && position.X < 800)
            {
                velocity.X += 1;
            }
            if (keybord.IsKeyDown(Keys.A) && position.X > 0)
            {
                velocity.X -= 1;
            }
            if(velocity != Vector2.Zero)
                velocity.Normalize();
            position += velocity *speed;
        }
        public override void OnCollision(BaseObject col)
        {
            if (col is BaseEnemy)
            {
                Health--;
                if (Health <= 0)
                {

                    Remove = true;
                    Debug.WriteLine("Spelaren förlorade");
                }
                else
                {
                    Debug.WriteLine("Spelaren har " + Health + " HP kvar");
                }
            }
        }

        private void Shoot()
        {
            Vector2 direction = Mouse.GetState().Position.ToVector2() - position;
            direction.Normalize();
            ObjectManager.AddObject(new BaseBullet(position, direction));
        }

    }
}
