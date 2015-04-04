using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DualStick.Node
{
    public class NodeManager
    {
        public Node parent = new Node();
        private Stack<Matrix> _matricies = new Stack<Matrix>();
        private Camera _activeCamera;

        public NodeManager()
        {

        }

        public void update()
        {
            nodeWalk(parent);
        }

        private void nodeWalk(Node n)
        {
            foreach (Node node in n.getChildren())
            {
                _matricies.Push(_matricies.Peek() * node.transform);
                nodeWalk(node);
                node.draw(_matricies.Peek());
                
                _matricies.Pop();
            }
        }

    }
}
