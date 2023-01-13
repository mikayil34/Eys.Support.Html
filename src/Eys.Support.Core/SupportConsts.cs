using Eys.Support.Debugging;

namespace Eys.Support
{
    public class SupportConsts
    {
        public const string LocalizationSourceName = "Support";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "2e0d1ac2699c4c08ba06b6f1ff416cab";
    }
}
