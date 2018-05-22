using Domain.Entities.Game;
using System;

namespace Domain.Interfaces.Repository
{
    interface IGameRepository
    {
        Boolean Exist(Game game);

        void Create(Game game);
    }
}
