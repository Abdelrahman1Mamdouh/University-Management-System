namespace ProgettoFinale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            registraStudenteToolStripMenuItem = new ToolStripMenuItem();
            sudenteToolStripMenuItem = new ToolStripMenuItem();
            corsoToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            fontDialog1 = new FontDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox3 = new GroupBox();
            dataGridView3 = new DataGridView();
            btnExamDetails = new Button();
            comboBoxCorsi = new ComboBox();
            btnApriEsame = new Button();
            groupBox4 = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Info;
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 2, 1, 2);
            menuStrip1.Size = new Size(1747, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registraStudenteToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // registraStudenteToolStripMenuItem
            // 
            registraStudenteToolStripMenuItem.BackColor = SystemColors.Info;
            registraStudenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sudenteToolStripMenuItem, corsoToolStripMenuItem, dashboardToolStripMenuItem });
            registraStudenteToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            registraStudenteToolStripMenuItem.Name = "registraStudenteToolStripMenuItem";
            registraStudenteToolStripMenuItem.Size = new Size(188, 34);
            registraStudenteToolStripMenuItem.Text = "Gestione ";
            // 
            // sudenteToolStripMenuItem
            // 
            sudenteToolStripMenuItem.BackColor = SystemColors.Info;
            sudenteToolStripMenuItem.Name = "sudenteToolStripMenuItem";
            sudenteToolStripMenuItem.Size = new Size(271, 34);
            sudenteToolStripMenuItem.Text = "Registrazione ";
            sudenteToolStripMenuItem.Click += sudenteToolStripMenuItem_Click;
            // 
            // corsoToolStripMenuItem
            // 
            corsoToolStripMenuItem.BackColor = SystemColors.Info;
            corsoToolStripMenuItem.Name = "corsoToolStripMenuItem";
            corsoToolStripMenuItem.Size = new Size(271, 34);
            corsoToolStripMenuItem.Text = "Registrazione Corso";
            corsoToolStripMenuItem.Click += corsoToolStripMenuItem_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.BackColor = SystemColors.Info;
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(271, 34);
            dashboardToolStripMenuItem.Text = "Archivio";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(7, 38);
            groupBox1.Margin = new Padding(1, 2, 1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 2, 1, 2);
            groupBox1.Size = new Size(757, 697);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Studenti";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 28);
            dataGridView1.Margin = new Padding(1, 2, 1, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(753, 665);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(780, 38);
            groupBox2.Margin = new Padding(1, 2, 1, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1, 2, 1, 2);
            groupBox2.Size = new Size(957, 419);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Docenti";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(2, 28);
            dataGridView2.Margin = new Padding(1, 2, 1, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 102;
            dataGridView2.Size = new Size(953, 387);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(dataGridView3);
            groupBox3.Location = new Point(780, 474);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(355, 265);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Analisi";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.LightGray;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 30);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(343, 227);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // btnExamDetails
            // 
            btnExamDetails.Location = new Point(6, 163);
            btnExamDetails.Name = "btnExamDetails";
            btnExamDetails.Size = new Size(112, 34);
            btnExamDetails.TabIndex = 3;
            btnExamDetails.Text = "Dettagli";
            btnExamDetails.UseVisualStyleBackColor = true;
            btnExamDetails.Click += btnExamDetails_Click;
            // 
            // comboBoxCorsi
            // 
            comboBoxCorsi.FormattingEnabled = true;
            comboBoxCorsi.Location = new Point(6, 30);
            comboBoxCorsi.Name = "comboBoxCorsi";
            comboBoxCorsi.Size = new Size(182, 33);
            comboBoxCorsi.TabIndex = 2;
            // 
            // btnApriEsame
            // 
            btnApriEsame.Location = new Point(6, 96);
            btnApriEsame.Name = "btnApriEsame";
            btnApriEsame.Size = new Size(112, 34);
            btnApriEsame.TabIndex = 1;
            btnApriEsame.Text = "Inserisce";
            btnApriEsame.UseVisualStyleBackColor = true;
            btnApriEsame.Click += btnApriEsame_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientActiveCaption;
            groupBox4.Controls.Add(btnExamDetails);
            groupBox4.Controls.Add(btnApriEsame);
            groupBox4.Controls.Add(comboBoxCorsi);
            groupBox4.Location = new Point(1141, 474);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(225, 265);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dettagli Corso";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1747, 746);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1, 2, 1, 2);
            Name = "Form1";
            Text = "Main Menu";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem registraStudenteToolStripMenuItem;
        private ToolStripMenuItem sudenteToolStripMenuItem;
        private ToolStripMenuItem corsoToolStripMenuItem;
        private BindingSource bindingSource1;
        private FontDialog fontDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private GroupBox groupBox3;
        private DataGridView dataGridView3;
        private Button btnApriEsame;
        private ComboBox comboBoxCorsi;
        private Button btnExamDetails;
        private GroupBox groupBox4;
    }
}
