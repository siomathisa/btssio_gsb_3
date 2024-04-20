using Mission3rapport;
using System;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmMenu : Form
    {
        private gsbrapports2023Entities mesDonnees;
        public FrmMenu()
        {
            this.InitializeComponent();
            this.mesDonnees = new gsbrapports2023Entities();
            this.IsMdiContainer = true;
        }



        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererMedoc F2 = new FrmGererMedoc(this.mesDonnees);
            F2.MdiParent = this;
            F2.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
