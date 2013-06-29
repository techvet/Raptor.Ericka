using Orchard.Data.Migration;

namespace Raptor.Ericka {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("ThemeSettingsRecord", table => table
                .Column<int>("Id", column => column.PrimaryKey().Identity())
                .Column<string>("AccentCss", c => c.WithLength(50).WithDefault(Constants.ACCENT_CSS_DEFAULT))
            );

            return 1;
        }
    }
}