using System.Linq;
using Orchard.Data;
using Raptor.Ericka.Models;

namespace Raptor.Ericka.Services {
    public class SettingsService : IThemeSettingsService {
        private readonly IRepository<ThemeSettingsRecord> _repository;

        public SettingsService(IRepository<ThemeSettingsRecord> repository) {
            _repository = repository;
        }

        public ThemeSettingsRecord GetSettings() {
            var settings = _repository.Table.SingleOrDefault();
            if (settings == null) {
                _repository.Create(settings = new ThemeSettingsRecord());
            }

            return settings;
        }
    }
}
