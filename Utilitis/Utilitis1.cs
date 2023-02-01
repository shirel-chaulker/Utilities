namespace Utilitis
{
    public class Utilitis1
    {
       
    }
    public interface ILogger
    {
        void Init();
        void LogEvent(LogItem log);
        void LogError(LogItem log);
        void LogException(LogItem log);
        void LogCheckHoseKeeping();
    }
}