﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
	public class BookingManager : IBookingService
	{
		private readonly IBookingDal _bookingDal;

		public BookingManager(IBookingDal bookingDal)
		{
			_bookingDal = bookingDal;
		}

		public List<Booking> GetLastSixBooking()
		{
			return _bookingDal.GetLastSixBooking();
		}

		public void TBookingStatusChangeApproved(Booking booking)
		{
			_bookingDal.BookingStatusChangeApproved(booking);
		}

		public void TBookingStatusChangeApproved2(int id)
		{
			_bookingDal.BookingStatusChangeApproved2(id);
		}

		public void TDelete(Booking t)
		{
			_bookingDal.Delete(t);
		}

		public int TGetBookingCount()
		{
			return _bookingDal.GetBookingCount();
		}

		public Booking TGetById(int id)
		{
			return _bookingDal.GetById(id);
		}

		public List<Booking> TGetList()
		{
			return _bookingDal.GetList();
		}

		public void TInsert(Booking t)
		{
			_bookingDal.Insert(t);
		}

		public void TUpdate(Booking t)
		{
			_bookingDal.Update(t);
		}
	}
}
