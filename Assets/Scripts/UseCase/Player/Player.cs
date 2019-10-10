using Game.Player;

namespace UseCase.Player
{
    public class Player : IPlayer
    {
        private PlayerData playerData;

        public Player(PlayerData playerData)
        {
            this.playerData = playerData;
        }

        public ulong PlayerID
        {
            get
            {
                return playerData.PlayerID;
            }
        }

        public void SetPlayerID(ulong playerID)
        {
            playerData.PlayerID = playerID;
        }
    }
}
