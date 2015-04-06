
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
using BEPUphysics.DataStructures;

namespace Shooter.MapArea
{
    public class Map
    {
        private ModelNode _modelNode;
        private Space _space;
        private Camera _camera = new Camera(45);

        public Map(string node,NodeManager nodeManager,ContentManager content)
        {
            _space = new Space();

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
                
                foreach(ModelMeshPart part  in mesh.MeshParts)
                {
                 
                    VertexPositionNormalTexture[] vertices = new VertexPositionNormalTexture[part.VertexBuffer.VertexCount];
                    part.VertexBuffer.GetData<VertexPositionNormalTexture>(vertices);

                    ushort[] drawOrder = new ushort[part.IndexBuffer.IndexCount];
                    part.IndexBuffer.GetData<ushort>(drawOrder);

                    BEPUutilities.Vector3[] lverts = new BEPUutilities.Vector3[part.NumVertices];
                    for(int x = 0; x < lverts.Length;x++)
                    {
                        lverts[x] = new BEPUutilities.Vector3(vertices[x].Position.X,vertices[x].Position.Y,vertices[x].Position.Z);
                    }

                    int[] lindex = new int[part.IndexBuffer.IndexCount];
                    for(int x = 0; x < lindex.Length; x++)
                    {
                        lindex[x] = drawOrder[x];
                    }


                   _space.Add(new StaticMesh(lverts, lindex));
                   
                }
            }


    
          
        }

        public void update()
        {
        }


    }
}
