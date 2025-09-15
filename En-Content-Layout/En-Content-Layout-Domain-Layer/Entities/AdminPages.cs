using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Entities
{
    public class AdminPages
    {
        public int PageId { get; set; }
        [Required]
        public string PageName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
