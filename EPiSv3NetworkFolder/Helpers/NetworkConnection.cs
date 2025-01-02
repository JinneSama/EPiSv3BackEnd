using System.Net;

namespace EPiSv3NetworkFolder.Helpers
{
    public class NetworkConnection : IDisposable
    {
        private readonly string _networkName;

        public NetworkConnection(string networkName, NetworkCredential credentials)
        {
            _networkName = networkName;

            var netResource = new NativeMethods.NetResource
            {
                Scope = 2,
                ResourceType = 1,
                DisplayType = 3,
                Usage = 1,
                RemoteName = networkName
            };

            var result = NativeMethods.WNetAddConnection2(netResource, credentials.Password, credentials.UserName, 0);

            if (result != 0)
            {
                throw new InvalidOperationException($"Error connecting to network folder: {result}");
            }
        }

        public void Dispose()
        {
            NativeMethods.WNetCancelConnection2(_networkName, 0, true);
        }
    }
}
