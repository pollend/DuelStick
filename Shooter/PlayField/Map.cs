
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
using Shooter.Node.ModelNodes;

namespace Shooter.PlayField
{
    public class Map
    {
        private ModelNode _modelNode;
        private Space _space;
        private Camera _camera = new Camera(45);

        public Map(string node,NodeManager nodeManager,Space space,ContentManager content)
        {
            _modelNode = new ModelNode(content,"sphere","shader",false);
            nodeManager.parent.addChild(_modelNode, content);
            nodeManager.parent.addChild(_camera, content);
            nodeManager.ActiveCamera = _camera;

            Matrix lout = new Matrix();
            Matrix.CreateTranslation(0, 0, -5, out  lout);
            _camera.transform = lout;


            foreach (ModelMesh mesh in _modelNode.meshes)
            {
                foreach (Effect effect in mesh.Effects)
                {
                    effect.CurrentTechnique = effect.Techniques["Technique1"];

                    effect.Parameters["AmbientColor"].SetValue(new Vector4(1, 1, 1, 1));
                    effect.Parameters["AmbientIntensity"].SetValue(.2f);

                    effect.Parameters["DiffuseDirection"].SetValue(new Vector3(1, 1, 1));
                    effect.Parameters["DiffuseColor"].SetValue(new Vector4(1, 1, 1, 1));
                    effect.Parameters["DiffuseIntensity"].SetValue(1.0f);

                }
            }


            _space = space;
        }

        public void update()
        {
        }


    }
}
