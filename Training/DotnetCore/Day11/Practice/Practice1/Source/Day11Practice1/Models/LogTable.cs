using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Practice1.Models
{
    public partial class LogTable
    {
        public int LogId { get; set; }
        public string EventName { get; set; }
        public string TableName { get; set; }
        public DateTime? OperationDate { get; set; }
    }
}
