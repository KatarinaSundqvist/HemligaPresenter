using HemligaPresenter.Models;
using Microsoft.EntityFrameworkCore;

namespace HemligaPresenter.Data {
    public sealed class PresentContext : DbContext {
        public DbSet<Wish> MyProperty { get; set; }
    }
}
