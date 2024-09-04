using FunnyCharacters.Patches;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace FunnyCharacters.Customs.Abstract
{
    public abstract class BaseFunnyCostume : CustomPlayerCosmetic
    {
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>(UniqueNameID).AssignMaterialsByNames();
        public override bool DisableInGame => true;
        
        public override void OnRegister(PlayerCosmetic playerCosmetic)
        {
            PlayerOutfitComponent playerOutfitComponent = playerCosmetic.Visual.AddComponent<PlayerOutfitComponent>();
            if (GameObjectUtils.GetChildObject(playerCosmetic.Visual, UniqueNameID) != null)
                playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, UniqueNameID).GetComponent<SkinnedMeshRenderer>());
            
            if (GridMenuNavigationConfigPatch.Configs.ContainsKey(playerCosmetic.CosmeticType))
                GridMenuNavigationConfigPatch.Configs[playerCosmetic.CosmeticType].Cosmetics.Add(playerCosmetic);
        }
    }
}