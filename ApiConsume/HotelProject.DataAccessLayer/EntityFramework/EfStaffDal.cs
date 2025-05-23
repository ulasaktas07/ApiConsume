using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfStaffDal : GenericRepository<Staff>, IStaffDal
	{
		public EfStaffDal(Context context) : base(context)
		{
		}

		public List<Staff> GetLastFourStaff()
		{
			using var context = new Context();
			var values = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
			return values;
		}

		public int GetStaffCount()
		{
			using var context = new Context();
			return context.Staffs.Count();
		}
	}
}
