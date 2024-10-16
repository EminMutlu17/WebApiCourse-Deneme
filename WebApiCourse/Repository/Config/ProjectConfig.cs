using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                new Project
                {
                    ID = new Guid("f98e1ba1-f7cc-4d6b-a995-69575dc7e8b7"),
                    Name = "Asp.Net Core Web API Project 1",
                    Description = "Web Application Programming Interface",
                    Field = "Computer Science"
                },
                new Project
                {
                    ID = new Guid("a88e2ba1-f7cc-4d6b-a995-69575dc7e8b7"), // Yeni bir GUID
                    Name = "Asp.Net Core Web API Project 2",
                    Description = "Another Web Application Programming Interface",
                    Field = "Information Technology"

                });
            
               
        }
    }
}
