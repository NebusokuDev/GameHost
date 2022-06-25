using NebusokuDev.GameHost.Runtime.Host;
using UnityEngine;

namespace NebusokuDev.GameHost.Runtime.EndPoint
{
    public class GlobalEndPointProxy
    {
        private static GlobalEndPointBase _globalEndPoint;
        private static IGlobalGameHost _globalGlobalGameHost;

        [RuntimeInitializeOnLoadMethod]
        private static void OnLoad()
        {
            _globalEndPoint = Resources.Load<GlobalEndPointBase>("GlobalEndpoint");

            if (_globalEndPoint == null) return;

            _globalEndPoint.Start();
        }
    }
}