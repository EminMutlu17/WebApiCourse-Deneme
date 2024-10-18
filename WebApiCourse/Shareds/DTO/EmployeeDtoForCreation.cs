namespace Shareds.DTO
{
   
        public record EmployeeDtoForCreation
        {
           
            public string FirstName { get; init; }
            public string LastName { get; init; }

            public int Age { get; init; }

            public string Position { get; init; }
        }
}
