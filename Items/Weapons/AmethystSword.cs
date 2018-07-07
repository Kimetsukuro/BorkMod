using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BorkMod.Items.Weapons
{
	public class AmethystSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded sword.");	//The (English) text shown below your weapon's name
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = 40;
			item.height = 60;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 16;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}