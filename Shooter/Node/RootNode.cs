using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter.Node
{
   public class RootNode: Node
    {
       public RootNode(bool singleParent,NodeManager nodeManager) : base(singleParent)
       {
           _nodeManager = nodeManager;
       }
    }
}
