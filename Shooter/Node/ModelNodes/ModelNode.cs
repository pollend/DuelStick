using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Shooter.Node.ModelNodes
{
    public class ModelNode : Node
    {
        private Model _model;

        public ModelMeshCollection meshes { get { return _model.Meshes; } }

        public string worldParameter { get; set; }
        public string viewParameter { get; set; }
        public string projectionParameter { get; set; }

        public ModelNode(ContentManager content, string assetModel, string assetEffect, bool singleParent)
            : base(singleParent)
        {
            worldParameter = "World";
            viewParameter = "View";
            projectionParameter = "Projection";
           

            _model = content.Load<Model>(assetModel);
            Effect effect = content.Load<Effect>(assetEffect);

            foreach (ModelMesh mesh in _model.Meshes)
            {
                foreach (ModelMeshPart part in mesh.MeshParts)
                {
                    part.Effect = effect;
                }
            }
        }


        public override void draw(Matrix transform)
        {
          
            foreach(ModelMesh mesh in _model.Meshes)
            {

                foreach (Effect effect in mesh.Effects)
                {
                    effect.Parameters[worldParameter].SetValue(transform);
                    effect.Parameters[viewParameter].SetValue(_nodeManager.ActiveCamera.view);
                    effect.Parameters[projectionParameter].SetValue(_nodeManager.ActiveCamera.projection);

                }
           
                mesh.Draw();
              
            }

        }

    }
}
