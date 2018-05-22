using Domain.Entities.Player;
using System;

namespace Domain.Interfaces.Repository
{
    interface IPlayerRepository
    {
        Boolean Exist(Player player);

        void Create(Player player);
    }
}
