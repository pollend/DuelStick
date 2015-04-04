using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DualStick
{
    public class Engine
    {
        private static Engine _engine = null;
        private GraphicsDeviceManager _graphics;

        public GraphicsDeviceManager Graphics
        {
            get { return _graphics; }
            set { _graphics = value; }
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
