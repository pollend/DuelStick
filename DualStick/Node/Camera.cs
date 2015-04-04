using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DualStick.Node
{
    public class Camera : Node
    {
        private Matrix _view = Matrix.Identity;
        private float _angle = 0;

        public Matrix View { get { return _view; } set { _view = value; } }

        public Camera(Matrix m)
        {
            _view = m;
        }

        public Camera()
        {
            _view = Matrix.CreateOrthographic(Engine.instance.Graphics.PreferredBackBufferWidth, Engine.instance.Graphics.PreferredBackBufferHeight, .01f, 100f);
        }

        public Camera(float angle)
        {
            _view = Matrix.CreatePerspectiveFieldOfView(Engine.instance.Graphics.PreferredBackBufferWidth / Engine.instance.Graphics.PreferredBackBufferHeight, MathHelper.ToRadians(angle), 0.01f, 100f);
        }


    }
}
