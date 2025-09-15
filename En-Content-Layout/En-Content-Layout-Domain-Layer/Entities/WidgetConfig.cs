using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Entities
{
    public class WidgetConfig
    {
        public int ConfigId { get; set; }
        public int WidgetId { get; set; }
        [Required]
        public string Config { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
