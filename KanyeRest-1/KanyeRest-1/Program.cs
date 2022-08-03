﻿using KanyeRest_1;
using Newtonsoft.Json.Linq;
using System.Net.Http;


{
    var client = new HttpClient();

    var quote = new QuoteGenerator(client);

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("------------------------");
        Console.WriteLine($"Kanye: {quote.Kanye()}");

        Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");
    }


}