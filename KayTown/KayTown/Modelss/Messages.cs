using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KayTown.Modelss
{
    public class Messages
    {
        [PrimaryKey]
        public string MessageID { get; set; }
        [Indexed]
        public string ChatID { get; set; }
        public string SenderID { get; set; }
        // the messageabout to be sent 
        public string Content { get; set; }
        // The file extension of the file
        public string MessageType { get; set; }
        // if the type of file about to be sent is a media
        public string MediaPath { get; set; }
        // The time the last message is sent
        public string TimeStamp {get; set;}
        //Sent , Delivered, Seen
        public string Status { get; set; }
    }
}
