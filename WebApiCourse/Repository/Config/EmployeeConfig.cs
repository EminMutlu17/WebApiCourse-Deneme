using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee()
                {

                    Id = new Guid("6595d486-6a51-49c3-b4a3-b55f432f2a61"), // Boşluk kaldırıldı
                    ProjectId = new Guid("a88e2ba1-f7cc-4d6b-a995-69575dc7e8b7"),
                    FirstName = "Emre",
                    LastName = "CEVİK",
                    Age = 24,
                    Position = "Junior Developer"


                },
                  new Employee()
                  {

                      Id = new Guid("d66f8e6b-b499-4f68-8595-afeb4d95a5db"),
                      ProjectId = new Guid("f98e1ba1-f7cc-4d6b-a995-69575dc7e8b7"),
                      FirstName = "Taner",
                      LastName = "Bilinmiyor",
                      Age = 23,
                      Position = "Mid Developer"


                  },
                  new Employee()
                  {

                      Id = new Guid("e47a2f9b-7e6a-4b4e-bf78-d9e8e2d5cbb3"),
                      ProjectId = new Guid("f98e1ba1-f7cc-4d6b-a995-69575dc7e8b7"),
                      FirstName = "Ali",
                      LastName = "Midci",
                      Age = 31,
                      Position = "Mid Developer"


                  }

                );
        }
    }
}
