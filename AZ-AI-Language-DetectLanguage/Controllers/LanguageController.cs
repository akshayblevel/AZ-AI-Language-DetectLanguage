using AZ_AI_Language_DetectLanguage.Interfaces;
using AZ_AI_Language_DetectLanguage.Models;
using Microsoft.AspNetCore.Mvc;

namespace AZ_AI_Language_DetectLanguage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController(IAnalysisService analysisService) : ControllerBase
    {
        [HttpPost("Detect")]
        public async Task<IActionResult> GetDenseCaptions([FromBody] DetectRequest detectRequest)
        {
            var result = await analysisService.DetectLanguage(detectRequest.Text);
            return Ok(result);
        }
    }
}
