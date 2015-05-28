using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ARM_IV_Test.Domain.Entities;
using ARM_IV_Test.Notification;

namespace ARM_IV_Test.Controllers
{
    public class CustomerPricingQueryController : Controller
    {
        
        // GET: /CustomerPricingQuery/
        [HttpGet]
        public ActionResult Create()
        {
            var _model = new ARM_IV_Test.Models.CustomerPricingQueryModel();
            _model.SelectedProducts = new string[]{};
            _model.Products = mockGetAllProducts();

            return View(_model);
        }

        // POST: /CustomerPricingQuery/
        [HttpPost]
        public ActionResult Create(ARM_IV_Test.Models.CustomerPricingQueryModel model)
        {
            try
            {
                // TODO: Add insert logic here
                // injecting the concrete notification 
                var notification = new SendEmail();
                var domainCustomerPricingQuery = new CustomerPricingQuery(notification);
                //would normally use a mapper tool here
                domainCustomerPricingQuery.FirstName = model.FirstName;
                domainCustomerPricingQuery.LastName = model.LastName;
                domainCustomerPricingQuery.Address1 = model.Address1;
                domainCustomerPricingQuery.City = model.City;
                domainCustomerPricingQuery.Postcode = model.Postcode;
                domainCustomerPricingQuery.Country = model.Country;
                domainCustomerPricingQuery.Products = model.SelectedProducts;

                domainCustomerPricingQuery.Save();  //save and notify
               

                return RedirectToAction("Create");
            }
            catch
            {
                //log the exception
                //but for now just go back to the view
                //clear the errors and go back to the view
                // errors may be because of email setup in this mock code
                foreach (var modelValue in ModelState.Values)
                {
                    modelValue.Errors.Clear();
                }

                var _model = new ARM_IV_Test.Models.CustomerPricingQueryModel();
                _model.SelectedProducts = new string[] { };
                _model.Products = mockGetAllProducts();
                
                return View(_model);
            }
        }


        private IEnumerable<SelectListItem> mockGetAllProducts()
        {
            List<SelectListItem> allProducts = new List<SelectListItem>();

            //make up some products
            allProducts.Add(new SelectListItem { Value = "1", Text = "First Product AMR designed" });
            allProducts.Add(new SelectListItem { Value = "2", Text = "Second Product AMR designed" });
            allProducts.Add(new SelectListItem { Value = "3", Text = "Third Product AMR designed" });
            allProducts.Add(new SelectListItem { Value = "4", Text = "Forth Product AMR designed" });
            return allProducts.AsEnumerable();
        }
    }
}
