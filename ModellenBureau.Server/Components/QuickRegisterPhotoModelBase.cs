using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ModellenBureau.Main.Shared;
using ModellenBureau.Server.Services;

namespace ModellenBureau.Server.Components
{
    public class QuickRegisterPhotoModelBase : ComponentBase
    {
        public bool ShowDialog { get; set; }

        public PhotoModel PhotoModel { get; set; } = new PhotoModel { };

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        [Inject]
        public IPhotoModelDataService PhotoModelDataService { get; set; }



        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            PhotoModel = new PhotoModel { };
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        protected async Task HandleValidSubmit()
        {
            await PhotoModelDataService.AddPhotoModel(PhotoModel);
            ShowDialog = false;

            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
