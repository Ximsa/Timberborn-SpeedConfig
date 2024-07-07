using System;
using HarmonyLib;
using Timberborn.TimeSpeedButtonSystem;
using UnityEngine.UIElements;
using System.Collections.Generic;
using ModSettings;

namespace SpeedConfig
{
    [HarmonyPatch(typeof(TimeSpeedButtonFactory))]
    class TimeSpeedButtonFactoryPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Create")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Nicht verwendete private Member entfernen", Justification = "Harmony")]
        static bool CreatePrefix(ref Button button)
        {
            if (!int.TryParse(button.name.Replace("Speed", ""), out int timeSpeed))
            {
                throw new ArgumentException("Unable to parse speed value for " + button.name);
            }
            string updatedName = "Speed";
            switch (timeSpeed)
            {
                case 1:
                    updatedName += SettingsInstance.settings.Speed1Setting.Value;
                    break;
                case 3:
                    updatedName += SettingsInstance.settings.Speed2Setting.Value;
                    break;
                case 7:
                    updatedName += SettingsInstance.settings.Speed3Setting.Value;
                    break;
                case 0:
                default:
                    updatedName = button.name;
                    break;
            }
            button.name = updatedName;
            return true;
        }

    }
}
