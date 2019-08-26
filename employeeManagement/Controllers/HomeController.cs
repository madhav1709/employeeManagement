using employeeManagement.Models;
using employeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeeManagement.Controllers
{
	//[Route("[controller]/[action]")]
	public class HomeController : Controller

	{
		private readonly IEmployeeRepository _employeeRepository;

		public HomeController(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		//[Route("")]
		//[Route("~/")]
		
		public ViewResult Index()
		{
			var model =  _employeeRepository.GetAllEmployee();
			return View(model);
		}

		//[Route("{id?}")]
		public ViewResult Details(int? id)
		{
			HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
			{
				Employee = _employeeRepository.GetEmployee(id??1),
				PageTitle = "Employee Details"
				

			};

			//Employee model = _employeeRepository.GetEmployee(1);
			//ViewData["Employee"] = model;
			//ViewData["Page Title"] = "Details of employee";
			//ViewBag.Employee = model;
			//ViewBag.PageTitle = "Details of employee";
			return View(homeDetailsViewModel);

		}
	}
}
