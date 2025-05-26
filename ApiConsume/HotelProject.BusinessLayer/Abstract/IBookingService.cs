using HotelProject.EntityLayer.Concrete;
namespace HotelProject.BusinessLayer.Abstract
{
	public interface IBookingService:IGenericService<Booking>
	{
		void TBookingStatusChangeApproved(Booking booking);
		void TBookingStatusChangeApproved2(int id);
		int TGetBookingCount();
		List<Booking> GetLastSixBooking();
		void TBookingStatusChangeApproved3(int id);
		void TBookingStatusChangeCancel(int id);
		void TBookingStatusChangeWait(int id);


	}
}
