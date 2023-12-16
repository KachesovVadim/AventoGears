using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AventoGears.Content.Items
{
    public class FourthGear : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;
            Item.accessory = true;
            Item.value = Item.sellPrice(gold: 9000);
            Item.rare = ItemRarityID.Purple;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 19f;
            player.GetCritChance(DamageClass.Generic) += 3f;
            player.GetAttackSpeed(DamageClass.Generic) += 3f;
            player.statDefense += player.statDefense * 5;
            player.statLifeMax2 += player.statLifeMax2 * 5;
            player.inferno = true;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.ChlorophyteBar, 300)
                .AddIngredient(ItemID.TitaniumBar, 500)
                .AddIngredient(ItemID.AdamantiteBar, 500)
                .AddIngredient(ItemID.OrichalcumOre, 1000)
                .AddIngredient(ItemID.LifeCrystal, 30)
                .AddIngredient(ItemID.FallenStar, 50)
                .Register();
        }
    }
}