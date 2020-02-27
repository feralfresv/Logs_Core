using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace AcademyLogDll
{
    public class Log
    {
        public void ConnectToWebAPI(LogEntity log)
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:64813/");
                client.BaseAddress = new Uri("http://academylog.azurewebsites.net/");
                var responseTask = client.PostAsJsonAsync<LogEntity>("api/logs/save", log);

                responseTask.Wait();

                var result = responseTask.Result;
            }

        }

    }
}
