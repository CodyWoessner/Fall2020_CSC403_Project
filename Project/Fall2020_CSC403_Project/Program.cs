using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project;

namespace Fall2020_CSC403_Project {
    public partial class FrmMenu : Form
    {
        public bool tester { get; private set; }
        private FrmLevel frmLevel;
        public static FrmMenu instance = null;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // play button
            instance = null;
            tester = true;
            Close();
            //frmLevel = FrmLevel.FrmLevel_Load(sender, e);
            //frmLevel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // quit button
            instance = null;
            Close();
        }
    }
    static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      FrmMenu frmmenu = new FrmMenu();
      Application.Run(frmmenu);

      if (frmmenu.tester)
        {
            Application.Run(new FrmLevel());
        }
      else
            {
                Application.Run(new FrmMenu());
            }
      }

  }
}
