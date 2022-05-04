using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV3Lib
{
    public class LoggerManager
    {
        Dictionary<LogType, ILoggerFactory> loggers;
        public LoggerManager()
        {
            loggers = new();
            loggers.Add(LogType.DbLogger, new DbLoggerFactory());
            loggers.Add(LogType.FileLogger, new FileLoggerFactory());
        }

        public ILoggerFactory CreateFactory(LogType logType)
        {
            return loggers[logType];
        }
    }
    public enum LogType
    {
        FileLogger,
        DbLogger
    }
}
