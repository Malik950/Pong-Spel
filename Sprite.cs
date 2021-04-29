﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Sprite
    {
        protected Texture2D texture;
        protected Vector2 position;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        protected Vector2 direction;
        
        public Vector2 Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        protected float speed;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Score { get; set; }

        protected Rectangle screen;

        public Rectangle spriteBox { get { return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height); } }

        public Sprite(Texture2D texture, Vector2 position, Vector2 direction, Rectangle screen)
        {
            this.texture = texture;
            this.position = position;
            this.direction = direction;
            this.screen = screen;
        }

        public Sprite(Texture2D texture, Vector2 position, Vector2 direction, float speed, Rectangle screen)
        {
            this.texture = texture;
            this.position = position;
            this.direction = direction;
            this.speed = speed;
            this.screen = screen;
        }

        public virtual void Update(GameTime gameTime)
        {
            position += direction * speed;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
