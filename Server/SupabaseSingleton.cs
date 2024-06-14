using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class SupabaseSingleton
    {
        private String _url = @"https://lxzdzxtnhiptkykmysjy.supabase.co";
        private String _key = @"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imx4emR6eHRuaGlwdGt5a215c2p5Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTgyMDc3MjAsImV4cCI6MjAzMzc4MzcyMH0.RartWEOUAU3sQ_WcImqGXXkJVkwT9WCZ2SV54sNp1BI";
        private static SupabaseClient _instance;

        private SupabaseOptions options = new Supabase.SupabaseOptions
        {
            AutoConnectRealtime = true
        };
        private static readonly object _lock = new object();
        private SupabaseSingleton() { }
        public static SupabaseClient Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SupabaseClient("https://your-project-id.supabase.co", "your-anon-key");
                    }
                    return _instance;
                }
            }
        }
    }
}
