using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Mission3rapport
{
    public partial class ListeMedicament : Form
    {
        private gsbrapports2023Entities mesDonnees;
        private string familleSelectionnee;

        public ListeMedicament(gsbrapports2023Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgMedicament.DataSource = mesDonnees.medicaments.ToList();
            this.bdgMedocOfferts.DataSource = mesDonnees.offrirs.ToList();

            this.familleSelectionnee = "";
        }

        public void MettreAJourMedicaments(List<medicament> medicaments)
        {
            this.dListeMedicaments.DataSource = medicaments;
        }

        public void MettreAJourMedicamentsOfferts(List<offrir> offrir)
        {
            this.dMedicamentsOfferts.DataSource = offrir;

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgMedicament.EndEdit();
            this.mesDonnees.SaveChanges();
            MessageBox.Show("Enregistrement validé");

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterMedicament F2 = new FrmAjouterMedicament(this.mesDonnees);
            F2.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Stockez la famille sélectionnée avant la suppression
            string familleAvantSuppression = familleSelectionnee;

            // Récupérez les lignes sélectionnées
            List<DataGridViewRow> lignesASupprimer = new List<DataGridViewRow>();

            foreach (DataGridViewRow ligne in dListeMedicaments.Rows)
            {
                DataGridViewCheckBoxCell celluleCheckBox = ligne.Cells["Sélectionner"] as DataGridViewCheckBoxCell;

                if (celluleCheckBox != null && Convert.ToBoolean(celluleCheckBox.Value))
                {
                    lignesASupprimer.Add(ligne);
                }
            }

            // Supprimez les médicaments correspondants dans votre source de données
            foreach (DataGridViewRow ligne in lignesASupprimer)
            {
                medicament medicamentASupprimer = ligne.DataBoundItem as medicament;

                if (medicamentASupprimer != null)
                {
                    mesDonnees.medicaments.Remove(medicamentASupprimer);
                }
            }

            // Enregistrez les modifications
            mesDonnees.SaveChanges();

            // Demandez au DataGridView de se rafraîchir
            dListeMedicaments.Refresh();
            dListeMedicaments.Update();

            MessageBox.Show("Médicaments supprimés avec succès.");
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers XML (*.xml)|*.xml";
            saveFileDialog.Title = "Enregistrer le fichier XML";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cheminFichier = saveFileDialog.FileName;

                try
                {
                    // Création du document XML
                    XmlDocument xmlDoc = new XmlDocument();
                    XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlDoc.AppendChild(xmlDeclaration);

                    // Création de l'élément racine
                    XmlElement racineElement = xmlDoc.CreateElement("Medicaments");
                    xmlDoc.AppendChild(racineElement);

                    // Ajout des éléments pour chaque médicament dans la grille
                    foreach (DataGridViewRow row in dMedicamentsOfferts.Rows)
                    {
                        XmlElement medicamentElement = xmlDoc.CreateElement("Medicament");

                        // Ajoutez les propriétés spécifiques de votre modèle de données
                        // Vous pouvez accéder aux cellules de la grille avec row.Cells[index]

                        // Exemple (assurez-vous d'ajuster les indices selon votre modèle de données):
                        XmlElement idMedicamentElement = xmlDoc.CreateElement("idMedicament");

                        // Vérifiez si la valeur de la cellule n'est pas null avant de l'utiliser
                        if (row.Cells[0].Value != null)
                        {
                            idMedicamentElement.InnerText = row.Cells[0].Value.ToString();
                        }
                        else
                        {
                            idMedicamentElement.InnerText = string.Empty; // ou une autre valeur par défaut
                        }

                        medicamentElement.AppendChild(idMedicamentElement);

                        XmlElement quantiteElement = xmlDoc.CreateElement("Quantité");

                        // Vérifiez si la valeur de la cellule n'est pas null avant de l'utiliser
                        if (row.Cells[1].Value != null)
                        {
                            quantiteElement.InnerText = row.Cells[1].Value.ToString();
                        }
                        else
                        {
                            quantiteElement.InnerText = string.Empty; // ou une autre valeur par défaut
                        }

                        medicamentElement.AppendChild(quantiteElement);

                        // Ajoutez d'autres propriétés du médicament selon vos besoins

                        racineElement.AppendChild(medicamentElement);
                    }

                    // Sauvegarde du fichier XML
                    xmlDoc.Save(cheminFichier);

                    MessageBox.Show("Exportation réussie vers " + cheminFichier, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la création du fichier XML : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bdgMedicament_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dListeMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListeMedicament_Load(object sender, EventArgs e)
        {

        }
    }
}
