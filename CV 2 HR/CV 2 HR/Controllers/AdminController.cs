﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CV_2_HR.Models;
using CV_2_HR.Services;
using Microsoft.AspNetCore.Mvc;

namespace CV_2_HR.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICompanyService _companyService;

        public AdminController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _companyService.GetCompaniesAsync();

            return View(companies);
        }

        public IActionResult AddCompany()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany(Company newCompany)
        {
            if (!ModelState.IsValid)
                return View(newCompany);

            bool succeeded = await _companyService.AddCompanyAsync(newCompany);
            
            if (!succeeded)
            {
                return StatusCode(500);
            }

            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> RemoveCompany(Company removedCompany)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            bool succeeded = await _companyService.RemoveCompanyAsync(removedCompany);

            if (!succeeded)
            {
                return StatusCode(500);
            }

            return RedirectToAction("Index");
        }
    }
}