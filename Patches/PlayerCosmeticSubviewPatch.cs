using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;

namespace FunnyCharacters.Patches
{
    [HarmonyPatch(typeof(PlayerCosmeticSubview), "AddAttachment")]
    public class PlayerCosmeticSubviewPatch
    {
        static void Prefix(PlayerCosmeticSubview __instance, PlayerCosmetic cosmetic)
        {
            FieldInfo _AttachmentPoints = ReflectionUtils.GetField<PlayerCosmeticSubview>("AttachmentPoints");
            List<PlayerCosmeticSubview.AttachmentPoint> AttachmentPoints = (List<PlayerCosmeticSubview.AttachmentPoint>)_AttachmentPoints.GetValue(__instance);
            
            foreach (CosmeticType type in GridMenuNavigationConfigPatch.Configs.Keys)
            {
                bool found = false;
                foreach (PlayerCosmeticSubview.AttachmentPoint attachmentPoint in AttachmentPoints)
                {
                    if (attachmentPoint.Type != type) continue;
                    found = true;
                    break;
                }
                if (!found)
                {
                    AttachmentPoints.Add(new PlayerCosmeticSubview.AttachmentPoint
                    {
                        Type = type,
                        Transform = AttachmentPoints[0].Transform
                    });
                }
            }
            
            _AttachmentPoints.SetValue(__instance, AttachmentPoints);
        }
    }
}