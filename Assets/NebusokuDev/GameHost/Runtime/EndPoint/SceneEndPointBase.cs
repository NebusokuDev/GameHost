using NebusokuDev.GameHost.Runtime.Host;
using UnityEngine;

namespace NebusokuDev.GameHost.Runtime.EndPoint
{
    public abstract class SceneEndPointBase : MonoBehaviour
    {
        private IGlobalGameHost _sceneGlobalGameHost;

        protected virtual void Awake()
        {
            _sceneGlobalGameHost = CreateSceneGameHost();

            _sceneGlobalGameHost.Run();
        }

        public abstract IGlobalGameHost CreateSceneGameHost();
    }
}