using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter
{
    public class Engine
    {
        private static Engine _engine = null;
        private SpriteBatch _spriteBatch;
        private GraphicsDevice _graphicsDevice;
        private GraphicsDeviceManager _graphicsDeviceManager;

        public GraphicsDevice GraphicsDevice
        {
            get { return _graphicsDevice; }
            set { _graphicsDevice = value; }
        }

        public GraphicsDeviceManager GraphicsDeviceManager
        {
            get { return _graphicsDeviceManager; }
            set { _graphicsDeviceManager = value; }
        }

        public SpriteBatch SpriteBatch
        {
            get { return _spriteBatch; }
            set { _spriteBatch = value; }
        }

        private Engine(){
        
        }

        public static Engine instance{
            get
            {
                if (_engine == null)
                {
                    _engine = new Engine();
                }
                return _engine;
            }
        }
    }
}
