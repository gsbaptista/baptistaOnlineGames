using Domain.Entities.GameResult;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Service
{
    interface IGameResultService : IDisposable
    {
        void Create(GameResult gameResult);

        IEnumerable<GameResult> GetByGameId(string gameId);
    }
}
