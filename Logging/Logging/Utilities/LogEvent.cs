﻿namespace Logging.Utilities
{
    public static class LogEvent
    {
        public const int SomeErrorOccurred = 4000;
        public const int SpecificErrorOccurred = 4001;

        public const int ProcessStarted = 1000;
        public const int Completed = 1002;
        public const int InProcess = 1004;
    }
}
