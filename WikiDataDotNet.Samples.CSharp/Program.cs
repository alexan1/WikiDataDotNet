using System;

namespace WikiDataDotNet.Samples.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var italy = Request.request_entity("Q38");
            
            Console.WriteLine(italy.title);
            Console.WriteLine(italy.descriptions);

            var searchResult = Request.search_english("Trump");
            Console.WriteLine(searchResult.search);
        }
    }
}
