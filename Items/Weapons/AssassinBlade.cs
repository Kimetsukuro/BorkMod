using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BorkMod.Items.Weapons
{
	public class AssassinBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is an assassin's blade.");	//The (English) text shown below your weapon's name
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 20;
			item.height = 5;
			item.useTime = 120;
			item.useAnimation = 10;
			item.useStyle = 3;
			item.knockBack = 1;
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

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add Onfire buff to the NPC for 1 second
			// 60 frames = 1 second
			// player.AddBuff(mod.BuffType<Buffs.Blocky>(), 60, true);
			target.AddBuff(mod.BuffType<Buffs.AssassinsVenom>(), 600);
			// target.AddBuff(BuffID.Cursed, 600);
			// target.AddBuff(BuffID.Poisoned, 600);
			// target.AddBuff(BuffID.Slow, 600);
			// target.AddBuff(BuffID.Weak, 600);
			// target.AddBuff(BuffID.Venom, 600);
			// target.AddBuff(BuffID.OnFire, 60);
		}

	}
}