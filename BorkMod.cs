using System;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;

namespace BorkMod
{
	public class BorkMod : Mod
	{
		public BorkMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
				AutoloadBackgrounds = true
			};
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DirtBlock);
//			recipe.SetResult("BorkMod:Items:Weapons:OpSword", 1);
			recipe.SetResult(ItemID.Silk, 999);
			recipe.AddRecipe();
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DirtBlock);
//			recipe.SetResult("BorkMod:Weapons:TestSword", 1);
			recipe.SetResult(ItemID.IronBar, 999);
			recipe.AddRecipe();
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(ItemID.WormScarf);
			recipe.AddRecipe();
		}
	}
}

