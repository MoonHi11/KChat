using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KayTown.Modelss
{
    public class ChatParticipants
    {
        [PrimaryKey]
        public string Id { get; set;} = 
            Guid.NewGuid().ToString();
        [Indexed]
        public string ChatId { get; set; }
        public string UserId { get; set; }
    }
}
