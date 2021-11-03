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
        public Item[] itemList;
        public FrmInventory()
        {
            InitializeComponent();
        }
    private void FrmInventory_Load(object sender, EventArgs e)
    {
      /*const int NUM_ITEMS = 3;
      itemList = new Item[NUM_ITEMS];
      itemList[0] = new Item("empty", "nothing", global::Fall2020_CSC403_Project.Properties.Resources.empty, "nada");
      itemList[1] = new Weapon("peanut_cane", "Mr. Peanut's Cane", global::Fall2020_CSC403_Project.Properties.Resources.cane, "A crude bludgeoning weopon.");
      itemList[2] = new Weapon("cheeto_knives", "Flamin' Hot Blades", global::Fall2020_CSC403_Project.Properties.Resources.flamin_hot_blades, "Hot to the touch.");*/
    }
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

    private void weapon_slot_DragDrop(object sender, EventArgs e)
    {
          
    }

    private void feet_slot_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox12_Click(object sender, EventArgs e)
    {

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
