using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Domain.Models
{
    public class Post : IEntity
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }


    }
}
