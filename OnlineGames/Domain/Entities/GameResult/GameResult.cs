using System;

namespace Domain.Entities.GameResult
{
    public class GameResult
    {
        public string PlayerId { get; set; }

        public string GameId { get; set; }

        public long Score { get; set; }

        public DateTime updateDate { get; set; }
    }
}
