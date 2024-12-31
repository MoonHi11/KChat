using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KayTown.Modelss
{
    public class Media
    {
        [PrimaryKey]
        public string MediaID { get; set; }
        public string MessageID { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
    }
}
