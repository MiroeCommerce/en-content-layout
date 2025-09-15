using En_Content_Layout_Domain_Layer.Entities;
using En_Content_Layout_Domain_Layer.Interfaces;

namespace En_Content_Layout_Infrastructure_Layer
{
    public class ContentLayoutRepository : IContentLayoutRepository
    {
        public Task<IList<AdminPages>> GetPages()
        {
            throw new NotImplementedException();
        }
    }
}
