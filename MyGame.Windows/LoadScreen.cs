using Microsoft.Xna.Framework;
using Azuxiren.MG;
namespace MyGame.Windows
{
    public class LoadScreen : IScreen
    {
        public void Draw(GameTime gt)
        {
            Global.ThisGame.GraphicsDevice.Clear(Color.Green);
        }

        public void LoadContent()
        {
        }

        public void Update(GameTime gt){}
    }
}