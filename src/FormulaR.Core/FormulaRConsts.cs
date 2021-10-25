using FormulaR.Debugging;

namespace FormulaR
{
    public class FormulaRConsts
    {
        public const string LocalizationSourceName = "FormulaR";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "53b10e2db8854c6e8bdbf5da41018106";
    }
}
