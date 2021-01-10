using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CellphoneEntity
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
