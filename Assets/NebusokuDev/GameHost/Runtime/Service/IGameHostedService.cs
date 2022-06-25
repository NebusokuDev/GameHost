using System;

namespace NebusokuDev.GameHost.Runtime.Service
{
    public interface IGameHostedService : IDisposable
    {
        void Start();

        void Stop();
    }
}