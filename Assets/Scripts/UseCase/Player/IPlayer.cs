namespace UseCase.Player
{
    public interface IPlayer
    {
        ulong PlayerID { get; }

        void SetPlayerID(ulong playerID);
    }
}
