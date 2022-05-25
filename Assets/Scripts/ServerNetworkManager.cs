using Mirror;
using UnityEngine;

namespace Sygon.Scripts
{
    [AddComponentMenu("")]
    public class ServerNetworkManager : NetworkManager
    {
        public override void OnServerAddPlayer(NetworkConnectionToClient conn)
        {
            
        }

        public override void OnServerDisconnect(NetworkConnectionToClient conn)
        {
           
        }
    }
}

