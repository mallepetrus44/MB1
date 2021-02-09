using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ModellenBureau.Shared;
using ModellenBureau.Server.Services;

namespace ModellenBureau.Server.Pages
{
    public class PhotoModelDetailBase : ComponentBase
    {
        [Inject]
        public IPhotoModelDataService PhotoModelDataService { get; set; }

        [Parameter]
        public string PhotoModelId { get; set; }

        public PhotoModel PhotoModel { get; set; } = new PhotoModel();

        protected override async Task OnInitializedAsync()
        {
            PhotoModel = await PhotoModelDataService.GetPhotoModelDetails(int.Parse(PhotoModelId));
        }
    }
}
