using En_Content_Layout_Application_Layer.Interfaces;
using En_Content_Layout_Domain_Layer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace En_Content_Layout
{
    [Route("api/admin")]
    [ApiController]
    public class ContentLayoutController : ControllerBase
    {
        private readonly IContentLayoutService _contentLayoutService;
        public ContentLayoutController(IContentLayoutService contentLayoutService)
        {
            _contentLayoutService = contentLayoutService;
        }
        [HttpGet("pages")]
        public async Task<IActionResult> GetPages()
        {
            var allPages = await _contentLayoutService.GetPages();
            
            if (allPages?.Count>0) 
                return Ok(allPages);
            return NoContent();
        }
    }
}
