using Microsoft.AspNetCore.Components;
using ModellenBureau.Shared;
using ModellenBureau.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Server.Components
{
    public class QuickRegisterCustomerBase : ComponentBase
    {
        public bool ShowDialog { get; set; }

        public Customer Customer { get; set; } = new Customer { };

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        [Inject]
        public ICustomerDataService CustomerDataService { get; set; }



        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Customer = new Customer { };
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        protected async Task HandleValidSubmit()
        {
            await CustomerDataService.AddCustomer(Customer);
            ShowDialog = false;

            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
