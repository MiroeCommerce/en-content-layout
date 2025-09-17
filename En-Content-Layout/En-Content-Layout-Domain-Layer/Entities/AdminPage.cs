using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Entities
{
    public class AdminPage
    {
        /// <summary>
        /// Unique page identifier
        /// </summary>
        public int PageId { get; set; }
        /// <summary>
        /// Name of the admin panel page
        /// </summary>
        [Required]
        public string PageName { get; set; }
        /// <summary>
        /// Optional description of the page
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Timestamp when the page was created
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
