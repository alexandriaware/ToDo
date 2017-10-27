using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class List
    {
        [Key]
        public int ListId { get; set; }
        public string ListName { get; set; }

        public virtual ICollection<Item> Item { get; set; }
    }
}