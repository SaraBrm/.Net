using Entities;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public interface IDataBaseContext
    {
        DbSet<User> Users { get; set; }

    }
}
