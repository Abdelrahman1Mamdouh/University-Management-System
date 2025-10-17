namespace ProgettoFinale
{
    partial class Archivio
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
            dataGridView1 = new DataGridView();
            radioStudenti = new RadioButton();
            radioDocenti = new RadioButton();
            radioCorsi = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 20);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1234, 590);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // radioStudenti
            // 
            radioStudenti.AutoSize = true;
            radioStudenti.BackColor = SystemColors.GradientInactiveCaption;
            radioStudenti.Location = new Point(233, 698);
            radioStudenti.Margin = new Padding(4, 5, 4, 5);
            radioStudenti.Name = "radioStudenti";
            radioStudenti.Size = new Size(102, 29);
            radioStudenti.TabIndex = 1;
            radioStudenti.TabStop = true;
            radioStudenti.Text = "Studenti";
            radioStudenti.UseVisualStyleBackColor = false;
            radioStudenti.CheckedChanged += radioStudenti_CheckedChanged;
            // 
            // radioDocenti
            // 
            radioDocenti.AutoSize = true;
            radioDocenti.BackColor = SystemColors.GradientInactiveCaption;
            radioDocenti.Location = new Point(567, 698);
            radioDocenti.Margin = new Padding(4, 5, 4, 5);
            radioDocenti.Name = "radioDocenti";
            radioDocenti.Size = new Size(98, 29);
            radioDocenti.TabIndex = 2;
            radioDocenti.TabStop = true;
            radioDocenti.Text = "Docenti";
            radioDocenti.UseVisualStyleBackColor = false;
            radioDocenti.CheckedChanged += radioDocenti_CheckedChanged;
            // 
            // radioCorsi
            // 
            radioCorsi.AutoSize = true;
            radioCorsi.BackColor = SystemColors.GradientInactiveCaption;
            radioCorsi.Location = new Point(929, 698);
            radioCorsi.Margin = new Padding(4, 5, 4, 5);
            radioCorsi.Name = "radioCorsi";
            radioCorsi.Size = new Size(77, 29);
            radioCorsi.TabIndex = 3;
            radioCorsi.TabStop = true;
            radioCorsi.Text = "Corsi";
            radioCorsi.UseVisualStyleBackColor = false;
            radioCorsi.CheckedChanged += radioCorsi_CheckedChanged;
            // 
            // Archivio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1269, 750);
            Controls.Add(radioCorsi);
            Controls.Add(radioDocenti);
            Controls.Add(radioStudenti);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Archivio";
            Text = "Archivio";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton radioStudenti;
        private RadioButton radioDocenti;
        private RadioButton radioCorsi;
    }
}