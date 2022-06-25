using UnityEngine;

namespace NebusokuDev.GameHost.Runtime.Host
{
    public class GameHost
    {
        public static IGlobalGameHost CreateDefaultGameHost(string[] args) => new MockGlobalGameHost();
    }

    public class MockGlobalGameHost : IGlobalGameHost
    {
        public void Dispose() => Debug.Log("Disposed...");

        public void Run() => Debug.Log("Now Running!");
    }
}