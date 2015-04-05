using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter.Node
{
    public class NodeManager
    {
        public RootNode parent;
        private Stack<Matrix> _matricies = new Stack<Matrix>();
        private Camera _activeCamera = new Camera();

        public Camera ActiveCamera { get { return _activeCamera; } set { _activeCamera = value; } }

        public NodeManager()
        {
            parent = new RootNode(false,this);
        }

        public void update()
        {
            nodeUpdateWalk(parent);
        }

        public void draw()
        {
            nodeDrawWalk(parent);
        }

        private void nodeUpdateWalk(Node n)
        {
            foreach (Node node in n.getChildren())
            {
                if (node.nodeAlive)
                {
                    node.update();
                    nodeUpdateWalk(node);
                }
                else
                {
                    //removes the dead child node
                    n.removeChild(node);
                }
            }
        }

        private void nodeDrawWalk(Node n)
        {
            foreach (Node node in n.getChildren())
            {
                if (_matricies.Count == 0)
                    _matricies.Push(node.transform);
                else
                    _matricies.Push(_matricies.Peek() * node.transform);

                node.draw(_matricies.Peek());
                nodeDrawWalk(node);
                
                if (_matricies.Count > 0)
                    _matricies.Pop();


            }
        }

    }
}
