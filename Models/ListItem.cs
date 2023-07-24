using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary.Models
{
    public class ListItem
    {
        public long Id { set; get; }
        public DateTime CreateTime { set; get; }
        public string Content { set; get; }

        public ListItem(long id, DateTime dateTime, string content)
        {
            this.Id = id;
            this.CreateTime = dateTime;
            this.Content = content;
        }
    }
}
