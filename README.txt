The project is a simple web application that uses a MySQL database.
The main topic is registering businesses (mainly food oriented, though it is not a prerequisite) and allowing users to make reservations
at these businesses and review them after visiting.

Setup:
There is data to be seeded for the Db, it is under ExploreUmami.Data.Configurations.
Use it to seed the following data:
- Users:
 1 Admin,
 2 Business Owners,
 2 Regular Users
- Businesses:
 8 Total Businesses from 8 different categories and 5 different prefectures
 2 Businesses are not approved (to do with Admin actions)
- Categories:
 8 Total Categories
- Prefectures:
 47 Total Prefectures
- Reservations:
 7 Reservations
 There is a reservation for every ReservationStatus to test Business Owner and User actions
- Reviews:
 3 Reviews, 2 with differet ratings for the same business
- UserVisit:
 4 UserVisits, 1 does not have an associated review

The project is structured in a way that the main project is the ExploreUmami.Web project and it also uses a WebApi project for the API calls in ExploreUmami.WebAPI,
used for the Map on the Index page. You need to run both projects to see the full functionality of the application.
Reviews are tied to UserVisits, so you need to visit a business to leave a review.
UserVisits are tied to Completed Reservations, so you need to make a reservation to visit a business and have it Completed (by Business Owner).

Functionality:
Anonymous users:
- Can view the Index page with an SVG map of Japan with all prefectures
- Can hover over a prefecture to see the number of businesses and top-rated business in that prefecture.
- Can click on a prefecture to see all businesses in that prefecture.
- Can access All Businesses page to see all businesses.
- Can access the Business Details page to see more information about a business + reviews.
- Has the option to click on Make Reservation button that will redirect to the Login page.
- Can access the Register page to create an account.
- Can access the Login page to log in.

Basic Users/Reviewers:
- Can view the Index page with an SVG map of Japan with all prefectures
- Can hover over a prefecture to see the number of businesses and top-rated business in that prefecture.
- Can click on a prefecture to see all businesses in that prefecture.
- Can access All Businesses page to see all businesses.
- Can access the Business Details page to see more information about a business.
- Can access the Make Reservation page to make a reservation.
- Can access the My Reservations page to see all reservations.
- Can cancel reservations from the My Reservations page if they are either "Pending" or "Confirmed" and leave a reason.
- Can access the Visited Businesses page to see all visits.
- Can write a new review if they have visited a business but have not reviewed yet.
- Can edit an already left review.
- Can access the Business's Details page to see more information about the Business they are leaving/have left a review on + see all reviews.
- Can access the User's Profile page to change their password.
- Can switch to Business Owner by providing a phone number and a Business Name.

Business Owners:
- Can view the Index page with an SVG map of Japan with all prefectures
- Can hover over a prefecture to see the number of businesses and top-rated business in that prefecture.
- Can click on a prefecture to see all businesses in that prefecture.
- Can access All Businesses page to see all businesses.
- Can access the Business Details page to see more information about a business.
- Can Edit or Delete their business from the Business Details page. Businesses that do not belong to the logged-in user will not have these options.
- Can Edit or Delete their business from the My Businesses page.
- Can Add a new business from the Add Business page.
- Can access the My Reservations page to see all reservations for their business.
- Can changes status of Reservation to "Confirmed" or "Pending" from My Reservations page if they are either "Pending" or "Confirmed".
- Can cancel reservations from the My Reservations page if they are either "Pending" or "Confirmed" and leave a reason.
- Can complete a reservation from the My Reservations page and leave a note. Completing a reservation will also add a record to the UserVisit table.
- Can access the Visits page to see all visits for their business, as well as the visitor details and associated review if one was left.
- Can access the User's Profile page to change their password.

Admin:
- Has access to the Admin Dashboard page (Admin Area).
- Can view all businesses and filter them by status. Also sees businesses that are not approved or inactive.
- Can approve or delete businesses from the All Businesses page. Approved businesses will be visible to the public. Inactive businesses will not be visible to the public.
- Can reinstate a deleted business from the All Businesses page.
- Can view last 3 businesses awaiting approval in the For Approval page.
- Can edit a business from the All Businesses page.
- Can review business details from the All Businesses page.
- Can view all reviews for all businesses from the All Reviews page.
- Can remove reviews from the All Reviews page. Removed reviews will not be visible to the public but can be allowed again.
- Can view all categories from the All Categories page.
- Can add a new category from the All Categories page.
- Can edit a category from the All Categories page.

Example journey:
- Unauthorized user visits the Index page and reviews businesses either by hovering over a prefecture, by clicking on a prefecture or in the All Businesses page.
- Unauthorized user clicks on a business to see more details.
- Unauthorized user clicks on Make Reservation and is redirected to the Login page.
- Unauthorized user clicks on Register and creates an account.
- Now authorized user is logged in and redirected to the Make Reservation page.
- Authorized user makes a reservation and is redirected to the My Reservations page.
- Authorized user cancels the reservation and leaves a reason.
- Authorized user makes another reservation for same or different business.
- Business Owner logs in and sees the reservation in the My Reservations page.
- Business Owner confirms the reservation.
- *imaginary scenario* Authorized user visits the business in real life.
- Business Owner completes the reservation and leaves a note.
- Authorized user logs in and sees the visit in the Visits page.
- Authorized user writes a review for the business.
- Business Owner logs in and sees the review in the Business Details page or Visits page.
- Authorized user edits the review to a bad one.
- *imaginary scenario* Admin logs in and sees the review in the All Reviews page and contacts administrator to remove it.
- Admin logs in and removes the review from the All Reviews Page.

Example journey 2:
- Business Owner logs in and adds a new business from the Add Business page.
- Business Owner edits the business from the My Businesses page.
- Admin logs in and sees the business in the For Approval page.
- Admin approves the business from the For Approval page.
- Business Owner deletes the business from the My Businesses page.
- *imaginary scenario* Business Owner contacts Admin to request new category.
- Admin logs in and adds a new category from the All Categories page.
- Admin edits the category from the All Categories page.
- Admin reinstates the deleted business from the All Businesses page.
- Business Owner logs in and sees the business in the All Businesses page.
- Business Owner edits the business from the All Businesses page with the new category.
