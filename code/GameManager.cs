using Sandbox;

namespace RustSolo
{
    public partial class GameManager : Sandbox.GameManager
    {
        public override void ClientJoined( IClient client )
        {
            base.ClientJoined( client );
            var player = new PlayerController();
            client.Pawn = player;
            player.Respawn();
        }
    }
}
