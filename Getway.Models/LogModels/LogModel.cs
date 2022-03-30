using Getway.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getway.Models.LogModels
{
    public class LogModel
    {
        public LogModel()
        {
            LogDate = DateTime.Now;
        }

        public int ID { get; set; }

        public string LogDec { get; set; }

        public LogTypes LogTypes { get; set; }

        public DateTime LogDate { get; set; }
    }
}
