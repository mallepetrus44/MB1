using Microsoft.AspNetCore.Components;
using ModellenBureau.Main.Shared;
using ModellenBureau.Server.Components;
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

        protected QuickRegisterCustomer QuickRegisterCustomer { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Customers = (await CustomerDataService.GetAllCustomers()).ToList();
        }

        public async void QuickRegisterCustomer_OnDialogClose()
        {
            Customers = (await CustomerDataService.GetAllCustomers()).ToList();
            StateHasChanged();
        }

        protected void QuickAddCustomer()
        {
            QuickRegisterCustomer.Show();
        }
    }
}
