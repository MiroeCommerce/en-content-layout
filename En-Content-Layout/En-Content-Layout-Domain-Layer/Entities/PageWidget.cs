using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Entities
{
    public class PageWidget
    {
        public int WidgetId { get; set; }
        public int PageId { get; set; }
        [Required]
        public string WidgetName { get; set; }
        public int Position { get; set; }


    }
}
