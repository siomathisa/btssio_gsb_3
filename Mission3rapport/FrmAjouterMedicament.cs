using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3rapport
{
    public partial class FrmAjouterMedicament : Form
    {
        private gsb2023Entities mesDonnees;

        public FrmAjouterMedicament(gsb2023Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgSMedicament.DataSource= mesDonnees.medicaments.ToList();
            this.bdgSFamille.DataSource=mesDonnees.familles.ToList();
        }
        private medicament newMedicament()
        {
            medicament newMedicament = new medicament();
            newMedicament.id=Convert.ToString(txtIdMedicament.Text);
            newMedicament.nomCommercial= Convert.ToString(txtNomCommercial.Text);
            famille fa = (famille)comboIdFamille.SelectedValue;
            newMedicament.idFamille = Convert.ToString(fa.id);
            newMedicament.composition= Convert.ToString(txtComposition.Text);
            newMedicament.effets= Convert.ToString(txtEffets.Text);
            newMedicament.contreIndications= Convert.ToString(txtIndication.Text);
            return newMedicament;

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSMedicament.EndEdit();
            try
            {

                
            this.mesDonnees.medicaments.Add(newMedicament());
            this.mesDonnees.SaveChanges();
            MessageBox.Show("Votre médicament a bien été ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification {ex.Message}");
            }
        }

        private void FrmAjouterMedicament_Load(object sender, EventArgs e)
        {

        }
    }
}
