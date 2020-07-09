using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment2.MyEntities;
using Assignment2.Repositories;

namespace Assignment2.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository _repo = new CustomerRepository();
   
        [Route("GetAll")]
        // GET: CustomerController
        public ActionResult Index()
        {
            List<Customer> list = _repo.GetCustomers();
            return View(list);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {
            Customer e = _repo.GetCustomerById(id);
            return View(e);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Add(item);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(string id)
        {
            Customer e = _repo.GetCustomerById(id);
            return View(e);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer item)
        {
            try
            {
                _repo.Update(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(string id)
        {
            Customer e = _repo.GetCustomerById(id);
            return View(e);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer item)
        {
            try
            {
                _repo.Delete(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
