using Domain.Entities.GameResult;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    public interface IGameResultAppService
    {
        void Create(GameResult gameResult);

        IEnumerable<GameResult> GetByGameId(string gameId);
    }
}
