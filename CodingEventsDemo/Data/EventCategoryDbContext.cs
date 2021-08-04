using System;
using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingEventsDemo.Data
{
    public class EventCategoryDbContext : DbContext
    {
        public DbSet<EventCategory> EventCategories { get; set; }
        

        public EventCategoryDbContext(DbContextOptions<EventCategoryDbContext> options) : base(options)
        {

        }
    }
}
