using Mission3rapport;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmGererMedoc : Form
    {
        private gsbrapports2023Entities mesDonnees;

        public FrmGererMedoc(gsbrapports2023Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
    
            this.bdgGereMedoc.DataSource = mesDonnees.familles.ToList();
        }

        // Supprimez le deuxième appel à InitializeComponent() dans le bouton2_Click
        private void button2_Click(object sender, EventArgs e)
        {
            famille selectFamille = comboBox1.SelectedItem as famille;
            famille selectFamille2 = comboBox1.SelectedItem as famille;

            if (selectFamille != null)
            {
                var query = from medicament in mesDonnees.medicaments
                            where medicament.famille.id == selectFamille.id
                            select medicament;

                var query2 = from offrir in mesDonnees.offrirs
                             where offrir.medicament.famille.id == selectFamille.id
                             select  offrir;




                // Convertir les résultats en liste
                var listeMedicaments = query.ToList();
                var listeMedicaments2 = query2.ToList();

                ListeMedicament lstMedoc = Application.OpenForms["ListeMedicament"] as ListeMedicament;
                
                if (lstMedoc != null)
                {
                    // Mettre à jour directement la source de données du DataGridView
                    lstMedoc.MettreAJourMedicaments(listeMedicaments);
                    lstMedoc.MettreAJourMedicamentsOfferts(listeMedicaments2);

                }
                else
                {
                    lstMedoc = new ListeMedicament(mesDonnees);
                    lstMedoc.MettreAJourMedicaments(listeMedicaments);
                    lstMedoc.MettreAJourMedicamentsOfferts(listeMedicaments2);
                    lstMedoc.Show();
                }


            }



            
        }


        private void btnAjouter_Click_1(object sender, EventArgs e)
        {

            FrmNouvelleFamille F2 = new FrmNouvelleFamille(this.mesDonnees);
            F2.Show();
        }

        private void FrmGererMedoc_Load(object sender, EventArgs e)
        {

        }
    }


}