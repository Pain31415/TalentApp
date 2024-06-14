using Supabase;

namespace Server
{
    public class SupabaseSingleton
    {
        private static String _url = @"https://lxzdzxtnhiptkykmysjy.supabase.co";
        private static String _key = @"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imx4emR6eHRuaGlwdGt5a215c2p5Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTgyMDc3MjAsImV4cCI6MjAzMzc4MzcyMH0.RartWEOUAU3sQ_WcImqGXXkJVkwT9WCZ2SV54sNp1BI";
        private static Client _instance;
        private static SupabaseOptions options;
        private static readonly object _lock = new object();
        private SupabaseSingleton() { }
        public static Client Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        options = new SupabaseOptions
                        {
                            AutoConnectRealtime = true

                        };
                        _instance = new Client(_url, _key, options);
                    }
                    return _instance;
                }
            }
        }
    }
}
