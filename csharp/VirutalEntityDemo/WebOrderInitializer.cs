using System;
using System.Collections.Generic;

using VirutalEntityDemo.Models;

namespace VirutalEntityDemo
{
    internal static class WebOrderInitializer
    {
        private static bool _initialized = false;
        private static object _lock = new object();

        private static List<WebOrder> webOrders;

        private static void Seed(WebOrderDbContext context)
        {
            AddWebOrders(context);
        }        

        internal static void Intialize(WebOrderDbContext context)
        {
            if (_initialized == false)
            {
                lock (_lock)
                {
                    if (_initialized == true) { return; }
                }
            }
        }

        private static void AddWebOrders(WebOrderDbContext context)
        {            
            webOrders = new List<WebOrder>();
            for (int i = 0; i < 3; i++)
            {
                webOrders.Add(new WebOrder(Guid.NewGuid(), new DateTime(), Guid.NewGuid(), NextFloat(), NextFloat()));
            }
        }
        private static float NextFloat()
        {
            return (float)Math.Round(new Random().NextDouble() * 100.0f, 2);
        }
    }
}
