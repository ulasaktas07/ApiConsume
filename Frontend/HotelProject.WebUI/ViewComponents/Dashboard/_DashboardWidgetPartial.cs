﻿using HotelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardWidgetPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5195/api/DashboardWidgets/StaffCount");
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			ViewBag.staffCount = jsonData;
			var responseMessage2 = await client.GetAsync("http://localhost:5195/api/DashboardWidgets/BookingCount");
			var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
			ViewBag.bookingCount = jsonData2;
			var responseMessage3 = await client.GetAsync("http://localhost:5195/api/DashboardWidgets/AppUserCount");
			var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
			ViewBag.appUserCount = jsonData3;
			var responseMessage4 = await client.GetAsync("http://localhost:5195/api/DashboardWidgets/RoomCount");
			var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
			ViewBag.roomCount = jsonData4;
			return View();
		}
	}
}
