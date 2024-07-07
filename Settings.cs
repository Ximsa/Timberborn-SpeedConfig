using ModSettings;
using Timberborn.Modding;
using Timberborn.SettingsSystem;

namespace SpeedConfig
{
    internal class Settings : ModSettingsOwner
    {
        public ModSetting<int> Speed1Setting { get; } =
            new ModSetting<int>("Ximsa.SpeedConfig.Speed1", 1);

        public ModSetting<int> Speed2Setting { get; } =
            new ModSetting<int>("Ximsa.SpeedConfig.Speed2", 3);

        public ModSetting<int> Speed3Setting { get; } =
            new ModSetting<int>("Ximsa.SpeedConfig.Speed3", 7);

        public Settings(ISettings settings,
                        ModSettingsOwnerRegistry modSettingsOwnerRegistry,
                        ModRepository modRepository) : base(
            settings, modSettingsOwnerRegistry, modRepository)
        {
            SettingsInstance.settings = this;
        }

        public override string HeaderLocKey => "Ximsa.SpeedConfig.SpeedConfigHeader";
        protected override string ModId => "Ximsa.SpeedConfig";

    }
    static class SettingsInstance
    {
        public static Settings settings;
    }
}
