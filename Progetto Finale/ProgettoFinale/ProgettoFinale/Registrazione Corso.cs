using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProgettoFinale
{
    public partial class Form7 : Form
    {

        private Form1 mainForm;
        public Form7(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm=mainForm;
        }
        
        private void Form7_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json";

            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                List<Docente> docenti = JsonSerializer.Deserialize<List<Docente>>(json);

                comboBoxDocente.DataSource = docenti;
                comboBoxDocente.DisplayMember = "Nome";
            }
        }

        private void RegistraBtn_Click(object sender, EventArgs e)
        {


            List<Corso> corsi = new List<Corso>();
            Corso c = new Corso();

           

            c.ID = CID.Text;
            c.Nome=Cnome.Text;
            c.DataInizio= dateTimePicker1.Value;
            c.DataFine= dateTimePicker2.Value;
            c.Prof = (Docente)comboBoxDocente.SelectedItem;


            if (CID.Text=="" || Cnome.Text=="" ) { MessageBox.Show("Dati non inseriti!"); return; }

            corsi.Add(c);

            string fileName = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Corsi.json";

            var leggi = File.ReadAllText(fileName);
            var js = JsonSerializer.Deserialize<List<Corso>>(leggi);
            js.Add(c);
            var json = JsonSerializer.Serialize(js);
            File.WriteAllText(fileName, json);

            dataGridView1.DataSource = js;
            dataGridView1.Columns["Prof"].Visible = false;
            dataGridView1.Columns["DisplayProf"].DisplayIndex = 0;

            dataGridView1.Visible = true;
            dataGridView1.AllowUserToAddRows = false;


            MessageBox.Show($"Registrazione effetuata{c.ToString()}");

            mainForm.RefreshCorsi();

        }

        private void Cnome_Click(object sender, EventArgs e)
        {

        }

        private void dataInizio_Click(object sender, EventArgs e)
        {

        }
    }
}
