using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary.Models
{
    public class Record
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; } = DateTime.Now;
        public string Weather { get; set; }
        public string Content { get; set; }

    }
}
