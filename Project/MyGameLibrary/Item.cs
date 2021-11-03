using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code {
  public class Item {
    public string ItemID;
    public string ItemName;
    public System.Drawing.Bitmap ItemImage;
    public string ItemDesc;

    public Item(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc)
    {
      this.ItemID = ItemID;
      this.ItemName = ItemName;
      this.ItemImage = ItemImage;
      this.ItemDesc = ItemDesc;
    }

  }
  public class Weapon : Item
  {
    public int StrMod;
    public Weapon(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc) : base(ItemID, ItemName, ItemImage, ItemDesc)
    {

    } 
  }

  public class Consumable : Item
  {
    // private ? ConsAttribute;
    public Consumable(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc) : base(ItemID, ItemName, ItemImage, ItemDesc)
    {

    }
  }

  public class Armor : Item
  {
    // private ? ArmorAttribute;
    public Armor(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc) : base(ItemID, ItemName, ItemImage, ItemDesc)
    {

    }
  }
}
