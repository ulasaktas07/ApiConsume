﻿using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Room2Controller : ControllerBase
	{
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;
		public Room2Controller(IRoomService roomService, IMapper mapper)
		{
			_roomService = roomService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult Index()
		{
			var values = _roomService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddRoom(RoomAddDto model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}
			var values = _mapper.Map<Room>(model);
			_roomService.TInsert(values);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteRoom(int id)
		{
			var values = _roomService.TGetById(id);
			_roomService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateRoom(RoomUpdateDto model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}
			var values = _mapper.Map<Room>(model);
			_roomService.TUpdate(values);
			return Ok("Başarıyla Güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetRoom(int id)
		{
			var values = _roomService.TGetById(id);
			return Ok(values);
		}
	}
}
