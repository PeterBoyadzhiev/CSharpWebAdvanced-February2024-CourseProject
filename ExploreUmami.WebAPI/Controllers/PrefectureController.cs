using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Prefectures;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.WebAPI.Controllers
{
    [Route("api/Prefecture")]
    [ApiController]
    public class PrefectureController : ControllerBase
    {
        private readonly IPrefectureService prefectureService;

        public PrefectureController(IPrefectureService prefectureService)
        {
            this.prefectureService = prefectureService;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(PrefectureInfoModel))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> All(string prefectureName)
        {
            try
            {
                PrefectureInfoModel model = await this.prefectureService.GetPrefectureInfoAsync(prefectureName);

                return this.Ok(model);
            }
            catch (Exception)
            {

                return this.BadRequest();
            }
        }
    }
}
