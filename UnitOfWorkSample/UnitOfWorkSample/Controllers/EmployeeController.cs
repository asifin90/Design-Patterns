using Microsoft.AspNetCore.Mvc;
using RepoWithUnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkSample.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork repo;

        public EmployeeController(IUnitOfWork _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var data = repo.emps.Get();
            repo.emps.Add(new Models.Employee() { Name = "Asif", Address = "Pune", Contact = 9663589 });
            repo.depts.Add(new Models.Department() { Name = "IT"});
            repo.SaveDatabase();
            return View();
        }
    }
}
