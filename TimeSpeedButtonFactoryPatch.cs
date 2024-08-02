using System;
using HarmonyLib;
using Timberborn.TimeSpeedButtonSystem;
using UnityEngine.UIElements;
using System.Collections.Generic;

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
            button.name = "Speed" + new Dictionary<int,int> (){ 
                { 1, SettingsInstance.settings.Speed1Setting.Value },
                { 3, SettingsInstance.settings.Speed2Setting.Value },
                { 7, SettingsInstance.settings.Speed3Setting.Value }}
            .GetValueOrDefault(timeSpeed,timeSpeed);
            return true;
        }
    }
}
