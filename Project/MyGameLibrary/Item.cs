
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

  public class Armor : Item
  {
    // private ? ArmorAttribute;
    public Armor(string ItemID, string ItemName, System.Drawing.Bitmap ItemImage, string ItemDesc, string ItemType = "armor") : base(ItemID, ItemName, ItemImage, ItemDesc, "armor")
    {

    }
  }
}
