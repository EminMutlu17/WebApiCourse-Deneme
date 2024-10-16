using Contracts;
using System;
using System.Collections.Generic;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private Lazy<IProjectRepository> _projectRepository;
        private Lazy<IEmployeeRepository> _employeeRepository;

        public RepositoryManager(RepositoryContext context, Lazy<IProjectRepository> projectRepository, Lazy<IEmployeeRepository> employeeRepository)
        {
            _context = context;
            _projectRepository = projectRepository;
            _employeeRepository = employeeRepository;
        }

        public IProjectRepository Project => _projectRepository.Value;

        public IEmployeeRepository Employee => _employeeRepository.Value;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
