using System;
using System.Collections.Generic;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Entities
{
    public class LayoutHistory
    {
        public int HistoryId { get; set; }
        public int PageId { get; set; }
        public string? ChangeDescription { get; set; }
        public long ChangedBy { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}
