using Raptor.Ericka.Models;
using Orchard;

namespace Raptor.Ericka.Services {
    public interface IThemeSettingsService : IDependency {
        ThemeSettingsRecord GetSettings();
    }
}
