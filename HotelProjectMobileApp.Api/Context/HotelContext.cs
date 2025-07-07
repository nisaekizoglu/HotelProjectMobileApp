using HotelProjectMobileApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelProjectMobileApp.Api.Context;

public class HotelContext:DbContext
{
    public HotelContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<CategoryModel> Categories { get; set; }
    public DbSet<RegisterModel> Register { get; set; }
    public DbSet<ReservationModel> Reservations { get; set; }
    public DbSet<UserModel> Users { get; set; }
    //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    //{
    //    var datas = ChangeTracker.Entries<BaseModel>();
    //    foreach (var data in datas)
    //    {
    //        _ = data.State switch
    //        {
    //            EntityState.Added => data.Entity.CheckIn = DateTime.Now,
    //            EntityState.Modified => data.Entity.CheckOut = DateTime.Now,
    //        };
    //    }
    //    return base.SaveChangesAsync(cancellationToken);
    //}
}
