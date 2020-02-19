using System;
using System.Collections.Generic;
using Employee.Entity;
using Employee.repository;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class DefaultController : Controller
    {
        EmployeeRepository employeeDatabase;
        public DefaultController()
        {
            employeeDatabase = new EmployeeRepository();
        }
        // GET: Default
        public ActionResult Index()
        {
            IEnumerable<EmployeeDatabase> employees = employeeDatabase.GetEmployees();
            return View(employees);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeDatabase employee)
        {
            employeeDatabase.AddEmployee(employee);
            TempData["Message"] = "Employee Added Successfully!";
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            employeeDatabase.DeleteEmployee(id);
            TempData["Message"] = "Employee Deleted Successfully!";
            return RedirectToAction("Default");
        }
        public ActionResult Edit(string id)
        {
            EmployeeDatabase employees = employeeDatabase.GetEmployee(id);
            return View(employees);
        }
    }
}