using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Entities
{
    public class WidgetConfig
    {
        /// <summary>
        /// Unique configuration identifier
        /// </summary>
        public int ConfigId { get; set; }
        /// <summary>
        /// Related widget identifier
        /// </summary>
        public int WidgetId { get; set; }
        /// <summary>
        /// JSON object with widget settings
        /// </summary>
        [Required]
        public string Config { get; set; }
        /// <summary>
        /// Timestamp of configuration creation
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
