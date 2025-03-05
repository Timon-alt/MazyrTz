using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Supabase;


namespace MazyrTz
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Client supabase { get; private set; }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var url = "https://mjcragkedspfthrkuxlz.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im1qY3JhZ2tlZHNwZnRocmt1eGx6Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDExNjAwNjMsImV4cCI6MjA1NjczNjA2M30.UI9_kmy4nzzPY6qGICzC5cmeNgvXujSzxbUiIfP9hKA";

            var options = new Supabase.SupabaseOptions()
            {
                AutoConnectRealtime = true,
            };

            supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
        }
    }
}
