using Azuxiren.MG;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MyGame.Windows
{
    public struct StartScreen : IScreen
    {
        Block block;
        public void Draw(GameTime gt)
        {
            Global.ThisGame.GraphicsDevice.Clear(Color.Aquamarine);
            block.Draw(gt);
        }

        public void LoadContent()
        {
            var tex = new Texture2D(Global.ThisGame.GraphicsDevice, 1, 1);
            tex.SetData<Color>(new Color[] { Color.White });
            block = new Block(tex, new Microsoft.Xna.Framework.Rectangle(0, 0, 40, 40), () => Global.ThisGame.Sb)
            {
                v = new Vector2(5f, 5f)
            };
        }

        public void Update(GameTime gt)
        {
            block.Update(gt);
            if (block.x.X < 0 || block.x.X + 40 > Global.ThisGame.Window.ClientBounds.Width)
                block.v.X *= -1;
            if (block.x.Y < 0 || block.x.Y + 40 > Global.ThisGame.Window.ClientBounds.Height)
                block.v.Y *= -1;
        }
    }
}