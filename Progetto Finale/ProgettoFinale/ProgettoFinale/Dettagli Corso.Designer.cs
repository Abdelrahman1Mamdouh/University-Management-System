namespace ProgettoFinale
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Docente = new Label();
            Percentuale = new Label();
            Media = new Label();
            Vmin = new Label();
            Vmax = new Label();
            dataGridView1 = new DataGridView();
            Ncorso = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(Docente);
            groupBox1.Controls.Add(Percentuale);
            groupBox1.Controls.Add(Media);
            groupBox1.Controls.Add(Vmin);
            groupBox1.Controls.Add(Vmax);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1032, 557);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dettagli Corso";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Docente
            // 
            Docente.AutoSize = true;
            Docente.Location = new Point(0, 512);
            Docente.Name = "Docente";
            Docente.Size = new Size(0, 25);
            Docente.TabIndex = 5;
            // 
            // Percentuale
            // 
            Percentuale.AutoSize = true;
            Percentuale.Location = new Point(6, 474);
            Percentuale.Name = "Percentuale";
            Percentuale.Size = new Size(0, 25);
            Percentuale.TabIndex = 4;
            // 
            // Media
            // 
            Media.AutoSize = true;
            Media.Location = new Point(6, 429);
            Media.Name = "Media";
            Media.Size = new Size(0, 25);
            Media.TabIndex = 3;
            // 
            // Vmin
            // 
            Vmin.AutoSize = true;
            Vmin.Location = new Point(6, 390);
            Vmin.Name = "Vmin";
            Vmin.Size = new Size(0, 25);
            Vmin.TabIndex = 2;
            // 
            // Vmax
            // 
            Vmax.AutoSize = true;
            Vmax.Location = new Point(6, 347);
            Vmax.Name = "Vmax";
            Vmax.Size = new Size(0, 25);
            Vmax.TabIndex = 1;
            Vmax.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1020, 290);
            dataGridView1.TabIndex = 0;
            // 
            // Ncorso
            // 
            Ncorso.AutoSize = true;
            Ncorso.Location = new Point(493, 19);
            Ncorso.Name = "Ncorso";
            Ncorso.Size = new Size(0, 25);
            Ncorso.TabIndex = 1;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1056, 641);
            Controls.Add(Ncorso);
            Controls.Add(groupBox1);
            Name = "Form10";
            Text = "Dettagli Corso";
            Load += Form10_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label Media;
        private Label Vmin;
        private Label Vmax;
        private Label Percentuale;
        private Label Ncorso;
        private Label Docente;
    }
}