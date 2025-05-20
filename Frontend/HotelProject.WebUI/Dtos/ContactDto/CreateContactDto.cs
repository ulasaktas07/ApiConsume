using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.Dtos.ContactDto
{
	public class CreateContactDto
	{
		public string Name { get; set; }
		public string Mail { get; set; }
		public string Message { get; set; }
		public string Subject { get; set; }
		public DateTime Date { get; set; } = Convert.ToDateTime(DateTime.Now.ToString());
		public int MessageCategoryID { get; set; }
		public MessageCategory? MessageCategory { get; set; }

	}
}
