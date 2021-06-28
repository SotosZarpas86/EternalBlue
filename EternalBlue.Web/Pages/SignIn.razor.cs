using Blazored.SessionStorage;
using EternalBlue.Web.Models;
using Microsoft.AspNetCore.Components;

namespace EternalBlue.Web.Pages
{
    public partial class SignIn
    {
        private SignInModel SignInModel { get; set; } = new();

        [Inject]
        protected ISyncSessionStorageService SessionStorageService { get; set; }

        protected bool IsMainPageDisplayed { get; set; } = true;

        protected bool IsTwoStepAuthenticationDisplayed { get; set; }

        protected bool IsDownloadDisplayed { get; set; }

        protected override void OnInitialized()
        {
            var isTwoStepAuthenticationPage = SessionStorageService.GetItem<bool>("TwoStepAuthenticationPage");
            if (isTwoStepAuthenticationPage)
            {
                IsMainPageDisplayed = false;
                IsTwoStepAuthenticationDisplayed = true;
            }
            var isDownloadPage = SessionStorageService.GetItem<bool>("DownloadPage");
            if (isDownloadPage)
            {
                IsTwoStepAuthenticationDisplayed = false;
                IsDownloadDisplayed = true;
            }
            base.OnInitialized();
        }

        private void HandleMainPageValidSubmit()
        {
            if (SignInModel.Passowrd.Equals("blueb1ueBlue"))
            {
                SessionStorageService.SetItem("TwoStepAuthenticationPage", true);
                IsMainPageDisplayed = false;
                IsTwoStepAuthenticationDisplayed = true;
            }
        }

        private void HandleTwoStepAuthenticationValidSubmit()
        {
            if (SignInModel.Passowrd.Equals("blue1sF0rev3r"))
            {
                SessionStorageService.SetItem("DownloadPage", true);
                IsTwoStepAuthenticationDisplayed = false;
                IsDownloadDisplayed = true;
            }
        }
    }
}
