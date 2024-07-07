using HarmonyLib;
using System;
using Timberborn.ModManagerScene;

namespace SpeedConfig
{
    public class Plugin: IModStarter
    {
        public void StartMod()
        {
            Console.WriteLine("Hello SpeedConfig!");
            Harmony harmony = new Harmony("speedconfig");
            harmony.PatchAll();
        }
    }
}
