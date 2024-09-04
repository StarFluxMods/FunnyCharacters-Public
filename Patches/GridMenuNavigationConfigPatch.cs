using System.Collections.Generic;
using HarmonyLib;
using Kitchen.Modules;
using KitchenData;
using KitchenLib.UI.PlateUp.Grids;
using UnityEngine;

namespace FunnyCharacters.Patches
{
    [HarmonyPatch(typeof(GridMenuNavigationConfig), "Instantiate")]
    public class GridMenuNavigationConfigPatch
    {
        public static Dictionary<CosmeticType, KLGridMenuHatConfig> Configs = new Dictionary<CosmeticType, KLGridMenuHatConfig>
        {
            {
                Mod.COSMETIC_BACKPACKS, new KLGridMenuHatConfig
                {
                    Cosmetics = new List<PlayerCosmetic>(),
                    Icon = Mod.Bundle.LoadAsset<Texture2D>("Backpack")
                }
            },
            {
                Mod.COSMETIC_GLASSES, new KLGridMenuHatConfig
                {
                    Cosmetics = new List<PlayerCosmetic>(),
                    Icon = Mod.Bundle.LoadAsset<Texture2D>("Glasses")
                }
            },
            {
                Mod.COSMETIC_EYEBROWS, new KLGridMenuHatConfig
                {
                    Cosmetics = new List<PlayerCosmetic>(),
                    Icon = Mod.Bundle.LoadAsset<Texture2D>("Eyebrows")
                }
            },
            {
                Mod.COSMETIC_MUSTACHES, new KLGridMenuHatConfig
                {
                    Cosmetics = new List<PlayerCosmetic>(),
                    Icon = Mod.Bundle.LoadAsset<Texture2D>("Mustache")
                }
            },
            {
                CosmeticType.Hat, new KLGridMenuHatConfig
                {
                    Cosmetics = new List<PlayerCosmetic>(),
                    Icon = Mod.Bundle.LoadAsset<Texture2D>("Hat")
                }
            },
            {
                CosmeticType.Outfit, new KLGridMenuHatConfig
                {
                    Cosmetics = new List<PlayerCosmetic>(),
                    Icon = Mod.Bundle.LoadAsset<Texture2D>("Outfit")
                }
            }
        };

        public static GridMenuNavigationConfig gridMenuNavigationConfig = new GridMenuNavigationConfig
        {
            Links = new List<GridMenuConfig>(),
            Icon = Mod.Bundle.LoadAsset<Texture2D>("FCIcon")
        };
        
        private static List<GridMenuConfig> registeredConfigs = new List<GridMenuConfig>(Configs.Values);
        static void Prefix(GridMenuNavigationConfig __instance)
        {
            int found = 0;
            if (__instance.name == "Root")
            {
                foreach (GridMenuConfig config in __instance.Links)
                {
                    if (config.name == "Hats - Page 1" || config.name == "Outfits" || config.name == "Colours - All 2")
                        found++;
                }
            }

            if (found >= 3)
            {
                if (!__instance.Links.Contains(gridMenuNavigationConfig))
                {
                    __instance.Links.Add(gridMenuNavigationConfig);
                    foreach (GridMenuConfig custom in registeredConfigs)
                    {
                        if (!gridMenuNavigationConfig.Links.Contains(custom))
                        {
                            gridMenuNavigationConfig.Links.Add(custom);
                        }
                    }
                }
            }
        }
    }
}