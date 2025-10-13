using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AP2_Prep_Order
{
    public partial class ImporterResponsable : Form
    {
        public ImporterResponsable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate;
            using (var datePickerForm = new Form())
            {
                datePickerForm.Text = "Choisissez une date";
                datePickerForm.Size = new Size(250, 150);

                var dateTimePicker = new DateTimePicker
                {
                    Format = DateTimePickerFormat.Custom,
                    CustomFormat = "yyyy-MM-ddTHH:mm:ss",
                    Value = DateTime.Now,
                    Location = new Point(10, 10)
                };
                datePickerForm.Controls.Add(dateTimePicker);

                var confirmButton = new Button
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    Location = new Point(10, 50)
                };
                datePickerForm.Controls.Add(confirmButton);

                if (datePickerForm.ShowDialog() == DialogResult.OK)
                {
                    selectedDate = dateTimePicker.Value;
                }
                else
                {
                    MessageBox.Show("Aucune date sélectionnée.", "Erreur");
                    return;
                }
            }

            try
            {
                using (SqlCommand command = new SqlCommand("CommandeCreation", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@date", selectedDate.ToString("yyyy-MM-ddTHH:mm:ss"));
                    command.Parameters.AddWithValue("@idResp", Bdd.id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur");
                return;
            }

            // Préparation du dialogue d'ouverture du fichier
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Fichiers CSV (*.csv)|*.csv",
                Title = "Sélectionnez un fichier CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lecture et traitement du fichier CSV
                try
                {
                    var lignes = File.ReadAllLines(openFileDialog.FileName);

                    foreach (var ligne in lignes.Skip(1)) // Sauter la première ligne (en-têtes)
                    {
                        var colonnes = ligne.Split(',');
                        if (colonnes.Length == 3)
                        {
                            int idArticle = int.Parse(colonnes[0].Trim());
                            int quantite = int.Parse(colonnes[1].Trim());
                            int idZone = int.Parse(colonnes[2].Trim());

                            // Appel de la méthode pour insérer la ligne en BDD
                            ImporterLaLigne(idArticle, quantite, idZone);
                        }
                        else
                        {
                            MessageBox.Show($"Ligne mal formatée : {ligne}", "Erreur");
                        }
                    }

                    MessageBox.Show("Importation terminée avec succès.", "Succès");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur lors de l'importation");
                }
            }
        }

        // Ajout en BDD
        private void ImporterLaLigne(int idArticle, int quantite, int zone)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("CommandeInsertion", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idArticle", idArticle);
                    command.Parameters.AddWithValue("@quantite", quantite);
                    command.Parameters.AddWithValue("@idZone", zone);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur");
            }
        }

        private void ImporterResponsable_Load(object sender, EventArgs e)
        {

        }


    }
}
