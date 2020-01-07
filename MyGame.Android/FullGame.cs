using Azuxiren.MG;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MyGame.Android
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
            block = new Block(tex, new Rectangle(0, 0, 40, 40), () => Global.ThisGame.Sb)
            {
                v = new Vector2(2, 2)
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
    public class LoadScreen : IScreen
    {
        public void Draw(GameTime gt)
        {
            Global.ThisGame.GraphicsDevice.Clear(Color.Green);
        }

        public void LoadContent()
        {
        }

        public void Update(GameTime gt) { }
    }
    public static class Global
    {
        public static GameClass ThisGame;
    }
    public class GameClass : AMGC<StartScreen, LoadScreen>
    {
        internal SpriteBatch Sb;
        public GameClass():base()
        {
            Global.ThisGame = this;
        }
        protected override void Initialize()
        {
            base.Initialize();
            Sb = new SpriteBatch(GraphicsDevice);
        }
        protected override void Draw(GameTime gt)
        {
            Sb.Begin();
            base.Draw(gt);
            Sb.End();
        }
    }
}