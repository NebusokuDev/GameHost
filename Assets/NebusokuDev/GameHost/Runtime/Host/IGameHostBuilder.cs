namespace NebusokuDev.GameHost.Runtime.Host
{
    public interface IGameHostBuilder
    {
        IGlobalGameHost Build(string[] args);
    }
}