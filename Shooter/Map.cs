
using BEPUphysics;
using BEPUphysics.BroadPhaseEntries;
using Shooter.Node;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter
{
    public class Map
    {
        private ModelNode _modelNode;
        private Space _space;
        float x = 0;
        private Camera _camera = new Camera(45);

        public Map(string node,NodeManager nodeManager,Space space,ContentManager content)
        {
            _modelNode = new ModelNode(node,false);
            nodeManager.parent.addChild(_modelNode, content);
            nodeManager.parent.addChild(_camera, content);
            nodeManager.ActiveCamera = _camera;

            Matrix lout = new Matrix();
            Matrix.CreateTranslation(0, 0, -10, out  lout);
            _camera.transform = lout;


            lout = new Matrix();
            Matrix.CreateTranslation(1, 0, 0, out  lout);
            _modelNode.transform = lout;


            _space = space;
        }

        public void update()
        {
            //x+= 0.1f;
           //_modelNode.transform =  Matrix.CreateRotationX(x);
        }


    }
}
