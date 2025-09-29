namespace Asenda.DHP.Core.Constants
{
    public static class Messages
    {
        public struct ApiErrors
        {
            public const string General500Message = "An error occurred. Please try again later.";

            public const string General501Message = "Method not implemented";

            public const string General403Message = "Operation forbidden";
        }

        public struct SqlErrors
        {
            public const string ConstraintCheckViolationMessage = "Failed to execute the statement due to constraints violation.";

            public const string DuplicatedKeyRowErrorMessage = "Cannot put duplicate index values into a column or columns with a unique index";
        }

        public struct GenericErrors
        {
            public const string ReferenceNotMatchingTypeOfEntityMessage = "Reference used does not match the type of entity.";
        }

        public struct Emails
        {
            public const string NewFeedbackSubject = "New feedback received";
        }

        public struct Schedules
        {
            public const string ScheduleOverlap = "The overlap schedule or request schedule change has not been approved.";
        }
    }
}
