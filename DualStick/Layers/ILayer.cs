using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DualStick
{
    public interface ILayer
    {
         string layerId();
         void load(ContentManager content);
         void update(LayerManager layerManager);
         void draw();
    }
}
