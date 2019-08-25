﻿using employeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeeManagement.Controllers
{
	public class HomeController : Controller

	{
		private readonly IEmployeeRepository _employeeRepository;

		public HomeController(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}
		public string Index()
		{
			return _employeeRepository.GetEmployee(1).Name;
		}
		public ViewResult Details()
		{
			Employee model = _employeeRepository.GetEmployee(1);
			//ViewData["Employee"] = model;
			//ViewData["Page Title"] = "Details of employee";
			ViewBag.Employee = model;
			ViewBag.PageTitle = "Details of employee";
			return View(model);

		}
	}
}
