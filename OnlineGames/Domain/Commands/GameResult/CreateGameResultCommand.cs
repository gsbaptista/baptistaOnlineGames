using System;

namespace Domain.Commands.GameResult
{
    public class CreateGameResultCommand
    {
        public string PlayerId { get; set; }

        public string GameId { get; set; }

        public long Score { get; set; }

        public DateTime updateDate { get; set; }
    }
}
