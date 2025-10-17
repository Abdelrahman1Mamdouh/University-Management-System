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
    public partial class Form10 : Form
    {
        private Corso selectedCourse;
        private List<Esame> courseExams = new List<Esame>();
        public Form10(Corso corso)
        {
            InitializeComponent();
            selectedCourse = corso;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Esame.json";
            if (!File.Exists(path))
            {
                MessageBox.Show("No exam file found.");
                return;
            }

            var json = File.ReadAllText(path);
            var allExams = JsonSerializer.Deserialize<List<Esame>>(json);

            courseExams = allExams
                .Where(e => e.Corso.ID == selectedCourse.ID)
                .ToList();

            if (courseExams.Count == 0)
            {
                MessageBox.Show("No exams found for this course.");
                return;
            }

            dataGridView1.DataSource = courseExams
                .Select(e => new
                {
                    Student = $"{e.Studente.Nome} {e.Studente.Cognome}",
                    Grade = e.Voto,
                    Date = e.DataEsame
                })
                .ToList();
                
                UpdateStatistics();

            Ncorso.Text=selectedCourse.Nome;
            Docente.Text = $"Docente: {selectedCourse.Prof.Nome} {selectedCourse.Prof.Cognome}";



        }

        private void UpdateStatistics()
        {
            if (courseExams == null || courseExams.Count == 0)
                return;

            int max = courseExams.Max(e => e.Voto);
            int min = courseExams.Min(e => e.Voto);
            double avg = courseExams.Average(e => e.Voto);

            int passed = courseExams.Count(e => e.Voto >= 6);
            double passRate = courseExams.Count > 0 ? (passed * 100.0 / courseExams.Count) : 0.0;

            Vmax.Text = $"Max: {max}";
            Vmin.Text = $"Min: {min}";
            Media.Text = $"Media: {avg:F1}";
            Percentuale.Text = $"Tasso di superamento: {passRate:F1}%";
        }

    };
}
