﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using employeeManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace employeeManagement
{
	public class Startup
	{
		private IConfiguration _config;

		public Startup(IConfiguration config)
		{
			_config = config;
		}
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
		}


		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			//app.UseDefaultFiles();
			app.UseStaticFiles();
			//app.UseMvcWithDefaultRoute();
			app.UseMvc(routes =>
			{
			routes.MapRoute("default", "niu/{controller=home}/{action=index}/{id?}");
			});
			//app.UseMvc();
			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!!!");
			});
		}
	}
}
