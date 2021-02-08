using Microsoft.AspNetCore.Components;
using ModellenBureau.Main.Shared;
using ModellenBureau.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Server.Pages
{
    public class CustomerDetailBase : ComponentBase
    {
        [Inject]
        public ICustomerDataService CustomerDataService { get; set; }

        [Parameter]
        public string CustomerId { get; set; }

        public Customer Customer { get; set; } = new Customer();

        protected override async Task OnInitializedAsync()
        {
            Customer = await CustomerDataService.GetCustomerDetails(int.Parse(CustomerId));

        }
    }
}
