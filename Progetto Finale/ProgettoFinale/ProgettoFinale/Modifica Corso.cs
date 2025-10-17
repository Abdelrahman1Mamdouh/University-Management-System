using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProgettoFinale
{
    public partial class Form9 : Form
    {
        private Corso corsoOriginale;
        public Corso corsoModificato { get; private set; }
        private List<Docente> docenti;

        public Form9(Corso corso)
        {
            InitializeComponent();
            this.corsoOriginale = corso;
            string docentiPath = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json";
            if (File.Exists(docentiPath))
            {
                var json = File.ReadAllText(docentiPath);
                docenti = JsonSerializer.Deserialize<List<Docente>>(json);
            }
            else
            {
                MessageBox.Show("Docenti file not found!");
                docenti = new List<Docente>();
            }

            Cnome.Text=corso.Nome;
            CID.Text=corso.ID;
            dateTimePicker1.Value=corso.DataInizio;
            dateTimePicker2.Value=corso.DataFine;

            comboBoxDocente.DisplayMember="NomeCognome";
            comboBoxDocente.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxDocente.DataSource=docenti;

            comboBoxDocente.SelectedItem=docenti.FirstOrDefault(d => d.Nome ==corso.Prof.Nome && d.Cognome==corso.Prof.Cognome);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            corsoModificato= new Corso
            {
                ID=CID.Text,
                Nome=Cnome.Text,
                DataInizio=dateTimePicker1.Value,
                DataFine=dateTimePicker2.Value,
                Prof=(Docente)comboBoxDocente.SelectedItem

                

        };
            if (CID.Text=="" || Cnome.Text=="") { MessageBox.Show("Dati non inseriti!"); return; }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
