using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter.Node
{
    public class Node
    {
        protected Matrix _transform = Matrix.Identity;
        protected HashSet<Node> _children = new HashSet<Node>();
        protected NodeManager _nodeManager;
        protected bool _nodeAlive = true;
        protected bool _singleParent = false;


        public bool nodeAlive { get { return _nodeAlive; } set { _nodeAlive = value; } }
        public Matrix transform { get { return _transform; } set { _transform = value; } }

        public HashSet<Node> children { get { return _children; } }

        private List<Node> _parents = new List<Node>();

        public Node(bool singleParent)
        {
            _singleParent = singleParent;
        }

        protected void addParent(Node parent)
        {
            if(_singleParent)
            {
                for(int x = 0; x < _parents.Count; x++)
                {
                    this.removeChild(_parents[x]);
                }
                _parents.Clear();
            }
            _parents.Add(parent);
        }

        public void addChild(Node node,ContentManager content)
        {
            node._nodeManager = _nodeManager;


            //adds this node as a parent
            node.addParent(this);
            _children.Add(node);
            
        }

        public bool removeChild(Node node)
        {
            return _children.Remove(node);
        }

    
        public virtual void draw(Matrix transform)
        {

        }

        public virtual void update()
        {

        }


    }
}
