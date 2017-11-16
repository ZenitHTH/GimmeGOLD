using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace GULNW
{
    class tile
    {
        private Texture2D _texture;
        public Vector2 position;
        public float speed = 2f;
        public Boolean _hit;
        public tile(Texture2D texture)
        {
            _texture = texture;


        }
        
        public void Hitcheck()
        {
            if (position.Y < 40) { _hit = true; }
        }
        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Hitcheck();
                if (_hit)
                {
                    _hit = false;
                    position.Y += speed;
                }
                else
                position.Y -= speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Hitcheck();
                if (_hit)
                {
                    _hit = false;
                    position.Y += speed;
                }
                else
                    position.Y += speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                Hitcheck();
                if (_hit)
                {
                    _hit = false;
                }
                else
                    position.X -= speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Hitcheck();
                if (_hit)
                {
                    _hit = false;
                }
                else
                    position.X += speed;
            }
        }
        public void randomtile()
        {
                
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, position, Color.White);

        }

        public void tileDraw(SpriteBatch spriteBatch,Vector2 pos)
        {
            for (int i = 0; i <= 800; i++)
            {
                position = new Vector2(i * 40, 0);
                spriteBatch.Draw(_texture, position, Color.White);
            }
            for (int i = 0; i <= 800; i++)
            {
                position = new Vector2(0, i * 40);
                spriteBatch.Draw(_texture, position, Color.White);
            }
            for (int i = 0; i <= 800; i++)
            {
                position = new Vector2(760, i * 40);
                spriteBatch.Draw(_texture, position, Color.White);
            }
            for (int i = 0; i <= 800; i++)
            {
                position = new Vector2(i * 40, 440);
                spriteBatch.Draw(_texture, position, Color.White);
            }
        }
      

        }

    }
