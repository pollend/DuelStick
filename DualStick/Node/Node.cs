using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DualStick.Node
{
    public class Node
    {
        protected Matrix _transform = Matrix.Identity;
        protected LinkedList<Node> _children = new LinkedList<Node>();
        protected NodeManager _nodeManager;


        public Matrix transform { get { return _transform; } set { _transform = value; } }

        public virtual void load(ContentManager content)
        {

        }

        public void addChild(Node node)
        {
            node._nodeManager = _nodeManager;
            _children.AddLast(node);
        }

        public bool removeChild(Node node)
        {
            return _children.Remove(node);
        }

        public LinkedList<Node> getChildren()
        {
            return _children;
        }

        public abstract void draw(Matrix transform)
        {

        }


    }
}
