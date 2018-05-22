using Domain.Entities.GameResult;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace Services
{
    public class GameResultAppService : IGameResultAppService
    {
        public void Create(GameResult gameResult)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameResult> GetByGameId(string gameId)
        {
            throw new NotImplementedException();
        }
    }
}
