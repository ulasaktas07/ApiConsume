﻿namespace HotelProject.WebUI.Dtos.SendMessageDto
{
	public class CreateSendMessageDto
	{
		public string ReciverName { get; set; }
		public string ReciverMail { get; set; }
		public string SenderName { get; set; }
		public string SenderMail { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime Date { get; set; } = DateTime.Parse(DateTime.Now.ToShortDateString());
	}
}
