using KitchenData;

namespace FunnyCharacters.Customs.Abstract
{
    public abstract class CustomHat : BaseFunnyCostume
    {
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override bool BlockHats => true;
    }
    
    public abstract class CustomOutfit : BaseFunnyCostume
    {
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
    }
    
    public abstract class CustomBackpack : BaseFunnyCostume
    {
        public override CosmeticType CosmeticType => Mod.COSMETIC_BACKPACKS;
    }
    
    public abstract class CustomGlasses : BaseFunnyCostume
    {
        public override CosmeticType CosmeticType => Mod.COSMETIC_GLASSES;
    }
    
    public abstract class CustomEyebrows : BaseFunnyCostume
    {
        public override CosmeticType CosmeticType => Mod.COSMETIC_EYEBROWS;
    }
    
    public abstract class CustomMustaches : BaseFunnyCostume
    {
        public override CosmeticType CosmeticType => Mod.COSMETIC_MUSTACHES;
    }
}