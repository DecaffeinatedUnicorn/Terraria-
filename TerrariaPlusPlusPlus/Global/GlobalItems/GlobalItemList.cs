using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TerrariaPlusPlusPlus.Global.Items
{

    public class GlobalItemList : GlobalItem
    {
        public override void SetDefaults(Item item)
        {

            item.autoReuse = true;  // makes all items auto-reuse


            if (item.type == ItemID.MagicMissile)
            {
                item.damage = 9999;
                item.useAnimation = 1;
                item.mana = 1;       // makes magic missile absurdly overpowered  -  remember to turn this off when actually playing - example for how to modify vanilla weapons
            }
        }

    }

}
