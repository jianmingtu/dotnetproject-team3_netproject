using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetterBuys.Data;
using BetterBuys.Interfaces;
using BetterBuys.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BetterBuys.Pages.Checkout
{
    public class CheckoutModel : PageModel
    {

        private readonly IProductVMService _productVMService;

        public CheckoutModel(IProductVMService productVMService)
        {
            _productVMService = productVMService;
        }

        public ProductIndexVM ProductIndex { get; set; } = new ProductIndexVM();
        public void OnGet(int? categoryId)
        {
            ProductIndex = _productVMService.GetProductsVM(categoryId);
        }
    }
}