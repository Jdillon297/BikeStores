using BikeStoresApi.Data.Repositories;
using BikeStoresApi.Dtos;
using BikeStoresApi.Entities;

namespace BikeStoresApi.Services;

public interface IStaffService
{
    IEnumerable<StaffDto> GetManagers();
    IEnumerable<StaffDto> GetAllStaff();
}

public sealed class StaffService : IStaffService
{
    private readonly IStaffRepository repository;

    public StaffService(IStaffRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<StaffDto> GetAllStaff()
    {
        return MapToDto(this.repository.GetAllStaff());
    }

    public IEnumerable<StaffDto> GetManagers()
    {

        var staff = this.repository.GetAllStaff();

        var distinctManagerIds = staff
            .Select(x => x.ManagerId)
            .Distinct()
            .ToList();
        var managers = (from s in staff
                        join d in distinctManagerIds on s.StaffId equals d
                        select s
                        ).ToList();

        return MapToDto(managers);
    }

    private static IEnumerable<StaffDto> MapToDto(IEnumerable<Staff> staff)
    {
        return staff.Select(x => new StaffDto
        {
            Active = x.Active,
            Email = x.Email,
            FirstName = x.FirstName,
            LastName = x.LastName,
            ManagerId = x.ManagerId,
            Phone = x.Phone,
            StaffId = x.StaffId,
            StoreId = x.StoreId,
        });
    }
}
