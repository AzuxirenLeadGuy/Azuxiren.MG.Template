using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Azuxiren.MG;
namespace MyGame.Windows
{
    public class GameClass:AMGC<StartScreen,LoadScreen>
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