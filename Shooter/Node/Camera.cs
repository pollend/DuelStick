using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter.Node
{
    public class Camera : Node
    {
        private Matrix _projection = Matrix.Identity;
        private Matrix _view = Matrix.Identity;

        public Matrix projection { get { return _projection; } set { _projection = value; } }
        public Matrix view { get { return _view; } set { _view = value; } }

        public Camera(Matrix m)
            : base(true)
        {
            _projection = m;
        }

        public Camera()
            : base(true)
        {
            _projection = Matrix.CreateOrthographic(Engine.instance.GraphicsDeviceManager.PreferredBackBufferWidth, Engine.instance.GraphicsDeviceManager.PreferredBackBufferHeight, .01f, 100f);
        }

        public Camera(float angle)
            : base(true)
        {
            _projection = Matrix.CreatePerspectiveFieldOfView(Engine.instance.GraphicsDeviceManager.PreferredBackBufferWidth / Engine.instance.GraphicsDeviceManager.PreferredBackBufferHeight, MathHelper.ToRadians(angle), 0.01f, 100f);
        }

        //update the transform view matrix every loop
        public override void draw(Matrix transform)
        {
            _view = transform;
        }

    }
}
