using System;

namespace TextingSystem.Logger
{
    public interface ILogger
    {
        bool IsEnabled(LogEventLevel level);

        #region Verbose

        void Verbose(string messageTemplate);

        void Verbose(string messageTemplate, params object[] propertyValues);

        void Verbose(Exception exception, string messageTemplate);

        void Verbose(Exception exception, string messageTemplate, params object[] propertyValues);

        #endregion

        #region Information

        void Information(string messageTemplate);

        void Information(string messageTemplate, params object[] propertyValues);

        void Information(Exception exception, string messageTemplate);

        void Information(Exception exception, string messageTemplate, params object[] propertyValues);

        #endregion

        #region Debug

        void Debug(string messageTemplate);

        void Debug(string messageTemplate, params object[] propertyValues);

        void Debug(Exception exception, string messageTemplate);

        void Debug(Exception exception, string messageTemplate, params object[] propertyValues);

        #endregion

        #region Warning

        void Warning(string messageTemplate);

        void Warning(string messageTemplate, params object[] propertyValues);

        void Warning(Exception exception, string messageTemplate);

        void Warning(Exception exception, string messageTemplate, params object[] propertyValues);

        #endregion

        #region Error

        void Error(string messageTemplate);

        void Error(string messageTemplate, params object[] propertyValues);

        void Error(Exception exception, string messageTemplate);

        void Error(Exception exception, string messageTemplate, params object[] propertyValues);

        #endregion

        #region Fatal

        void Fatal(string messageTemplate);

        void Fatal(string messageTemplate, params object[] propertyValues);

        void Fatal(Exception exception, string messageTemplate);

        void Fatal(Exception exception, string messageTemplate, params object[] propertyValues);


        #endregion

        #region Write

        void Write(LogEventLevel level, string messageTemplate);

        void Write(LogEventLevel level, string messageTemplate, params object[] propertyValues);

        void Write(LogEventLevel level, Exception exception, string messageTemplate);

        void Write(LogEventLevel level, Exception exception, string messageTemplate, params object[] propertyValues);

        void Write(LogEventLevel level, ushort eventId, string messageTemplate);

        void Write(LogEventLevel level, ushort eventId, string messageTemplate, params object[] propertyValues);

        void Write(LogEventLevel level, ushort eventId, Exception exception, string messageTemplate);

        void Write(LogEventLevel level, ushort eventId, Exception exception, string messageTemplate, params object[] propertyValues);


        #endregion
    }
}
