using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DualStick
{
    public class Map
    {
        Model _mesh;
        public Map()
        {
        }

        public void load(ContentManager content, Model scene)
        {
        }

        public void draw(Matrix view, Matrix projection)
        {
            foreach (ModelMesh mesh in _mesh.Meshes)
            {
              
                foreach (BasicEffect effect in mesh.Effects)
                {
                   // effect.World = world;
                   // effect.View = view;
                    //effect.Projection = projection;
                }
                mesh.Draw();
            }
            
        }


    }
}
