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
        private Texture2D _texture;

        public ModelNode(string model,bool singleParent):base(singleParent)
        {
            _modelDirector = model;
        }

        public override void load(ContentManager content)
        {
            _model = content.Load<Model>("Ship");
            _texture = content.Load<Texture2D>("ShipTexture");
            base.load(content);
        }

        public override void draw(Matrix transform)
        {
          //  Engine.instance.SpriteBatch.Begin();
          
            foreach(ModelMesh mesh in _model.Meshes)
            {
                foreach(BasicEffect effect in mesh.Effects)
                {

                    //effect.EnableDefaultLighting();
                    effect.Texture = _texture;
                    effect.TextureEnabled = true;

                    effect.World = transform;
                    effect.View = _nodeManager.ActiveCamera.view;
                    effect.Projection = _nodeManager.ActiveCamera.projection;
                }
           
                mesh.Draw();
              
            }
            //Engine.instance.SpriteBatch.Draw(_texture, new Rectangle(0, 0, 100, 100), Color.White);
           // Engine.instance.SpriteBatch.End();
        }

    }
}
