﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Model;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    public class PaymentDetailsController : Controller
    {
        private readonly IPayment _payment;
        private readonly AppDbContext _db;

        public PaymentDetailsController(IPayment payment, AppDbContext db)
        {
            _payment = payment;
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int? id)
        {
            var model = new CreatePaymentDetailsViewModel();

            if (id != null)
            {
                model.PaymentId = id.Value;
                return View(model);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreatePaymentDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                PaymentDetails details = new PaymentDetails
                {
                    PaymentId = model.PaymentId,
                    AmountPaid = model.AmountPaid,
                    Date = model.Date
                };
                _payment.AddPaymentDetail(details);
                return View("Index");
            }
            return View(model);
        }

        // AJAX CALLS
        [HttpPost]
        public JsonResult SaveAjax(PaymentDetailAjaxViewModel model)
        {
            if (ModelState.IsValid)
            {
                PaymentDetails paymentDetail = new PaymentDetails
                {
                    AmountPaid = model.AmountPaid,
                    Date = model.Date,
                    PaymentId = model.PaymentId
                };

                var newDetail = _payment.AddPaymentDetail(paymentDetail);

                if (newDetail == null)
                {
                    return Json(new { success = false, message = "Error while saving" });
                }
                else
                {
                    return Json(new { success = true, message = "Object saved", type = "details", id = model.PaymentId });

                }
            }
            return Json(new { success = false, message = "Invalid Submission" });
        }

        [HttpDelete]
        public async Task<IActionResult> Clear(PaymentDetailAjaxDeleteModel model)
        {
            var detailToDelete = await _db.PaymentDetails.FirstOrDefaultAsync(pd => pd.PaymentId == model.PaymentId && pd.Id == model.Id);

            if (detailToDelete == null)
            {
                return Json(new { success = false, message = "Error while deletiing" });
            }
            _db.PaymentDetails.Remove(detailToDelete);
            await _db.SaveChangesAsync();

            return Json(new { success = true, message = "Delete Successful" });
        }

        [HttpGet]
        public async Task<IActionResult> StudentPaymentdetails(int id)
        {

            var list = await _db.PaymentDetails.Where(pd => pd.PaymentId == id).ToListAsync();

            return Json(new { data = list });
        }
    }
}
