using BEPUphysics;
using Shooter.Node;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter.Layers
{
    public class PlayField : ILayer
    {
        private Space _space;
        private Map _map;
        private NodeManager _nodeManager;

        public string layerId()
        {
            return "playfield";
        }

        public PlayField()
        {
            _nodeManager = new NodeManager();
        }
        
        public void load(ContentManager content)
        {
            _space = new Space();
            _map = new Map("sphere", _nodeManager, _space,content);
        }

        public void update(LayerManager layerManager)
        {
            _nodeManager.update(); 
        }

        public void draw()
        {
            _nodeManager.draw();
        }
    }
}
