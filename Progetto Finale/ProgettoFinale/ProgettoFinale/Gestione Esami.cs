using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoFinale
{
    public partial class Form11 : Form
    {
        private Corso corso;
        private List<Studente> studenti;

        private void LoadStudenti()
        {
            string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Studenti.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                studenti = JsonSerializer.Deserialize<List<Studente>>(json);
                comboBoxStudenti.DataSource = studenti;
                comboBoxStudenti.DisplayMember = "NomeCompleto";
            }
        }

       

        public Form11(Corso corsoSelezionato)
        {
            InitializeComponent();
            corso= corsoSelezionato;
            LoadStudenti();
           
            lblNomeCorso.Text=corsoSelezionato.Nome;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxStudenti.SelectedItem is Studente studente)
            {

                if (!int.TryParse(Voto.Text, out int voto))
                {
                    MessageBox.Show("Inserisci un voto valido (numero intero).", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (voto < 0 || voto > 10)
                {
                    MessageBox.Show("Il voto deve essere compreso tra 0 e 10.", "Voto non valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Esame nuovoEsame = new Esame
                {
                    Corso = corso,
                    Studente = studente,
                    DataEsame = dateTimePickerEsame.Value,
                    Voto = int.Parse(Voto.Text)

                };

                
                var path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Esame.json";
                List<Esame> esami = new();
                if (File.Exists(path))
                {
                    var json = File.ReadAllText(path);
                    esami = JsonSerializer.Deserialize<List<Esame>>(json);
                }
                
                

                esami.Add(nuovoEsame);
                var nuovoJson = JsonSerializer.Serialize(esami, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, nuovoJson);
                MessageBox.Show("Esame salvato correttamente.");
                this.Close();
            }
        }
    }
}
