namespace RoboSum.Logging.Contracts
{
    /// <summary>
    /// Defines a contract for logging messages.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a message with the given <paramref name="severity"/>
        /// using the <paramref name="messageTemplate"/> and the provided <paramref name="parameters"/>.
        /// </summary>
        /// <param name="severity">The logged message's severity.</param>
        /// <param name="messageTemplate">The logged message template.</param>
        /// <param name="parameters">The parameters to log.</param>
        void Log(Severity severity, string messageTemplate, params object[] parameters);

        /// <summary>
        /// Logs a message with the given <paramref name="severity"/>
        /// using the <paramref name="messageTemplate"/> and the provided <paramref name="parameters"/>.
        /// </summary>
        /// <param name="severity">The logged message's severity.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="messageTemplate">The logged message template.</param>
        /// <param name="parameters">The parameters to log.</param>
        void Log(Severity severity, Exception exception, string messageTemplate, params object[] parameters);
    }
}
