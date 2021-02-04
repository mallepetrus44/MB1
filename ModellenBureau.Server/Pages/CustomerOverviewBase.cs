using Microsoft.AspNetCore.Components;
using ModellenBureau.Main.Shared;
using ModellenBureau.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Server.Pages
{
    public class CustomerOverviewBase : ComponentBase
    {
        [Inject]
        public ICustomerDataService CustomerDataService { get; set; }
        public List<Customer> Customers { get; set; }

        //protected AddCustomerDialog AddCustomerDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Customers = (await CustomerDataService.GetAllCustomers()).ToList();
        }
    }
}
