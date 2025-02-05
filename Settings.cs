/*using ModSettings.Core;
using Timberborn.Modding;
using Timberborn.SettingsSystem;

namespace SpeedConfig
{
    internal class Settings : ModSettingsOwner
    {
        public ModSetting<int> Speed1Setting { get; } =
            new ModSetting<int>(1, ModSettingDescriptor.CreateLocalized("Ximsa.SpeedConfig.Speed1"));

        public ModSetting<int> Speed2Setting { get; } =
            new ModSetting<int>(3, ModSettingDescriptor.CreateLocalized("Ximsa.SpeedConfig.Speed2"));

        public ModSetting<int> Speed3Setting { get; } =
            new ModSetting<int>(7, ModSettingDescriptor.CreateLocalized("Ximsa.SpeedConfig.Speed3"));

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
*/