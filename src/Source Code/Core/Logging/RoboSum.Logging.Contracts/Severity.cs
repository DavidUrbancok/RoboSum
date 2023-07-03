namespace RoboSum.Logging.Contracts
{
    /// <summary>
    /// Represents the severity of a logged message.
    /// </summary>
    public enum Severity
    {
        /// <summary>
        /// The 'info' log severity.
        /// </summary>
        Info,

        /// <summary>
        /// The 'trace' log severity.
        /// </summary>
        Trace,

        /// <summary>
        /// The 'debug' log severity.
        /// </summary>
        Debug,

        /// <summary>
        /// The 'warning' log severity.
        /// </summary>
        Warning,

        /// <summary>
        /// The 'error' log severity.
        /// </summary>
        Error,

        /// <summary>
        /// The 'fatal' log severity.
        /// </summary>
        Fatal
    }
}
