using En_Content_Layout_Domain_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Interfaces
{
    public interface IContentLayoutRepository
    {
        Task<IList<AdminPages>> GetPages();
    }
}
