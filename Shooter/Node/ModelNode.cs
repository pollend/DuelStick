using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Shooter.Node
{
    public class ModelNode : Node
    {
        private Model _model;
        private string _modelDirector;
        public ModelNode(string model,bool singleParent):base(singleParent)
        {
            _modelDirector = model;
        }

        public override void load(ContentManager content)
        {
            _model = content.Load<Model>(_modelDirector); 
            base.load(content);
        }

        public override void draw(Matrix transform)
        {
          
            foreach(ModelMesh mesh in _model.Meshes)
            {
                foreach(BasicEffect effect in mesh.Effects)
                {
                    effect.World = transform;
                    effect.View = _nodeManager.ActiveCamera.view;
                    effect.Projection = _nodeManager.ActiveCamera.projection;
                }
                mesh.Draw();
            }
        }

    }
}
