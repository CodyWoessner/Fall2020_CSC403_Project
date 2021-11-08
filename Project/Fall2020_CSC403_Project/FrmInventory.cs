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

    private void pictureBox12_Click(object sender, EventArgs e)
    {

    }
    private void inventory_slot_1_Click(object sender, EventArgs e)
    {

    }
    private void inventory_slot_1_DoubleClick(object sender, EventArgs e)
    {
      int invSlotIndex = (int)this.Tag;
      player.EquipItem(player.Inventory[invSlotIndex], invSlotIndex);
    }
    private void inventory_slot_1_DragDrop(object sender, EventArgs e)
    {

    }

    private void weapon_slot_DragDrop(object sender, DragEventArgs e)
    {

    }

    private void button1_DragDrop(object sender, DragEventArgs e)
    {

    }
  }
}
