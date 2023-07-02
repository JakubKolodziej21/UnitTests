using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitTests;

namespace UnitTests.Data
{
    public class UnitTestsContext : DbContext
    {
        public UnitTestsContext (DbContextOptions<UnitTestsContext> options)
            : base(options)
        {
        }

        public DbSet<UnitTests.Task> Task { get; set; } = default!;
    }
}
