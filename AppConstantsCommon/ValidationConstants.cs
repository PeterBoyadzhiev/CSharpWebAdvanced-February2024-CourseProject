namespace ExploreUmami.Common
{
    public static class ValidationConstants
    {
        public static class Category
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }

        public static class Business
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 50;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 500;
            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 100;
            public const int PhoneNumberMinLength = 10;
            public const int PhoneNumberMaxLength = 20;
            public const string PhoneNumberRegularExpression = @"^\d{2}-\d{4}-\d{4}$";
            public const string PhoneNumberErrorMessage = "Phone number must be in the format 00-0000-0000";
            public const int WebsiteUrlMinLength = 10;
            public const int WebsiteUrlsiteMaxLength = 2048;
            public const int ImageUrlMinLength = 10;
            public const int ImageUrlMaxLength = 2048;
        }

        public static class Review
        {
            public const int SubjectMinLength = 3;
            public const int SubjectMaxLength = 25;
            public const int ContentMinLength = 10;
            public const int ContentMaxLength = 500;
            public const double MinRating = 1;
            public const double MaxRating = 5;
        }

        public static class BusinessOwner
        {
            public const int PhoneNumberMinLength = 10;
            public const int PhoneNumberMaxLength = 20;
            public const string PhoneNumberRegularExpression = @"^\d{2}-\d{4}-\d{4}$";
            public const string PhoneNumberErrorMessage = "Phone number must be in the format 00-0000-0000";
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 20;
            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 20;
            public const int NameOfBusinessMinLength = 3;
            public const int NameOfBusinessMaxLength = 50;

        }

        public static class Prefecture
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 20;
        }

        public static class Reservation
        {
            public const int NotesMinLength = 10;
            public const int NotesMaxLength = 500;
        }

        public static class UserVisit
        {
            public const int NotesMinLength = 10;
            public const int NotesMaxLength = 500;
        }
    }
}
