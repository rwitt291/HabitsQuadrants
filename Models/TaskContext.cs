using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HabitsQuadrants.Models
{
    public class TaskContext : DbContext
    {
        //Constructor
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            //blank for now
        }

        public DbSet<AddATaskResponse> responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder nb)
        //{
        //    nb.Entity<Category>().HasData(
        //        new Category { CategoryId = 1, CategoryName = "Home" },
        //        new Category { CategoryId = 2, CategoryName = "School" },
        //        new Category { CategoryId = 3, CategoryName = "Work"  },
        //        new Category { CategoryId = 4, CategoryName = "Church" }
        //        );

        //    nb.Entity<AddATaskResponse>().HasData(

        //        new AddATaskResponse
        //        {
        //            TaskId = 1,
        //            TaskName = "Vaccuum the living room",
        //            DueDate = "2/10/21",
        //            Quadrant = "4",
        //            Completed = false

        //        },

        //        new AddATaskResponse
        //        {
        //            TaskId = 2,
        //            TaskName = "Shop for Mom's birthday",
        //            DueDate = "2/9/21",
        //            Quadrant = "2",
        //            Completed = false

        //        }

        //        );

        //}
    }
}
