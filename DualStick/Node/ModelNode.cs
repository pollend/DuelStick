using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace DualStick.Node
{
    public class ModelNode : Node
    {
        private Model _model;
        public override void load(ContentManager content,String model)
        {
            _model = content.Load<Model>(model); 
            base.load(content);
        }

       

        public override void draw(Matrix transform)
        {
           
        }

    }
}
