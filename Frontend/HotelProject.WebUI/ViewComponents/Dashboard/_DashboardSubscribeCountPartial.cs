using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardSubscribeCountPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/ulas.akts07"),
				Headers =
	{
		{ "x-rapidapi-key", "ebc6120d30mshcaba12226a713cap115b63jsn79340c9e14f1" },
		{ "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				ResultInstagramFollowersDto resultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
				ViewBag.v1 = resultInstagramFollowersDto.followers;
				ViewBag.v2 = resultInstagramFollowersDto.following;
			}
			var client2 = new HttpClient();
			var request2 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://twitter32.p.rapidapi.com/profile?username=Ulassaktas07"),
				Headers =
	{
		{ "x-rapidapi-key", "ebc6120d30mshcaba12226a713cap115b63jsn79340c9e14f1" },
		{ "x-rapidapi-host", "twitter32.p.rapidapi.com" },
	},
			};
			using (var response2 = await client2.SendAsync(request2))
			{
				response2.EnsureSuccessStatusCode();
				var body2 = await response2.Content.ReadAsStringAsync();
				ResultTwitterFollowersDto resultTwitterFollowersDtos = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
				ViewBag.v3 = resultTwitterFollowersDtos.data.stats.followers;
				ViewBag.v4 = resultTwitterFollowersDtos.data.stats.following;
			}
			var client3 = new HttpClient();
			var request3 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fula%25C5%259F-akta%25C5%259F-1ba026192%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
				Headers =
	{
		{ "x-rapidapi-key", "ebc6120d30mshcaba12226a713cap115b63jsn79340c9e14f1" },
		{ "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
	},
			};
			using (var response3 = await client3.SendAsync(request3))
			{
				response3.EnsureSuccessStatusCode();
				var body3 = await response3.Content.ReadAsStringAsync();
				ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
				ViewBag.v5 = resultLinkedinFollowersDto.data.follower_count;
			}
			return View();
		}

	}
}
