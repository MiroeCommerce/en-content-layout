using En_Content_Layout_Application_Layer.Interfaces;
using En_Content_Layout_Domain_Layer.Entities;
using En_Content_Layout_Domain_Layer.Interfaces;

namespace En_Content_Layout_Application_Layer
{
    public class ContentLayoutService : IContentLayoutService
    {
        private readonly IContentLayoutRepository _contentLayoutRepository;
        public ContentLayoutService(IContentLayoutRepository contentLayoutRepository)
        {
            _contentLayoutRepository = contentLayoutRepository;
        }

        public async Task<IList<AdminPages>> GetPages()
        {
            return await _contentLayoutRepository.GetPages();
        }
    }
}
