using Orchard.UI.Resources;

namespace Raptor.Ericka {
    public class ResourceManifest : IResourceManifestProvider {
        public const string BOOTSTRAP_STYLE = "BOOTSTRAP_STYLE";
        public const string BOOTSTRAP_RESPONSIVE_STYLE = "BOOTSTRAP_RESPONSIVE_STYLE";
        public const string CORE_STYLE = "CORE_STYLE";
        public const string CUSTOM_STYLE = "CUSTOM_STYLE";

        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            // core styles
            manifest.DefineStyle(BOOTSTRAP_STYLE).SetUrl("bootstrap.min.css", "bootstrap.min.css");
            manifest.DefineStyle(BOOTSTRAP_RESPONSIVE_STYLE).SetUrl("bootstrap-responsive.min.css", "bootstrap-responsive.min.css");
            manifest.DefineStyle(CORE_STYLE).SetUrl("style.css", "style.css");
            manifest.DefineStyle(CUSTOM_STYLE).SetUrl("theme.css", "theme.css");

            // accent theme
            manifest.DefineStyle("blue.css").SetUrl("blue.css", "blue.css");
            manifest.DefineStyle("brown.css").SetUrl("brown.css", "brown.css");
            manifest.DefineStyle("green.css").SetUrl("green.css", "green.css");
            manifest.DefineStyle("orange.css").SetUrl("orange.css", "orange.css");
            manifest.DefineStyle("pink.css").SetUrl("pink.css", "pink.css");
            manifest.DefineStyle("red.css").SetUrl("red.css", "red.css");
        }
    }
}

