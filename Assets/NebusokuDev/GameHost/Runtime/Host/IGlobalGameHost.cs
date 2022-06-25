using System;

namespace NebusokuDev.GameHost.Runtime.Host
{
    public interface IGlobalGameHost : IDisposable
    {
        void Run();
    }
}