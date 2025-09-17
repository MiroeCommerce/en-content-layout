using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Entities
{
    public class PageWidget
    {
        /// <summary>
        /// Unique identifier for the widget
        /// </summary>
        public int WidgetId { get; set; }
        /// <summary>
        /// Related admin page identifier
        /// </summary>
        public int PageId { get; set; }
        /// <summary>
        /// Name of the widget
        /// </summary>
        [Required]
        public string WidgetName { get; set; }
        /// <summary>
        /// Order/position of widget on the page it belongs to
        /// </summary>
        public int Position { get; set; }


    }
}
