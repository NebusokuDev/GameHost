using NebusokuDev.GameHost.Runtime.Host;
using UnityEngine;

namespace NebusokuDev.GameHost.Runtime.EndPoint
{
    public abstract class GlobalEndPointBase : ScriptableObject
    {
        private IGlobalGameHost _globalGlobalGameHost;

        public virtual void Start()
        {
            _globalGlobalGameHost = CreateGlobalGameHost();
            _globalGlobalGameHost.Run();
        }

        public abstract IGlobalGameHost CreateGlobalGameHost();
    }
}