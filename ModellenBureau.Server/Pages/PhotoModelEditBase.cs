using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using ModellenBureau.Main.Shared;
using ModellenBureau.Server.Services;

namespace ModellenBureau.Server.Pages
{
    public class PhotoModelEditBase : ComponentBase
    {
        [Inject]
        public IPhotoModelDataService PhotoModelDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string PhotoModelId { get; set; }

        public InputText LastNameInputText { get; set; }

        public PhotoModel PhotoModel { get; set; } = new PhotoModel();

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

            int.TryParse(PhotoModelId, out var PhotoModelID);

            if (PhotoModelID == 0) //new Customer is being created
            {
                //add some defaults
                PhotoModel = new PhotoModel { };
            }
            else
            {
                PhotoModel = await PhotoModelDataService.GetPhotoModelDetails(int.Parse(PhotoModelId));
            }

            //CountryId = Customer.CountryId.ToString();
            //JobCategoryId = Customer.JobCategoryId.ToString();
        }

        protected async Task HandleValidSubmit()
        {
            //Customer.CountryId = int.Parse(CountryId);
            //Customer.JobCategoryId = int.Parse(JobCategoryId);

            if (PhotoModel.PhotoModelID == 0) //new
            {
                var addedPhotoModel = await PhotoModelDataService.AddPhotoModel(PhotoModel);
                if (addedPhotoModel != null)
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
                await PhotoModelDataService.UpdatePhotoModel(PhotoModel);
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
            await PhotoModelDataService.DeletePhotoModel(PhotoModel.PhotoModelID);

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
