using ExploreUmami.Web.ViewModels.Business;

namespace ExploreUmami.Web.ViewModels.Prefectures
{
    public class PrefectureInfoModel
    {
        public string PrefectureName { get; set; } = null!;

        public int BusinessCount { get; set; }
        
        public BusinessAllViewModel? HighestRatedBusiness { get; set; }
    }
}
