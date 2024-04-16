using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Review;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class ReviewServiceTests : UnitTestsBase
    {
        private IReviewService _reviewService;

        [SetUp]
        public void SetUp()
        {
            _reviewService = new ReviewService(_data);
        }

        [Test]
        public async Task GetAllReviewsAsync_ShouldReturnAllReviews()
        {
            var expectedReviews = _data.Reviews.OrderBy(r => r.Id).ToList();
            var actualReviews = await _reviewService.GetAllReviewsAsync();

            Assert.That(actualReviews.Count(), Is.EqualTo(expectedReviews.Count));
        }

        [Test]
        public async Task ReviewExistsByUserForBusinessAsync_ShouldReturnTrue_IfReviewExists()
        {
            var existingUserId = User2.Id.ToString();
            var existingBusinessId = Business.Id.ToString();
            var result = await _reviewService.ReviewExistsByUserForBusinessAsync(existingUserId, existingBusinessId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task ReviewExistsByUserForBusinessAsync_ShouldReturnFalse_IfReviewDoesNotExist()
        {
            var nonExistingUserId = "C789E697-C4CC-44BE-B033-44B4BC561E67"; // Non-existing user id
            var nonExistingBusinessId = "C789E697-C4CC-44BE-B033-44B4BC561E67"; // Non-existing business id
            var result = await _reviewService.ReviewExistsByUserForBusinessAsync(nonExistingUserId, nonExistingBusinessId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AddReviewAsync_ShouldCreateReview_WhenValidDataProvided()
        {
            var userId = User.Id.ToString();
            var businessId = Business.Id.ToString();
            var reviewService = new ReviewService(_data); // Create new instance per test

            var testModel = new ReviewFormModel { Rating = 5, Subject = "Test Subject", Content = "Test Content" };

            int expectedCount = 2; // Initial count is 1, so this should be 2 after adding a new review
            string location = "Test,Test";

            await reviewService.AddReviewAsync(testModel, userId, businessId, location);

            // Verify data is added to the database (without relying on mocking)
            int reviewCount = this._data.Reviews.Count();
            Assert.That(expectedCount, Is.EqualTo(reviewCount));

            // You can optionally verify specific properties of the added Review object
            // using LINQ or other methods to retrieve it from the DbContext.
        }

        [Test]
        public async Task UserHasReviewForVisitAsync_ShouldReturnTrue_IfUserHasReviewForVisit()
        {
            var existingUserId = User2.Id.ToString();
            var existingVisitId = UserVisit.Id.ToString();
            var result = await _reviewService.UserHasReviewForVisitAsync(existingUserId, existingVisitId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task UserHasReviewForVisitAsync_ShouldReturnFalse_IfUserDoesNotHaveReviewForVisit()
        {
            var nonExistingUserId = "C789E697-C4CC-44BE-B033-44B4BC561E67"; // Non-existing user id
            var nonExistingVisitId = "C789E697-C4CC-44BE-B033-44B4BC561E67"; // Non-existing visit id
            var result = await _reviewService.UserHasReviewForVisitAsync(nonExistingUserId, nonExistingVisitId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task RemoveReviewAsync_ShouldRemoveReview_WhenValidDataProvided()
        {
            //Create a new review and add it to the database
            //Call method to remove it
            //Check if review.IsActive is false

            var userId = User.Id;
            var businessId = Business.Id;
            var reviewService = new ReviewService(_data); // Create new instance per test

            var testModel = new ReviewFormModel { Rating = 5, Subject = "Test Subject", Content = "Test Content" };
            _data.Reviews.Add(new Review { ReviewerId = userId, BusinessId = businessId,
                Rating = testModel.Rating, Subject = testModel.Subject, Content = testModel.Content, IsActive = true });
            _data.SaveChanges();

            var review = _data.Reviews.FirstOrDefault(r => r.ReviewerId == userId && r.BusinessId == businessId);
            await reviewService.RemoveReviewAsync(review!.Id.ToString());

            Assert.IsFalse(review.IsActive);
        }

        [Test]
        public async Task AllowReviewAsync_ShouldAllowReview_WhenValidDataProvided()
        {
            //Create a new review and add it to the database
            //Call method to allow it
            //Check if review.IsActive is true

            var userId = User.Id;
            var businessId = Business.Id;
            var reviewService = new ReviewService(_data); // Create new instance per test

            var testModel = new ReviewFormModel { Rating = 5, Subject = "Test Subject", Content = "Test Content" };
            _data.Reviews.Add(new Review { ReviewerId = userId, BusinessId = businessId,
                Rating = testModel.Rating, Subject = testModel.Subject, Content = testModel.Content, IsActive = false });
            _data.SaveChanges();

            var review = _data.Reviews.FirstOrDefault(r => r.ReviewerId == userId && r.BusinessId == businessId);
            await reviewService.AllowReviewAsync(review!.Id.ToString());

            Assert.IsTrue(review.IsActive);
        }

        [Test]
        public async Task ReviewBelongsToUserAsync_ShouldReturnTrue_IfReviewBelongsToUser()
        {
            var existingUserId = User2.Id.ToString();
            var existingReviewId = Review.Id.ToString();
            var result = await _reviewService.ReviewBelongsToUserAsync(existingUserId, existingReviewId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task ReviewBelongsToUserAsync_ShouldReturnFalse_IfReviewDoesNotBelongToUser()
        {
            var nonExistingUserId = "C789E697-C4CC-44BE-B033-44B4BC561E67"; // Non-existing user id
            var nonExistingReviewId = "C789E697-C4CC-44BE-B033-44B4BC561E67"; // Non-existing review id
            var result = await _reviewService.ReviewBelongsToUserAsync(nonExistingUserId, nonExistingReviewId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetReviewToEditAsync_ShouldReturnReview_WhenValidReviewIdProvided()
        {
            var reviewId = Review.Id.ToString();
            var expectedReview = new ReviewEditFormModel
            {
                Rating = Review.Rating,
                Subject = Review.Subject,
                Content = Review.Content,
            };

            var actualReview = await _reviewService.GetReviewToEditAsync(reviewId);

            Assert.That(actualReview.Rating, Is.EqualTo(expectedReview.Rating));
            Assert.That(actualReview.Subject, Is.EqualTo(expectedReview.Subject));
            Assert.That(actualReview.Content, Is.EqualTo(expectedReview.Content));
        }

        [Test]
        public async Task EditReviewAsync_ShouldEditReview_WhenValidDataProvided()
        {
            var userId = User.Id;
            var businessId = Business.Id;
            var reviewService = new ReviewService(_data); // Create new instance per test

            var testModel = new ReviewFormModel { Rating = 5, Subject = "Test Subject", Content = "Test Content" };
            _data.Reviews.Add(new Review { ReviewerId = userId, BusinessId = businessId,
                           Rating = testModel.Rating, Subject = testModel.Subject, Content = testModel.Content, IsActive = true });
            _data.SaveChanges();

            var review = _data.Reviews.FirstOrDefault(r => r.ReviewerId == userId && r.BusinessId == businessId);
            var reviewId = review!.Id.ToString();
            var editModel = new ReviewEditFormModel { Id = reviewId, Rating = 4, Subject = "Edited Subject", Content = "Edited Content" };
            await reviewService.EditReviewAsync(editModel);

            Assert.That(review.Rating, Is.EqualTo(editModel.Rating));
            Assert.That(review.Subject, Is.EqualTo(editModel.Subject));
            Assert.That(review.Content, Is.EqualTo(editModel.Content));
        }

        [Test]



    }
}
