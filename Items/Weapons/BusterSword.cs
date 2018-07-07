using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BorkMod.Items.Weapons
{
	public class BusterSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded sword.");	//The (English) text shown below your weapon's name
		}
		public override void SetDefaults()
		{
			item.damage = 58002850;
			item.melee = true;
			item.width = 75;
			item.height = 72;
			item.useTime = 150;
			item.useAnimation = 50;
			item.useStyle = 1;
			item.knockBack = 128;
			item.value = 15000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this);
//			recipe.SetResult(ItemID.IronBar, 999);
			recipe.AddRecipe();
		}

	}
}