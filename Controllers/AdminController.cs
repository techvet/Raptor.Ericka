using System.Web.Mvc;
using Orchard;
using Orchard.Localization;
using Orchard.UI.Notify;
using Raptor.Ericka.ViewModels;
using Raptor.Ericka.Services;

namespace Raptor.Ericka.Controllers {
    [ValidateInput(false)]
    public class AdminController : Controller {
        private readonly IThemeSettingsService _settingsService;

        public AdminController(
            IOrchardServices services,
            IThemeSettingsService settingsService) {
            _settingsService = settingsService;
            Services = services;
            T = NullLocalizer.Instance;
        }

        public IOrchardServices Services { get; set; }
        public Localizer T { get; set; }

        public ActionResult Index() {
            var settings = _settingsService.GetSettings();

            var viewModel = new ThemeSettingsViewModel {
                AccentCss = settings.AccentCss,
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(ThemeSettingsViewModel viewModel) {
            if (!Services.Authorizer.Authorize(Raptor.Ericka.Permissions.ManageThemeSettings, T("Couldn't update Raptor.Ericka settings")))
                return new HttpUnauthorizedResult();

            var settings = _settingsService.GetSettings();
            settings.AccentCss = viewModel.AccentCss;

            Services.Notifier.Information(T("Your settings have been saved."));

            return View(viewModel);
        }
    }
}
