using NebusokuDev.GameHost.Runtime.Host;
using UnityEngine;

namespace NebusokuDev.GameHost.Runtime.EndPoint
{
    [CreateAssetMenu(fileName = "GlobalEndpoint")]
    public class MockEndPoint : GlobalEndPointBase
    {
        public override IGlobalGameHost CreateGlobalGameHost() => Host.GameHost.CreateDefaultGameHost(null);
    }
}