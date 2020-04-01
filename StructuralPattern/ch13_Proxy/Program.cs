using System.Reflection;
using System;
using System.Configuration;
using Microsoft.Extensions.Caching.Memory;

//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0

namespace ch13_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Searcher in Protect Proxy And Smart Reference Proxy
            {
                /*
                var proxy = ConfigurationManager.AppSettings["proxy"];
                SearchAPI.ISearcher searcher = (SearchAPI.ISearcher)Assembly.Load("ch13_Proxy").CreateInstance(proxy);
                var rs = searcher.DoSearch("Hulk", "gamma");
                var rs_null = searcher.DoSearch("Fake_Hulk", "X-ray");
                */
            }
            // 2. Searcher in Cache Proxy
            {
                var searcher = new SearchAPI.SearchCacheProxy(new MemoryCache(new MemoryCacheOptions()));
                var rs1 = searcher.DoSearch("Hulk", "gamma");
                var rs2 = searcher.DoSearch("Hulk", "gamma");
            }

            // Exercise 1. Smart Reference Proxy : Record business method called log
            // befoer call: log "method xx() is called, call time is yyyy-MM-dd hh:mm:ss"
            // call method xx()
            // after call: if no exception, "method xx() is called successful";
            //              else "method xx() is called failed"

            // Exercise 2. Protect Proxy : Blog - user and visitor
            // user have right: publish blog, update profile, edit blog
            // visitor right: view blog

            // Exercise 3. Virtual Proxy : image viewer
            // download web image via input url.
            // two thread: thread one to show icon, thread two to download real image
            // lots images in one page: 
            //       firstly, show image icon based on image type, show image name;
            //       secondly, user click icon, to view real image;

            // Exercise 4. Remote Proxy: Basic Math Operation
            // using web service/dcom, to implement plus, minus, multiple, devide operation
            // then called from local

            Console.ReadKey();
        }
    }
}
