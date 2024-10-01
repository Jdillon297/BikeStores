using BikeStoresApi.Entities;

namespace BikeStoresApi.Data.Repositories;

public interface IStaffRepository
{
    IEnumerable<Staff> GetAllStaff();
}

public class StaffRepository : IStaffRepository
{
    private readonly BikeStoresContext context;

    public StaffRepository(BikeStoresContext context)
    {
        this.context = context;
    }

    public IEnumerable<Staff> GetAllStaff()
    {
        return this.context.Staffs.ToList();
    }
}
