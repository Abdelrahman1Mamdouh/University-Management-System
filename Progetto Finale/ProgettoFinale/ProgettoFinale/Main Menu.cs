using System.Text.Json;

namespace ProgettoFinale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private List<Corso> corsi = new List<Corso>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Studenti.json";

            var json = File.ReadAllText(path);

            var studente = JsonSerializer.Deserialize<List<Studente>>(json);

            dataGridView1.DataSource = studente;

            string file = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json";

            var js = File.ReadAllText(file);

            var docente = JsonSerializer.Deserialize<List<Docente>>(js);

            dataGridView2.DataSource = docente;

            LoadAnalytics();


            string pathCorsi = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Corsi.json";

            if (File.Exists(pathCorsi))
            {
                var j = File.ReadAllText(pathCorsi);
                corsi = JsonSerializer.Deserialize<List<Corso>>(j);
                comboBoxCorsi.DataSource = corsi;
                comboBoxCorsi.DisplayMember = "Nome";
                comboBoxCorsi.DropDownStyle = ComboBoxStyle.DropDownList;
            }


        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registrazioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void RefreshStudenti()
        {
            string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Studenti.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var studenti = JsonSerializer.Deserialize<List<Studente>>(json);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = studenti;

            }
            LoadAnalytics();
        }

        public void RefreshDocenti()
        {
            string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var docenti = JsonSerializer.Deserialize<List<Docente>>(json);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = docenti;

            }
            LoadAnalytics();

        }

        public void RefreshCorsi()
        {
            string pathCorsi = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Corsi.json";

            if (File.Exists(pathCorsi))
            {
                var j = File.ReadAllText(pathCorsi);
                corsi = JsonSerializer.Deserialize<List<Corso>>(j);
                comboBoxCorsi.DataSource = null;
                comboBoxCorsi.DataSource = corsi;
                comboBoxCorsi.DisplayMember = "Nome";
                comboBoxCorsi.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            LoadAnalytics();
        }


        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivio form8 = new Archivio(this);
            form8.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadAnalytics()
        {
            string studentiPath = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Studenti.json";
            string docentiPath = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json";
            string corsiPath = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Corsi.json";

            int studentiCount = 0;
            int docentiCount = 0;
            int corsiCount = 0;

            if (File.Exists(studentiPath))
            {
                var json = File.ReadAllText(studentiPath);
                var studenti = JsonSerializer.Deserialize<List<Studente>>(json);
                studentiCount = studenti?.Count ?? 0;
            }

            if (File.Exists(docentiPath))
            {
                var json = File.ReadAllText(docentiPath);
                var docenti = JsonSerializer.Deserialize<List<Docente>>(json);
                docentiCount = docenti?.Count ?? 0;
            }

            if (File.Exists(corsiPath))
            {
                var json = File.ReadAllText(corsiPath);
                var corsi = JsonSerializer.Deserialize<List<Corso>>(json);
                corsiCount = corsi?.Count ?? 0;
            }

            var analytics = new List<dynamic>
    {
        new { Categoria = "Studenti", Count = studentiCount },
        new { Categoria = "Docenti", Count = docentiCount },
        new { Categoria = "Corsi", Count = corsiCount }
    };

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = analytics;
        }

        private void btnApriEsame_Click(object sender, EventArgs e)
        {
            var selectedCorso = comboBoxCorsi.SelectedItem as Corso;

            if (selectedCorso != null)
            {
                var formEsame = new Form11(selectedCorso);
                formEsame.Show();
            }
            else
            {
                MessageBox.Show("Please select a course first.");
            }
        }

        private void btnExamDetails_Click(object sender, EventArgs e)
        {
            var selectedCourse = comboBoxCorsi.SelectedItem as Corso;
            if (selectedCourse == null)
            {
                MessageBox.Show("Please select a course first.");
                return;
            }

            Form10 detailsForm = new Form10(selectedCourse);
            detailsForm.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void sudenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrazione registrazione = new Registrazione(this);
            registrazione.Show();
        }

        private void corsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.Show();
        }
    }



}
