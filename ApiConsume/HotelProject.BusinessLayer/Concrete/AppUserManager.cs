﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
	public class AppUserManager : IAppUserService
	{
		private readonly IAppUserDal _appUserDal;

		public AppUserManager(IAppUserDal appUserDal)
		{
			_appUserDal = appUserDal;
		}

		public int TAppUserCount()
		{
			return _appUserDal.AppUserCount();
		}

		public void TDelete(AppUser t)
		{
			throw new NotImplementedException();
		}

		public AppUser TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<AppUser> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TInsert(AppUser t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(AppUser t)
		{
			throw new NotImplementedException();
		}

		public List<AppUser> TUserListWithWorkLocation()
		{
			return _appUserDal.UserListWithWorkLocation();
		}
	}
}
