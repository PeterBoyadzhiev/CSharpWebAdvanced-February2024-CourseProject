using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Prefectures;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class PrefectureServiceTests : UnitTestsBase
    {
        private IPrefectureService _prefectureService;

        [SetUp]
        public void SetUp()
        {
            _prefectureService = new PrefectureService(_data);
        }

        [Test]
        public async Task GetAllPrefecturesAsync_ShouldReturnAllPrefectures()
        {
            var expectedPrefectures = _data.Prefectures.OrderBy(p => p.Name).ToList();
            var actualPrefectures = await _prefectureService.GetAllPrefecturesAsync();

            Assert.That(actualPrefectures.Count(), Is.EqualTo(expectedPrefectures.Count));
        }

        [Test]
        public async Task PrefectureExistsByIdAsync_ShouldReturnTrue_IfPrefectureExists()
        {
            var existingPrefectureId = Prefecture.Id;
            var result = await _prefectureService.PrefectureExistsByIdAsync(existingPrefectureId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task PrefectureExistsByIdAsync_ShouldReturnFalse_IfPrefectureDoesNotExist()
        {
            var nonExistingPrefectureId = 999;
            var result = await _prefectureService.PrefectureExistsByIdAsync(nonExistingPrefectureId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AllPrefectureNamesAsync_ShouldReturnAllPrefectureNames()
        {
            var expectedPrefectureNames = _data.Prefectures.Select(p => p.Name).ToList();
            var actualPrefectureNames = await _prefectureService.AllPrefectureNamesAsync();

            Assert.That(actualPrefectureNames.Count(), Is.EqualTo(expectedPrefectureNames.Count));
        }

    }
}
