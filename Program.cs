using System;
using System.Net.Http;

namespace c1
{
    class Program
    {
        static void Main(string[] args)
        {
            using var client = new HttpClient();
        }
    }
}
