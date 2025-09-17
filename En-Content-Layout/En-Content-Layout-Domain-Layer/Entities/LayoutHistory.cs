using System;
using System.Collections.Generic;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Entities
{
    public class LayoutHistory
    {
        /// <summary>
        /// Unique history record identifier
        /// </summary>
        public int HistoryId { get; set; }
        /// <summary>
        /// Related admin page identifier
        /// </summary>
        public int PageId { get; set; }
        /// <summary>
        /// Description of the layout change
        /// </summary>
        public string? ChangeDescription { get; set; }
        /// <summary>
        /// Admin user who made the change
        /// </summary>
        public long ChangedBy { get; set; }
        /// <summary>
        /// Timestamp when change was made
        /// </summary>
        public DateTime ChangedAt { get; set; }
    }
}
