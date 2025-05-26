using HotelProject.EntityLayer.Concrete;
namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IBookingDal:IGenericDal<Booking>
	{
		void BookingStatusChangeApproved(Booking booking);
		void BookingStatusChangeApproved2(int id);
		int GetBookingCount();
		List<Booking> GetLastSixBooking();
		void BookingStatusChangeApproved3(int id);
		void BookingStatusChangeCancel(int id);
		void BookingStatusChangeWait(int id);
	}

}
