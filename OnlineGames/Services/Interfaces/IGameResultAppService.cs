using Domain.Entities.GameResult;

namespace Services.Interfaces
{
    interface IGameResultAppService
    {
        void Create(GameResult gameResult);
    }
}
