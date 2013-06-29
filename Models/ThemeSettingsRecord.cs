namespace Raptor.Ericka.Models {
    public class ThemeSettingsRecord {
        public ThemeSettingsRecord() {
            this.AccentCss = Constants.ACCENT_CSS_DEFAULT;
        }

        public virtual int Id { get; set; }
        public virtual string AccentCss { get; set; }
    }
}