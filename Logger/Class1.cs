namespace Logger
{
    public class Log : ILog
    {
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        private Log()
        {
        }

        public void LogException(string message)
        {
            Console.WriteLine(message);
        }
    }
}