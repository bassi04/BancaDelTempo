namespace BancaDelTempo
{
    partial class bancaTempo
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
            txtNome = new TextBox();
            txtCognome = new TextBox();
            txtTelefono = new TextBox();
            btnSalva = new Button();
            dgwDebito = new DataGridView();
            dgwSegreteria = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colCognome = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colOrePrestate = new DataGridViewTextBoxColumn();
            colServizi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbControl = new TabControl();
            tbSoci = new TabPage();
            lblDebito = new Label();
            tbCategorie = new TabPage();
            lblCategorie = new Label();
            dgwCategorie = new DataGridView();
            txtCategoria = new TextBox();
            lblNomeCat = new Label();
            btnSalvaCategoria = new Button();
            tbPrestazioni = new TabPage();
            lblPrestazioni = new Label();
            dgwPrestazioni = new DataGridView();
            colPrestazione = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colEsecutore = new DataGridViewTextBoxColumn();
            colRicevente = new DataGridViewTextBoxColumn();
            colOre = new DataGridViewTextBoxColumn();
            colData = new DataGridViewTextBoxColumn();
            dtDataPrestazione = new DateTimePicker();
            lblData = new Label();
            numOre = new NumericUpDown();
            lblTotOre = new Label();
            cbRicevente = new ComboBox();
            lblRicevente = new Label();
            cbEsecutore = new ComboBox();
            cbCategoria = new ComboBox();
            txtPrestazione = new TextBox();
            lblEsecutore = new Label();
            lblPrestazione = new Label();
            lblCategoria = new Label();
            btnsalvaPrestazione = new Button();
            tbStatistica = new TabPage();
            lblSegreteria = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwDebito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwSegreteria).BeginInit();
            tbControl.SuspendLayout();
            tbSoci.SuspendLayout();
            tbCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCategorie).BeginInit();
            tbPrestazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwPrestazioni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOre).BeginInit();
            tbStatistica.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(240, 48);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(219, 29);
            txtNome.TabIndex = 0;
            // 
            // txtCognome
            // 
            txtCognome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCognome.Location = new Point(26, 48);
            txtCognome.Margin = new Padding(3, 4, 3, 4);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(206, 29);
            txtCognome.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(466, 48);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(210, 29);
            txtTelefono.TabIndex = 2;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(26, 104);
            btnSalva.Margin = new Padding(3, 4, 3, 4);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(650, 49);
            btnSalva.TabIndex = 4;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // dgwDebito
            // 
            dgwDebito.AllowUserToAddRows = false;
            dgwDebito.AllowUserToDeleteRows = false;
            dgwDebito.AllowUserToOrderColumns = true;
            dgwDebito.AllowUserToResizeColumns = false;
            dgwDebito.AllowUserToResizeRows = false;
            dgwDebito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDebito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDebito.Location = new Point(26, 212);
            dgwDebito.Margin = new Padding(3, 4, 3, 4);
            dgwDebito.Name = "dgwDebito";
            dgwDebito.RowHeadersVisible = false;
            dgwDebito.RowHeadersWidth = 51;
            dgwDebito.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwDebito.RowTemplate.Height = 25;
            dgwDebito.Size = new Size(650, 367);
            dgwDebito.TabIndex = 5;
            // 
            // dgwSegreteria
            // 
            dgwSegreteria.AllowUserToAddRows = false;
            dgwSegreteria.AllowUserToDeleteRows = false;
            dgwSegreteria.AllowUserToResizeColumns = false;
            dgwSegreteria.AllowUserToResizeRows = false;
            dgwSegreteria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwSegreteria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSegreteria.Columns.AddRange(new DataGridViewColumn[] { colNome, colCognome, colTelefono, colOrePrestate, colServizi });
            dgwSegreteria.Location = new Point(21, 76);
            dgwSegreteria.Margin = new Padding(3, 4, 3, 4);
            dgwSegreteria.Name = "dgwSegreteria";
            dgwSegreteria.RowHeadersVisible = false;
            dgwSegreteria.RowHeadersWidth = 51;
            dgwSegreteria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwSegreteria.RowTemplate.Height = 25;
            dgwSegreteria.Size = new Size(648, 496);
            dgwSegreteria.TabIndex = 6;
            dgwSegreteria.CellContentClick += dgwSegreteria_CellContentClick;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            // 
            // colCognome
            // 
            colCognome.HeaderText = "Cognome";
            colCognome.MinimumWidth = 6;
            colCognome.Name = "colCognome";
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Telefono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            // 
            // colOrePrestate
            // 
            colOrePrestate.HeaderText = "Ore Segreteria";
            colOrePrestate.MinimumWidth = 6;
            colOrePrestate.Name = "colOrePrestate";
            // 
            // colServizi
            // 
            colServizi.HeaderText = "Servizi Forniti";
            colServizi.MinimumWidth = 6;
            colServizi.Name = "colServizi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(240, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 19);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 9;
            label2.Text = "Cognome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(466, 19);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 10;
            label3.Text = "Telefono";
            // 
            // tbControl
            // 
            tbControl.Controls.Add(tbSoci);
            tbControl.Controls.Add(tbCategorie);
            tbControl.Controls.Add(tbPrestazioni);
            tbControl.Controls.Add(tbStatistica);
            tbControl.Location = new Point(16, 17);
            tbControl.Margin = new Padding(3, 4, 3, 4);
            tbControl.Name = "tbControl";
            tbControl.SelectedIndex = 0;
            tbControl.Size = new Size(710, 645);
            tbControl.TabIndex = 11;
            tbControl.SelectedIndexChanged += tbControl_SelectedIndexChanged;
            // 
            // tbSoci
            // 
            tbSoci.Controls.Add(lblDebito);
            tbSoci.Controls.Add(txtTelefono);
            tbSoci.Controls.Add(txtNome);
            tbSoci.Controls.Add(label3);
            tbSoci.Controls.Add(label1);
            tbSoci.Controls.Add(dgwDebito);
            tbSoci.Controls.Add(label2);
            tbSoci.Controls.Add(btnSalva);
            tbSoci.Controls.Add(txtCognome);
            tbSoci.Location = new Point(4, 29);
            tbSoci.Margin = new Padding(3, 4, 3, 4);
            tbSoci.Name = "tbSoci";
            tbSoci.Padding = new Padding(3, 4, 3, 4);
            tbSoci.Size = new Size(702, 612);
            tbSoci.TabIndex = 0;
            tbSoci.Text = "Soci";
            tbSoci.UseVisualStyleBackColor = true;
            // 
            // lblDebito
            // 
            lblDebito.AutoSize = true;
            lblDebito.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebito.Location = new Point(26, 177);
            lblDebito.Name = "lblDebito";
            lblDebito.Size = new Size(191, 23);
            lblDebito.TabIndex = 11;
            lblDebito.Text = "Elenco Soci in \"DEBITO\"";
            // 
            // tbCategorie
            // 
            tbCategorie.Controls.Add(lblCategorie);
            tbCategorie.Controls.Add(dgwCategorie);
            tbCategorie.Controls.Add(txtCategoria);
            tbCategorie.Controls.Add(lblNomeCat);
            tbCategorie.Controls.Add(btnSalvaCategoria);
            tbCategorie.Location = new Point(4, 29);
            tbCategorie.Margin = new Padding(3, 4, 3, 4);
            tbCategorie.Name = "tbCategorie";
            tbCategorie.Padding = new Padding(3, 4, 3, 4);
            tbCategorie.Size = new Size(702, 612);
            tbCategorie.TabIndex = 3;
            tbCategorie.Text = "Categorie";
            tbCategorie.UseVisualStyleBackColor = true;
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategorie.Location = new Point(29, 181);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.Size = new Size(139, 23);
            lblCategorie.TabIndex = 17;
            lblCategorie.Text = "Elenco Categorie";
            // 
            // dgwCategorie
            // 
            dgwCategorie.AllowUserToAddRows = false;
            dgwCategorie.AllowUserToDeleteRows = false;
            dgwCategorie.AllowUserToOrderColumns = true;
            dgwCategorie.AllowUserToResizeColumns = false;
            dgwCategorie.AllowUserToResizeRows = false;
            dgwCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCategorie.Location = new Point(29, 213);
            dgwCategorie.Margin = new Padding(3, 4, 3, 4);
            dgwCategorie.Name = "dgwCategorie";
            dgwCategorie.ReadOnly = true;
            dgwCategorie.RowHeadersVisible = false;
            dgwCategorie.RowHeadersWidth = 51;
            dgwCategorie.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwCategorie.RowTemplate.Height = 25;
            dgwCategorie.Size = new Size(648, 372);
            dgwCategorie.TabIndex = 16;
            dgwCategorie.CellContentClick += dgwCategorie_CellContentClick;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoria.Location = new Point(29, 55);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(644, 29);
            txtCategoria.TabIndex = 11;
            // 
            // lblNomeCat
            // 
            lblNomeCat.AutoSize = true;
            lblNomeCat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeCat.Location = new Point(29, 25);
            lblNomeCat.Name = "lblNomeCat";
            lblNomeCat.Size = new Size(84, 23);
            lblNomeCat.TabIndex = 15;
            lblNomeCat.Text = "Categoria";
            // 
            // btnSalvaCategoria
            // 
            btnSalvaCategoria.Location = new Point(29, 108);
            btnSalvaCategoria.Margin = new Padding(3, 4, 3, 4);
            btnSalvaCategoria.Name = "btnSalvaCategoria";
            btnSalvaCategoria.Size = new Size(645, 49);
            btnSalvaCategoria.TabIndex = 14;
            btnSalvaCategoria.Text = "Salva Categoria";
            btnSalvaCategoria.UseVisualStyleBackColor = true;
            btnSalvaCategoria.Click += btnSalvaCategoria_Click;
            // 
            // tbPrestazioni
            // 
            tbPrestazioni.Controls.Add(lblPrestazioni);
            tbPrestazioni.Controls.Add(dgwPrestazioni);
            tbPrestazioni.Controls.Add(dtDataPrestazione);
            tbPrestazioni.Controls.Add(lblData);
            tbPrestazioni.Controls.Add(numOre);
            tbPrestazioni.Controls.Add(lblTotOre);
            tbPrestazioni.Controls.Add(cbRicevente);
            tbPrestazioni.Controls.Add(lblRicevente);
            tbPrestazioni.Controls.Add(cbEsecutore);
            tbPrestazioni.Controls.Add(cbCategoria);
            tbPrestazioni.Controls.Add(txtPrestazione);
            tbPrestazioni.Controls.Add(lblEsecutore);
            tbPrestazioni.Controls.Add(lblPrestazione);
            tbPrestazioni.Controls.Add(lblCategoria);
            tbPrestazioni.Controls.Add(btnsalvaPrestazione);
            tbPrestazioni.Location = new Point(4, 29);
            tbPrestazioni.Margin = new Padding(3, 4, 3, 4);
            tbPrestazioni.Name = "tbPrestazioni";
            tbPrestazioni.Padding = new Padding(3, 4, 3, 4);
            tbPrestazioni.Size = new Size(702, 612);
            tbPrestazioni.TabIndex = 1;
            tbPrestazioni.Text = "Prestazioni";
            tbPrestazioni.UseVisualStyleBackColor = true;
            // 
            // lblPrestazioni
            // 
            lblPrestazioni.AutoSize = true;
            lblPrestazioni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrestazioni.Location = new Point(27, 245);
            lblPrestazioni.Name = "lblPrestazioni";
            lblPrestazioni.Size = new Size(552, 23);
            lblPrestazioni.TabIndex = 1;
            lblPrestazioni.Text = "Elenco Prestazioni - Ordinate con ordine descrescente per Ore Prestate";
            // 
            // dgwPrestazioni
            // 
            dgwPrestazioni.AllowUserToAddRows = false;
            dgwPrestazioni.AllowUserToDeleteRows = false;
            dgwPrestazioni.AllowUserToResizeColumns = false;
            dgwPrestazioni.AllowUserToResizeRows = false;
            dgwPrestazioni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPrestazioni.Columns.AddRange(new DataGridViewColumn[] { colPrestazione, colCategoria, colEsecutore, colRicevente, colOre, colData });
            dgwPrestazioni.Location = new Point(27, 281);
            dgwPrestazioni.Margin = new Padding(3, 4, 3, 4);
            dgwPrestazioni.Name = "dgwPrestazioni";
            dgwPrestazioni.RowHeadersVisible = false;
            dgwPrestazioni.RowHeadersWidth = 51;
            dgwPrestazioni.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwPrestazioni.RowTemplate.Height = 25;
            dgwPrestazioni.Size = new Size(648, 300);
            dgwPrestazioni.TabIndex = 0;
            dgwPrestazioni.CellContentClick += dgwPrestazioni_CellContentClick;
            // 
            // colPrestazione
            // 
            colPrestazione.FillWeight = 150F;
            colPrestazione.HeaderText = "Prestazione";
            colPrestazione.MinimumWidth = 6;
            colPrestazione.Name = "colPrestazione";
            colPrestazione.Width = 150;
            // 
            // colCategoria
            // 
            colCategoria.FillWeight = 150F;
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.Width = 150;
            // 
            // colEsecutore
            // 
            colEsecutore.FillWeight = 150F;
            colEsecutore.HeaderText = "Esecutore";
            colEsecutore.MinimumWidth = 6;
            colEsecutore.Name = "colEsecutore";
            colEsecutore.Width = 150;
            // 
            // colRicevente
            // 
            colRicevente.FillWeight = 150F;
            colRicevente.HeaderText = "Ricevente";
            colRicevente.MinimumWidth = 6;
            colRicevente.Name = "colRicevente";
            colRicevente.Width = 150;
            // 
            // colOre
            // 
            colOre.FillWeight = 65F;
            colOre.HeaderText = "Tot. Ore";
            colOre.MinimumWidth = 6;
            colOre.Name = "colOre";
            colOre.Width = 65;
            // 
            // colData
            // 
            colData.FillWeight = 60F;
            colData.HeaderText = "Data";
            colData.MinimumWidth = 6;
            colData.Name = "colData";
            colData.Width = 70;
            // 
            // dtDataPrestazione
            // 
            dtDataPrestazione.Format = DateTimePickerFormat.Short;
            dtDataPrestazione.Location = new Point(463, 124);
            dtDataPrestazione.Margin = new Padding(3, 4, 3, 4);
            dtDataPrestazione.Name = "dtDataPrestazione";
            dtDataPrestazione.Size = new Size(212, 27);
            dtDataPrestazione.TabIndex = 25;
            dtDataPrestazione.Value = new DateTime(2023, 8, 24, 11, 6, 0, 0);
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.Location = new Point(463, 96);
            lblData.Name = "lblData";
            lblData.Size = new Size(46, 23);
            lblData.TabIndex = 24;
            lblData.Text = "Data";
            // 
            // numOre
            // 
            numOre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numOre.Location = new Point(238, 123);
            numOre.Margin = new Padding(3, 4, 3, 4);
            numOre.Name = "numOre";
            numOre.ReadOnly = true;
            numOre.Size = new Size(210, 29);
            numOre.TabIndex = 23;
            // 
            // lblTotOre
            // 
            lblTotOre.AutoSize = true;
            lblTotOre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotOre.Location = new Point(238, 96);
            lblTotOre.Name = "lblTotOre";
            lblTotOre.Size = new Size(70, 23);
            lblTotOre.TabIndex = 22;
            lblTotOre.Text = "Tot. Ore";
            // 
            // cbRicevente
            // 
            cbRicevente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbRicevente.FormattingEnabled = true;
            cbRicevente.Location = new Point(27, 123);
            cbRicevente.Margin = new Padding(3, 4, 3, 4);
            cbRicevente.Name = "cbRicevente";
            cbRicevente.Size = new Size(196, 29);
            cbRicevente.TabIndex = 21;
            cbRicevente.SelectedIndexChanged += cbRicevente_SelectedIndexChanged;
            // 
            // lblRicevente
            // 
            lblRicevente.AutoSize = true;
            lblRicevente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRicevente.Location = new Point(27, 96);
            lblRicevente.Name = "lblRicevente";
            lblRicevente.Size = new Size(83, 23);
            lblRicevente.TabIndex = 20;
            lblRicevente.Text = "Ricevente";
            // 
            // cbEsecutore
            // 
            cbEsecutore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEsecutore.FormattingEnabled = true;
            cbEsecutore.Location = new Point(463, 55);
            cbEsecutore.Margin = new Padding(3, 4, 3, 4);
            cbEsecutore.Name = "cbEsecutore";
            cbEsecutore.Size = new Size(212, 29);
            cbEsecutore.TabIndex = 19;
            cbEsecutore.SelectedIndexChanged += cbEsecutore_SelectedIndexChanged;
            // 
            // cbCategoria
            // 
            cbCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(238, 55);
            cbCategoria.Margin = new Padding(3, 4, 3, 4);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(212, 29);
            cbCategoria.TabIndex = 18;
            // 
            // txtPrestazione
            // 
            txtPrestazione.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrestazione.Location = new Point(27, 55);
            txtPrestazione.Margin = new Padding(3, 4, 3, 4);
            txtPrestazione.Name = "txtPrestazione";
            txtPrestazione.Size = new Size(196, 29);
            txtPrestazione.TabIndex = 11;
            // 
            // lblEsecutore
            // 
            lblEsecutore.AutoSize = true;
            lblEsecutore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsecutore.Location = new Point(463, 28);
            lblEsecutore.Name = "lblEsecutore";
            lblEsecutore.Size = new Size(84, 23);
            lblEsecutore.TabIndex = 17;
            lblEsecutore.Text = "Esecutore";
            // 
            // lblPrestazione
            // 
            lblPrestazione.AutoSize = true;
            lblPrestazione.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrestazione.Location = new Point(27, 28);
            lblPrestazione.Name = "lblPrestazione";
            lblPrestazione.Size = new Size(150, 23);
            lblPrestazione.TabIndex = 15;
            lblPrestazione.Text = "Nome Prestazione";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(238, 28);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 23);
            lblCategoria.TabIndex = 16;
            lblCategoria.Text = "Categoria";
            // 
            // btnsalvaPrestazione
            // 
            btnsalvaPrestazione.Location = new Point(27, 173);
            btnsalvaPrestazione.Margin = new Padding(3, 4, 3, 4);
            btnsalvaPrestazione.Name = "btnsalvaPrestazione";
            btnsalvaPrestazione.Size = new Size(648, 49);
            btnsalvaPrestazione.TabIndex = 14;
            btnsalvaPrestazione.Text = "Salva Prestazione";
            btnsalvaPrestazione.UseVisualStyleBackColor = true;
            btnsalvaPrestazione.Click += btnsalvaPrestazione_Click;
            // 
            // tbStatistica
            // 
            tbStatistica.Controls.Add(dgwSegreteria);
            tbStatistica.Controls.Add(lblSegreteria);
            tbStatistica.Location = new Point(4, 29);
            tbStatistica.Margin = new Padding(3, 4, 3, 4);
            tbStatistica.Name = "tbStatistica";
            tbStatistica.Size = new Size(702, 612);
            tbStatistica.TabIndex = 2;
            tbStatistica.Text = "Statistica";
            tbStatistica.UseVisualStyleBackColor = true;
            // 
            // lblSegreteria
            // 
            lblSegreteria.AutoSize = true;
            lblSegreteria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegreteria.Location = new Point(21, 33);
            lblSegreteria.Name = "lblSegreteria";
            lblSegreteria.Size = new Size(266, 23);
            lblSegreteria.TabIndex = 26;
            lblSegreteria.Text = "Elenco Soci - attività di Segreteria";
            // 
            // bancaTempo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 681);
            Controls.Add(tbControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "bancaTempo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banca del Tempo";
            Load += bancaTempo_Load;
            ((System.ComponentModel.ISupportInitialize)dgwDebito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwSegreteria).EndInit();
            tbControl.ResumeLayout(false);
            tbSoci.ResumeLayout(false);
            tbSoci.PerformLayout();
            tbCategorie.ResumeLayout(false);
            tbCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCategorie).EndInit();
            tbPrestazioni.ResumeLayout(false);
            tbPrestazioni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwPrestazioni).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOre).EndInit();
            tbStatistica.ResumeLayout(false);
            tbStatistica.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtTelefono;
        private Button btnSalva;
        private DataGridView dgwDebito;
        private DataGridView dgwSegreteria;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tbControl;
        private TabPage tbSoci;
        private TabPage tbPrestazioni;
        private TabPage tbStatistica;
        private TextBox txtPrestazione;
        private Label lblEsecutore;
        private Label lblPrestazione;
        private Label lblCategoria;
        private Button btnsalvaPrestazione;
        private ComboBox cbCategoria;
        private ComboBox cbRicevente;
        private Label lblRicevente;
        private ComboBox cbEsecutore;
        private DateTimePicker dtDataPrestazione;
        private Label lblData;
        private NumericUpDown numOre;
        private Label lblTotOre;
        private TabPage tbCategorie;
        private DataGridView dgwCategorie;
        private TextBox txtCategoria;
        private Label lblNomeCat;
        private Button btnSalvaCategoria;
        private Label lblDebito;
        private DataGridView dgwPrestazioni;
        private Label lblCategorie;
        private Label lblSegreteria;
        private Label lblPrestazioni;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCognome;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colOrePrestate;
        private DataGridViewTextBoxColumn colServizi;
        private DataGridViewTextBoxColumn colPrestazione;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colEsecutore;
        private DataGridViewTextBoxColumn colRicevente;
        private DataGridViewTextBoxColumn colOre;
        private DataGridViewTextBoxColumn colData;
    }
}