﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfBookingDal:GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(Context context) : base(context)
		{

		}

		public void BookingStatusChangeApproved(Booking booking)
		{
			var context = new Context();
			var values=context.Bookings.Where(x=>x.BookingID==booking.BookingID).FirstOrDefault();
			values.Status = "Onaylandı";
			context.SaveChanges();
		}

		public void BookingStatusChangeApproved2(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Onaylandı";
			context.SaveChanges();
		}

		public void BookingStatusChangeApproved3(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Onaylandı";
			context.SaveChanges();
		}

		public void BookingStatusChangeCancel(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "İptal Edildi";
			context.SaveChanges();
		}

		public void BookingStatusChangeWait(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Müşteri Aranacak";
			context.SaveChanges();
		}

		public int GetBookingCount()
		{
			var context = new Context();
			var values = context.Bookings.Count();
			return values;
		}

		public List<Booking> GetLastSixBooking()
		{
			var context = new Context();
			var values = context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
			return values;
		}
	}
}
