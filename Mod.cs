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
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.1.9";
        
        public List<string> list = new List<string>();

        internal static CosmeticType COSMETIC_GLOVES = (CosmeticType)VariousUtils.GetID("Cosmetic_Gloves");
        internal static CosmeticType COSMETIC_BACKPACKS = (CosmeticType)VariousUtils.GetID("Cosmetic_Backpacks");
        internal static CosmeticType COSMETIC_GLASSES = (CosmeticType)VariousUtils.GetID("Cosmetic_Glasses");
        internal static CosmeticType COSMETIC_EYEBROWS = (CosmeticType)VariousUtils.GetID("Cosmetic_Eyebrows");
        internal static CosmeticType COSMETIC_MUSTACHES = (CosmeticType)VariousUtils.GetID("Cosmetic_Mustaches");

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        public void add(string id)
        {
            list.Add("");
            list.Add($"public class Hat_{id} : CustomHat");
            list.Add("{");
            list.Add($"    public override string UniqueNameID => \"Hat_{id}\";");
            list.Add("}");
        }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");

            add("001");
            add("002");
            add("003");
            add("004");
            add("005");
            add("006");
            add("007");
            add("008");
            add("009");
            add("010");
            add("011");
            add("012");
            add("013");
            add("014");
            add("015");
            add("016");
            add("017");
            add("018");
            add("019");
            add("020");
            add("021");
            add("022");
            add("023");
            add("024");
            add("025");
            add("026");
            add("027");
            add("028");
            add("029");
            add("030");
            add("031");
            add("032");
            add("033");
            add("034");
            add("035");
            add("036");
            add("037");
            add("038");
            add("039");
            add("040");
            add("041");
            add("042");
            add("043");
            add("044");
            add("045");
            add("046");
            add("047");
            add("048");
            add("049");
            add("050");
            add("051");
            add("052");
            add("053");
            add("054");
            add("055");
            add("056");
            add("057");
            add("058");
            add("059");
            add("060");
            add("061");
            add("062");
            add("063");
            add("064");
            add("065");
            add("066");
            add("067");
            add("068");
            add("069");
            add("070");
            add("071");
            add("072");
            add("073");
            add("074");
            add("075");
            add("076");
            add("077");
            add("078");
            add("079");
            add("080");
            add("081");
            add("082");
            add("083");
            add("084");
            add("085");
            add("086");
            add("087");
            add("088");
            add("089");
            add("090");
            add("091");
            add("092");
            add("093");
            add("094");
            add("095");
            add("096");
            add("097");
            add("098");
            add("099");
            add("100");
            
            System.IO.File.WriteAllLines("C:/Users/Pilch/Desktop/CustomHats.cs", list);
            
            /*
            foreach (PlayerCosmetic playerCosmetic in GameData.Main.Get<PlayerCosmetic>())
            {
                if (GridMenuNavigationConfigPatch.Configs.ContainsKey(playerCosmetic.CosmeticType))
                    GridMenuNavigationConfigPatch.Configs[playerCosmetic.CosmeticType].Cosmetics.Add(playerCosmetic);
            }
            */
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();
        }
    }
}