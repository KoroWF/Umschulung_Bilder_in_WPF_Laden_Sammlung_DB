namespace Forms_Tourismus
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listSight = new System.Windows.Forms.ListBox();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.sigh = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Suche = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_sight_besch = new System.Windows.Forms.TextBox();
            this.img_sight = new System.Windows.Forms.PictureBox();
            this.Next_btn = new System.Windows.Forms.Button();
            this.Tab_Tour = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Tab_Suchen = new System.Windows.Forms.TabPage();
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Tab_Suche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_sight)).BeginInit();
            this.Tab_Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listSight
            // 
            this.listSight.FormattingEnabled = true;
            this.listSight.Location = new System.Drawing.Point(23, 23);
            this.listSight.Name = "listSight";
            this.listSight.Size = new System.Drawing.Size(230, 264);
            this.listSight.TabIndex = 1;
            this.listSight.SelectedIndexChanged += new System.EventHandler(this.ListSight_SelectedIndexChanged);
            // 
            // txtSuche
            // 
            this.txtSuche.Location = new System.Drawing.Point(365, 33);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(100, 20);
            this.txtSuche.TabIndex = 2;
            this.txtSuche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSuche_KeyUp);
            // 
            // sigh
            // 
            this.sigh.AutoSize = true;
            this.sigh.Location = new System.Drawing.Point(278, 40);
            this.sigh.Name = "sigh";
            this.sigh.Size = new System.Drawing.Size(71, 13);
            this.sigh.TabIndex = 3;
            this.sigh.Text = "Sight or Stadt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Suche);
            this.tabControl1.Controls.Add(this.Tab_Tour);
            this.tabControl1.Controls.Add(this.Tab_Suchen);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 439);
            this.tabControl1.TabIndex = 4;
            // 
            // Tab_Suche
            // 
            this.Tab_Suche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Tab_Suche.Controls.Add(this.dateTimePicker1);
            this.Tab_Suche.Controls.Add(this.txt_sight_besch);
            this.Tab_Suche.Controls.Add(this.img_sight);
            this.Tab_Suche.Controls.Add(this.Next_btn);
            this.Tab_Suche.Controls.Add(this.listSight);
            this.Tab_Suche.Controls.Add(this.sigh);
            this.Tab_Suche.Controls.Add(this.txtSuche);
            this.Tab_Suche.Location = new System.Drawing.Point(4, 22);
            this.Tab_Suche.Name = "Tab_Suche";
            this.Tab_Suche.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Suche.Size = new System.Drawing.Size(779, 413);
            this.Tab_Suche.TabIndex = 0;
            this.Tab_Suche.Text = "Suche";
            this.Tab_Suche.Click += new System.EventHandler(this.Tab_Suche_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(542, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // txt_sight_besch
            // 
            this.txt_sight_besch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sight_besch.Location = new System.Drawing.Point(491, 186);
            this.txt_sight_besch.Multiline = true;
            this.txt_sight_besch.Name = "txt_sight_besch";
            this.txt_sight_besch.ReadOnly = true;
            this.txt_sight_besch.Size = new System.Drawing.Size(225, 101);
            this.txt_sight_besch.TabIndex = 6;
            this.txt_sight_besch.Visible = false;
            // 
            // img_sight
            // 
            this.img_sight.Location = new System.Drawing.Point(281, 101);
            this.img_sight.Name = "img_sight";
            this.img_sight.Size = new System.Drawing.Size(184, 186);
            this.img_sight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_sight.TabIndex = 5;
            this.img_sight.TabStop = false;
            this.img_sight.Click += new System.EventHandler(this.Img_sight_Click);
            // 
            // Next_btn
            // 
            this.Next_btn.Location = new System.Drawing.Point(677, 372);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(75, 23);
            this.Next_btn.TabIndex = 4;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // Tab_Tour
            // 
            this.Tab_Tour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Tab_Tour.Controls.Add(this.dataGridView1);
            this.Tab_Tour.Location = new System.Drawing.Point(4, 22);
            this.Tab_Tour.Name = "Tab_Tour";
            this.Tab_Tour.Size = new System.Drawing.Size(779, 413);
            this.Tab_Tour.TabIndex = 2;
            this.Tab_Tour.Text = "Tour";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snameDataGridViewTextBoxColumn,
            this.onameDataGridViewTextBoxColumn,
            this.preisDataGridViewTextBoxColumn,
            this.Datum});
            this.dataGridView1.DataSource = this.tourBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(24, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sigth name";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onameDataGridViewTextBoxColumn
            // 
            this.onameDataGridViewTextBoxColumn.DataPropertyName = "Oname";
            this.onameDataGridViewTextBoxColumn.HeaderText = "Orgnaiser";
            this.onameDataGridViewTextBoxColumn.Name = "onameDataGridViewTextBoxColumn";
            this.onameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preisDataGridViewTextBoxColumn
            // 
            this.preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            this.preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            this.preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            this.preisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // tourBindingSource1
            // 
            this.tourBindingSource1.DataSource = typeof(Bibo_Tourismus.Tour);
            // 
            // Tab_Suchen
            // 
            this.Tab_Suchen.Location = new System.Drawing.Point(4, 22);
            this.Tab_Suchen.Name = "Tab_Suchen";
            this.Tab_Suchen.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Suchen.Size = new System.Drawing.Size(779, 413);
            this.Tab_Suchen.TabIndex = 1;
            this.Tab_Suchen.Text = "Buchen";
            this.Tab_Suchen.UseVisualStyleBackColor = true;
            // 
            // tourBindingSource
            // 
            this.tourBindingSource.DataSource = typeof(Bibo_Tourismus.Tour);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab_Suche.ResumeLayout(false);
            this.Tab_Suche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_sight)).EndInit();
            this.Tab_Tour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSight;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Label sigh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_Suche;
        private System.Windows.Forms.TabPage Tab_Suchen;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.TabPage Tab_Tour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tourBindingSource;
        private System.Windows.Forms.TextBox txt_sight_besch;
        private System.Windows.Forms.PictureBox img_sight;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.BindingSource tourBindingSource1;
    }
}

