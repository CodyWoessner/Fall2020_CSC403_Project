using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
  public partial class FrmInventory : Form
  {
    //public static FrmInventory instance = null;
    private Player player;
    public FrmInventory()
    {
      InitializeComponent();
      player = Game.player;
    }
    private void FrmInventory_Load(object sender, EventArgs e)
    {
      UpdateInventory();
    }
    private void UpdateInventory()
    {
      head_slot.Image = player.Equipment[0].ItemImage;
      weapon_slot.Image = player.Equipment[1].ItemImage;
      chest_slot.Image = player.Equipment[2].ItemImage;
      shield_slot.Image = player.Equipment[3].ItemImage;
      legs_slot.Image = player.Equipment[4].ItemImage;
      feet_slot.Image = player.Equipment[5].ItemImage;

      inventory_slot_1.Image = player.Inventory[0].ItemImage;
      inventory_slot_2.Image = player.Inventory[1].ItemImage;
      inventory_slot_3.Image = player.Inventory[2].ItemImage;
      inventory_slot_4.Image = player.Inventory[3].ItemImage;
      inventory_slot_5.Image = player.Inventory[4].ItemImage;
      inventory_slot_6.Image = player.Inventory[5].ItemImage;
      inventory_slot_7.Image = player.Inventory[6].ItemImage;
      inventory_slot_8.Image = player.Inventory[7].ItemImage;
      inventory_slot_9.Image = player.Inventory[8].ItemImage;
      inventory_slot_10.Image = player.Inventory[9].ItemImage;
      inventory_slot_11.Image = player.Inventory[10].ItemImage;
      inventory_slot_12.Image = player.Inventory[11].ItemImage;
      inventory_slot_13.Image = player.Inventory[12].ItemImage;
      inventory_slot_14.Image = player.Inventory[13].ItemImage;
      inventory_slot_15.Image = player.Inventory[14].ItemImage;
      inventory_slot_16.Image = player.Inventory[15].ItemImage;

      this.toolTip1.SetToolTip(this.inventory_slot_1, player.Inventory[0].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_2, player.Inventory[1].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_3, player.Inventory[2].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_4, player.Inventory[3].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_5, player.Inventory[4].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_6, player.Inventory[5].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_7, player.Inventory[6].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_8, player.Inventory[7].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_9, player.Inventory[8].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_10, player.Inventory[9].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_11, player.Inventory[10].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_12, player.Inventory[11].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_13, player.Inventory[12].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_14, player.Inventory[13].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_15, player.Inventory[14].ItemDesc);
      this.toolTip1.SetToolTip(this.inventory_slot_16, player.Inventory[15].ItemDesc);
    }
    /*    public static FrmInventory GetInstance()
        {
          if (instance == null)
          {
            instance = new FrmInventory();
            instance.FrmInventory_Load();
          }
          return instance;
        }*/
    private void head_slot_Click(object sender, EventArgs e)
    {

    }

    private void chest_slot_Click(object sender, EventArgs e)
    {

    }

    private void legs_slot_Click(object sender, EventArgs e)
    {

    }

    private void shield_slot_Click(object sender, EventArgs e)
    {

    }

    private void weapon_slot_Click(object sender, EventArgs e)
    {

    }

    private void feet_slot_Click(object sender, EventArgs e)
    {

    }

    private void inventory_slot_1_Click(object sender, EventArgs e)
    {
      
    }
    private void inventory_slot_1_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 0;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_2_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 1;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_3_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 2;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_4_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 3;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_5_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 4;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_6_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 5;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_7_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 6;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_8_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 7;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_9_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 8;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_10_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 9;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_11_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 10;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_12_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 11;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_13_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 12;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_14_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 13;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_15_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 14;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_16_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 15;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
    private void inventory_slot_1_MouseHover(object sender, EventArgs e)
    {
      
    }

    private void toolTip1_Draw(System.Object sender, System.Windows.Forms.DrawToolTipEventArgs e)
    {
      e.DrawBackground();
      e.DrawBorder();
      e.DrawText();
    }

    private void weapon_slot_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 1;
      player.UnequipItem(player.Equipment[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }

    private void head_slot_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 0;
      player.UnequipItem(player.Equipment[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }

    private void chest_slot_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 2;
      player.UnequipItem(player.Equipment[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }

    private void shield_slot_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 3;
      player.UnequipItem(player.Equipment[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }

    private void legs_slot_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 4;
      player.UnequipItem(player.Equipment[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }

    private void feet_slot_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = 5;
      player.UnequipItem(player.Equipment[invSlotIndex], invSlotIndex);
      UpdateInventory();
    }
  }
}
