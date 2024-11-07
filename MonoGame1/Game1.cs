
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame1.Content;

namespace MonoGame1;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    ScaledSprite sprite;
    

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        // TODO: use this.Content to load your game content here
        Texture2D texture = Content.Load<Texture2D>("player");
        sprite = new ScaledSprite(texture, Vector2.Zero);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        
        if(Keyboard.GetState().IsKeyDown(Keys.W))
        {
            sprite.position.Y -= 5;
        }
        if(Keyboard.GetState().IsKeyDown(Keys.S))
        {
            sprite.position.Y += 5;
        }
        if(Keyboard.GetState().IsKeyDown(Keys.A))
        {
            sprite.position.X -= 5;
        }
        if(Keyboard.GetState().IsKeyDown(Keys.D))
        {
            sprite.position.X += 5;
        }
        

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        _spriteBatch.Draw(sprite.texture, sprite.Rect, Color.White);
        _spriteBatch.End();
        
        base.Draw(gameTime);
    }
}