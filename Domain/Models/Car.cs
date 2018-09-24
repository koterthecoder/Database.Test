using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Domain.Models
{
    public class Car : IEntity
    {

        [Key]
        public long Id { get; set; }
        public string LicenceNumber { get; set; }
        public long AccountId { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }



    }
}
