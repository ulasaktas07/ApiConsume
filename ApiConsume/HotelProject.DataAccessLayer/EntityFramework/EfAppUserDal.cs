﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfAppUserDal:GenericRepository<AppUser>, IAppUserDal
	{
		public EfAppUserDal(Context context) : base(context)
		{
		}

		public int AppUserCount()
		{
			var context = new Context();
			return context.Users.Count();
		}

		public List<AppUser> UserListWithWorkLocation()
		{
			var context = new Context();
			return context.Users.Include(x => x.WorkLocation).ToList();
		}
	
	}
}
