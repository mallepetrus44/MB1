using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using ModellenBureau.Shared;
using ModellenBureau.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Server.Pages
{
    public class CustomerEditBase : ComponentBase
    {
        [Inject]
        public ICustomerDataService CustomerDataService { get; set; }     

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string CustomerId { get; set; }

        public InputText LastNameInputText { get; set; }

        public Customer Customer { get; set; } = new Customer();

        ////needed to bind to select to value
        //protected string CountryId = string.Empty;

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        //public List<Country> Countries { get; set; } = new List<Country>();

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            //Countries = (await CountryDataService.GetAllCountries()).ToList();       

            int.TryParse(CustomerId, out var CustomerID);

            if (CustomerID == 0) //new Customer is being created
            {
                //add some defaults
                Customer = new Customer {};
            }
            else
            {
                Customer = await CustomerDataService.GetCustomerDetails(int.Parse(CustomerId));
            }

            //CountryId = Customer.CountryId.ToString();
            //JobCategoryId = Customer.JobCategoryId.ToString();
        }

        protected async Task HandleValidSubmit()
        {
            //Customer.CountryId = int.Parse(CountryId);
            //Customer.JobCategoryId = int.Parse(JobCategoryId);

            if (Customer.CustomerID == 0) //new
            {
                var addedCustomer = await CustomerDataService.AddCustomer(Customer);
                if (addedCustomer != null)
                {
                    StatusClass = "alert-success";
                    Message = "Nieuwe klant succesvol toegevoegd.";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Er is iets misgegaan tijdens het aanmaken van een nieuwe klant. Probeer het opnieuw.";
                    Saved = false;
                }
            }
            else
            {
                await CustomerDataService.UpdateCustomer(Customer);
                StatusClass = "alert-success";
                Message = "Klantgegevens zijn succesvol bijgewerkt.";
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

        protected async Task DeleteCustomer()
        {
            await CustomerDataService.DeleteCustomer(Customer.CustomerID);

            StatusClass = "alert-success";
            Message = "Deleted successfully";

            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/CustomerOverview");
        }
    }
}