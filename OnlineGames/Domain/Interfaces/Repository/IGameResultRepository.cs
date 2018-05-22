using Domain.Entities.GameResult;

namespace Domain.Interfaces.Repository
{
    interface IGameResultRepository
    {
        GameResult Get(string playerId, string gameId);

        void Create(GameResult gameResult);
    }
}
