using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3rapport
{
    public partial class FrmNouvelleFamille : Form
    {
        private gsb2023Entities mesDonnees;
        public FrmNouvelleFamille (gsb2023Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgSFamille.DataSource= mesDonnees.familles.ToList();
  
        }

        private famille newFamille()
        {
            famille newFamille = new famille();
            newFamille.id = Convert.ToString(txtId.Text);
            newFamille.libelle = txtNomFamille.Text;
            return newFamille;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.mesDonnees.familles.Add(newFamille());
            this.mesDonnees.SaveChanges();
            MessageBox.Show("Enregistrement validé");
        }
    }
}
