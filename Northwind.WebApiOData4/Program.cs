﻿using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            StartOptions options = new StartOptions();
            options.Urls.Add("http://localhost:9000");
            options.Urls.Add("http://northwind-v4.jaystack.com:9000/");

            // Start OWIN host 
            using (WebApp.Start<Startup>(options))
            {
                // Create HttpCient and make a request to api/values 
                //HttpClient client = new HttpClient();

                //var response = client.GetAsync(baseAddress + "api/values").Result;

                //Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                //Console.ReadLine();
                ConsoleKeyInfo k;
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                    }
                    k = Console.ReadKey(true);
                    Console.Clear();
                } while (k.KeyChar != 'q');
            }
        }
    }
}
