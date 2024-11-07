using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame1.Content;

internal class ScaledSprite : Sprite
{
    public Rectangle Rect
    {
        get
        {
            return new Rectangle((int)position.X, (int)position.Y, (int)(texture.Width * 5), (int)(texture.Height * 5));
        }
    }
    
    public ScaledSprite(Texture2D texture, Vector2 position): base(texture, position)
    {
    }
    
    
}