using FunnyCharacters.Customs.Abstract;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace FunnyCharacters.Customs.FullBody
{
    public class Trash_Can : BaseFunnyCostume
    {
        public override string UniqueNameID => "Trash_Can";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        
        public override void OnRegister(PlayerCosmetic playerCosmetic)
        {
            base.OnRegister(playerCosmetic);
            
            PlayerOutfitComponent playerOutfitComponent = playerCosmetic.Visual.GetComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Trash_can_body").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Trash_can_lid").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Hats.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Trash_can_lid").GetComponent<SkinnedMeshRenderer>());
        }
    }
}