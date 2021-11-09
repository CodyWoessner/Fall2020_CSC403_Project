
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
  public class Item
  {
    public string ItemID;
    public string ItemName;
    public System.Drawing.Bitmap ItemImage;
    public string ItemDesc;
    public string ItemType;
    public Item[] itemList;


    public Item(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "empty")
    {
      this.ItemID = ItemID;
      this.ItemName = ItemName;
      this.ItemImage = ItemImage;
      this.ItemDesc = ItemDesc;
      this.ItemType = ItemType;
    }
  }
  public class Weapon : Item
  {
    public Weapon(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "weapon") : base(ItemID, ItemName, ItemImage, ItemDesc, "weapon")
    {

    }
  }

  public class Consumable : Item
  {
    // private ? ConsAttribute;
    public Consumable(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "consumable") : base(ItemID, ItemName, ItemImage, ItemDesc, "consumable")
    {

    }
  }

  public class Chest : Item
  {
    // private ? ArmorAttribute;
    public Chest(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "chest") : base(ItemID, ItemName, ItemImage, ItemDesc, "chest")
    {

    }
  }
  public class Helmet : Item
  {
    // private ? HelmAttribute;
    public Helmet(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "helmet") : base(ItemID, ItemName, ItemImage, ItemDesc, "helmet")
    {

    }
  }
  public class Shield : Item
  {
    // private ? ShieldAttribute;
    public Shield(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "shield") : base(ItemID, ItemName, ItemImage, ItemDesc, "shield")
    {

    }
  }
  public class Legs : Item
  {
    // private ? LegsAttribute;
    public Legs(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "legs") : base(ItemID, ItemName, ItemImage, ItemDesc, "legs")
    {

    }
  }
  public class Feet : Item
  {
    // private ? FeetAttribute;
    public Feet(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "feet") : base(ItemID, ItemName, ItemImage, ItemDesc, "feet")
    {

    }
  }
}
