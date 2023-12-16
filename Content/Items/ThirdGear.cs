using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AventoGears.Content.Items
{
    public class ThirdGear : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;
            Item.accessory = true;
            Item.value = Item.sellPrice(gold: 1000);
            Item.rare = ItemRarityID.Yellow;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 2f;
            player.GetCritChance(DamageClass.Generic) += 1f;
            player.GetAttackSpeed(DamageClass.Generic) += 1f;
            player.statDefense += player.statDefense * 2;
            player.inferno = true;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldBar, 800)
                .AddIngredient(ItemID.PlatinumOre, 1700)
                .AddIngredient(ItemID.Obsidian, 800)
                .AddIngredient(ItemID.PalladiumOre, 300)
                .Register();
        }
    }
}