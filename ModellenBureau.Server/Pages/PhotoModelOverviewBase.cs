using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ModellenBureau.Main.Shared;
using ModellenBureau.Server.Components;
using ModellenBureau.Server.Services;

namespace ModellenBureau.Server.Pages
{
    public class PhotoModelOverviewBase : ComponentBase
    {
        [Inject]
        public IPhotoModelDataService PhotoModelDataService { get; set; }
        public List<PhotoModel> PhotoModels { get; set; }

        protected QuickRegisterPhotoModel QuickRegisterPhotoModel { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PhotoModels = (await PhotoModelDataService.GetAllPhotoModels()).ToList();
        }

        public async void QuickRegisterPhotoModel_OnDialogClose()
        {
            PhotoModels = (await PhotoModelDataService.GetAllPhotoModels()).ToList();
            StateHasChanged();
        }

        protected void QuickAddPhotoModel()
        {
            QuickRegisterPhotoModel.Show();
        }
    }
}
