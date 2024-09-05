using System.Collections.Generic;
using KitchenLib;
using KitchenLib.Logging.Exceptions;
using KitchenMods;
using System.Linq;
using System.Reflection;
using FunnyCharacters.Patches;
using KitchenData;
using KitchenLib.Interfaces;
using KitchenLib.Utils;
using UnityEngine;
using KitchenLogger = KitchenLib.Logging.KitchenLogger;

/*
 * Backpack Icon - https://www.svgrepo.com/svg/532902/backpack - https://www.svgrepo.com/page/licensing/#CC%20Attribution (Thinning)
 * Hat Witch Icon - https://www.svgrepo.com/svg/532646/hat-witch - https://www.svgrepo.com/page/licensing/#CC%20Attribution
 */

namespace FunnyCharacters
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.funnycharacters";
        public const string MOD_NAME = "Funny Characters";
        public const string MOD_VERSION = "0.1.1";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.1.9";

        internal static CosmeticType COSMETIC_GLOVES = (CosmeticType)VariousUtils.GetID("Cosmetic_Gloves");
        internal static CosmeticType COSMETIC_BACKPACKS = (CosmeticType)VariousUtils.GetID("Cosmetic_Backpacks");
        internal static CosmeticType COSMETIC_GLASSES = (CosmeticType)VariousUtils.GetID("Cosmetic_Glasses");
        internal static CosmeticType COSMETIC_EYEBROWS = (CosmeticType)VariousUtils.GetID("Cosmetic_Eyebrows");
        internal static CosmeticType COSMETIC_MUSTACHES = (CosmeticType)VariousUtils.GetID("Cosmetic_Mustaches");

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();
        }
    }
}