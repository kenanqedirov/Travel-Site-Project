using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<BookingExchangeViewModel2> bookingExchangeViewModel = new List<BookingExchangeViewModel2>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=AZN&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "d34f7cec85mshacf1c458ca22c0ap124081jsn53457880e304" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
                return View(values.exchange_rates);
            }
        }
    }
}
