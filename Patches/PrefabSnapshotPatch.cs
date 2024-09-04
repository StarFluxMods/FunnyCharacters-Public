using System.Collections.Generic;
using System.Reflection.Emit;
using HarmonyLib;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using Unity.Burst.Intrinsics;
using UnityEngine;

namespace FunnyCharacters.Patches
{
    [HarmonyPatch(typeof(PrefabSnapshot), "GetCosmeticSnapshot")]
    public class PrefabSnapshotPatch
    {
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            CodeMatcher matcher = new(instructions);
            
            matcher.MatchForward(false, new CodeMatch(OpCodes.Br), new CodeMatch(OpCodes.Ldsfld), new CodeMatch(OpCodes.Ldflda), new CodeMatch(OpCodes.Ldfld), new CodeMatch(OpCodes.Call))
                .Advance(5)
                .Insert(new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(PrefabSnapshotPatch), "AdjustAsNeeded")))
                .Insert(new CodeInstruction(OpCodes.Ldarg_0));
				
            return matcher.InstructionEnumeration();
        }
        
        public static GameObject AdjustAsNeeded(GameObject gameObject, PlayerCosmetic cosmetic)
        {
            if (cosmetic.CosmeticType == Mod.COSMETIC_BACKPACKS)
            {
                gameObject.transform.Rotate(0, -9.75f, 180);
            }
            if (cosmetic.CosmeticType == Mod.COSMETIC_GLASSES)
            {
                gameObject.transform.position += new Vector3(0, 0, -0.74f);
                gameObject.transform.localScale += new Vector3(1f, 1f, 1f);
            }
            if (cosmetic.CosmeticType == Mod.COSMETIC_EYEBROWS || cosmetic.CosmeticType == Mod.COSMETIC_MUSTACHES)
            {
                gameObject.transform.position += new Vector3(-0.044f, 0, -1.045f);
                gameObject.transform.localScale += new Vector3(2f, 2f, 2f);
            }

            return gameObject;
        }
    }
}