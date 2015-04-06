using BEPUphysics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter.MapArea
{
    public class MapStickNode : Node.Node
    {
        Node.Node _attachedNode;
        Space _space;
        public MapStickNode( Node.Node attachedNode,ContentManager content,Space space) 
            : base(true)
        {
            _attachedNode = attachedNode;
            this.addChild(attachedNode, content);

            _space = space;

        }

        public override void update()
        {
            base.update();
        }

        public override void draw(Microsoft.Xna.Framework.Matrix transform)
        {
            base.draw(transform);
        }

    }
}
