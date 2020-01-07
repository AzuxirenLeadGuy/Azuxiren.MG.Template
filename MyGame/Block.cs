using System;
using Microsoft.Xna.Framework.Graphics;
using Azuxiren.MG;
using Microsoft.Xna.Framework;
namespace MyGame
{
    public class Block : PhyObj2D
    {
        readonly Texture2D tex;
        Rectangle rectangle;
        readonly Func<SpriteBatch> GetSpriteBatch;
        public Block(Texture2D t, Rectangle r, Func<SpriteBatch> sb):base(0)
        {
            tex = t;
            rectangle = r;
            GetSpriteBatch = sb;
        }
        public override void Update(GameTime gt)
        {
            rectangle.X = (int)x.X;
            rectangle.Y = (int)x.Y;
            base.Update(gt);
        }
        public override void Draw(GameTime gt)
        {
            var sb = GetSpriteBatch();
            sb.Draw(tex, rectangle, Color.White);
        }
    }
}