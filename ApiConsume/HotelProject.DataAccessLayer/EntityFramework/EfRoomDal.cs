using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfRoomDal:GenericRepository<Room>, IRoomDal
	{
		public EfRoomDal(Context context) : base(context)
		{

		}

		public int RoomCount()
		{
			var context = new Context();
			var roomCount = context.Rooms.Count();
			return roomCount;
		}
	}
}
