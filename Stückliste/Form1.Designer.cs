namespace Stückliste
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
            this.lbx_rohwaren = new System.Windows.Forms.ListBox();
            this.gbx_rohwaren = new System.Windows.Forms.GroupBox();
            this.lbx_rohFertig = new System.Windows.Forms.ListBox();
            this.btn_fertigwaren = new System.Windows.Forms.Button();
            this.tbx_rohEinheit = new System.Windows.Forms.TextBox();
            this.la_rohEinheit = new System.Windows.Forms.Label();
            this.tbx_rohArtNr = new System.Windows.Forms.TextBox();
            this.la_rohArtNr = new System.Windows.Forms.Label();
            this.tbx_rohBezeichnung = new System.Windows.Forms.TextBox();
            this.la_rohBezeichnung = new System.Windows.Forms.Label();
            this.btn_rohLoeschen = new System.Windows.Forms.Button();
            this.btn_rohAktualisieren = new System.Windows.Forms.Button();
            this.btn_rohHinzufuegen = new System.Windows.Forms.Button();
            this.gbx_fertigwaren = new System.Windows.Forms.GroupBox();
            this.pbx_fertigBild = new System.Windows.Forms.PictureBox();
            this.btn_fertigBild = new System.Windows.Forms.Button();
            this.btn_stueckLoeschen = new System.Windows.Forms.Button();
            this.btn_stueckAktualisieren = new System.Windows.Forms.Button();
            this.dgv_stueckliste = new System.Windows.Forms.DataGridView();
            this.rohIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rohBezCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mengeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rohEinheitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rohwaren = new System.Windows.Forms.Button();
            this.tbx_fertigPreis = new System.Windows.Forms.TextBox();
            this.tbx_fertigBild = new System.Windows.Forms.TextBox();
            this.la_fertigPreis = new System.Windows.Forms.Label();
            this.lbx_fertigwaren = new System.Windows.Forms.ListBox();
            this.la_fertigBild = new System.Windows.Forms.Label();
            this.tbx_fertigArtNr = new System.Windows.Forms.TextBox();
            this.la_fertigArtNr = new System.Windows.Forms.Label();
            this.tbx_fertigBezeichnung = new System.Windows.Forms.TextBox();
            this.la_fertigBezeichnung = new System.Windows.Forms.Label();
            this.btn_fertigLoeschen = new System.Windows.Forms.Button();
            this.btn_fertigAktualisieren = new System.Windows.Forms.Button();
            this.btn_fertigHinzufuegen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbx_rohwaren.SuspendLayout();
            this.gbx_fertigwaren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fertigBild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stueckliste)).BeginInit();
            this.SuspendLayout();
            // 
            // lbx_rohwaren
            // 
            this.lbx_rohwaren.FormattingEnabled = true;
            this.lbx_rohwaren.Location = new System.Drawing.Point(6, 19);
            this.lbx_rohwaren.Name = "lbx_rohwaren";
            this.lbx_rohwaren.Size = new System.Drawing.Size(197, 394);
            this.lbx_rohwaren.TabIndex = 0;
            this.lbx_rohwaren.SelectedIndexChanged += new System.EventHandler(this.lbx_rohwaren_SelectedIndexChanged);
            // 
            // gbx_rohwaren
            // 
            this.gbx_rohwaren.Controls.Add(this.lbx_rohFertig);
            this.gbx_rohwaren.Controls.Add(this.btn_fertigwaren);
            this.gbx_rohwaren.Controls.Add(this.tbx_rohEinheit);
            this.gbx_rohwaren.Controls.Add(this.lbx_rohwaren);
            this.gbx_rohwaren.Controls.Add(this.la_rohEinheit);
            this.gbx_rohwaren.Controls.Add(this.tbx_rohArtNr);
            this.gbx_rohwaren.Controls.Add(this.la_rohArtNr);
            this.gbx_rohwaren.Controls.Add(this.tbx_rohBezeichnung);
            this.gbx_rohwaren.Controls.Add(this.la_rohBezeichnung);
            this.gbx_rohwaren.Controls.Add(this.btn_rohLoeschen);
            this.gbx_rohwaren.Controls.Add(this.btn_rohAktualisieren);
            this.gbx_rohwaren.Controls.Add(this.btn_rohHinzufuegen);
            this.gbx_rohwaren.Location = new System.Drawing.Point(16, 12);
            this.gbx_rohwaren.Name = "gbx_rohwaren";
            this.gbx_rohwaren.Size = new System.Drawing.Size(772, 424);
            this.gbx_rohwaren.TabIndex = 2;
            this.gbx_rohwaren.TabStop = false;
            this.gbx_rohwaren.Text = "Rohwaren";
            // 
            // lbx_rohFertig
            // 
            this.lbx_rohFertig.FormattingEnabled = true;
            this.lbx_rohFertig.Location = new System.Drawing.Point(414, 19);
            this.lbx_rohFertig.Name = "lbx_rohFertig";
            this.lbx_rohFertig.Size = new System.Drawing.Size(352, 225);
            this.lbx_rohFertig.TabIndex = 5;
            // 
            // btn_fertigwaren
            // 
            this.btn_fertigwaren.Location = new System.Drawing.Point(691, 395);
            this.btn_fertigwaren.Name = "btn_fertigwaren";
            this.btn_fertigwaren.Size = new System.Drawing.Size(75, 23);
            this.btn_fertigwaren.TabIndex = 4;
            this.btn_fertigwaren.Text = "Fertigwaren";
            this.btn_fertigwaren.UseVisualStyleBackColor = true;
            this.btn_fertigwaren.Click += new System.EventHandler(this.btn_fertigwaren_Click);
            // 
            // tbx_rohEinheit
            // 
            this.tbx_rohEinheit.Location = new System.Drawing.Point(291, 71);
            this.tbx_rohEinheit.Name = "tbx_rohEinheit";
            this.tbx_rohEinheit.Size = new System.Drawing.Size(100, 20);
            this.tbx_rohEinheit.TabIndex = 3;
            // 
            // la_rohEinheit
            // 
            this.la_rohEinheit.AutoSize = true;
            this.la_rohEinheit.Location = new System.Drawing.Point(209, 74);
            this.la_rohEinheit.Name = "la_rohEinheit";
            this.la_rohEinheit.Size = new System.Drawing.Size(42, 13);
            this.la_rohEinheit.TabIndex = 2;
            this.la_rohEinheit.Text = "Einheit:";
            // 
            // tbx_rohArtNr
            // 
            this.tbx_rohArtNr.Location = new System.Drawing.Point(291, 19);
            this.tbx_rohArtNr.Name = "tbx_rohArtNr";
            this.tbx_rohArtNr.ReadOnly = true;
            this.tbx_rohArtNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_rohArtNr.TabIndex = 3;
            // 
            // la_rohArtNr
            // 
            this.la_rohArtNr.AutoSize = true;
            this.la_rohArtNr.Location = new System.Drawing.Point(209, 22);
            this.la_rohArtNr.Name = "la_rohArtNr";
            this.la_rohArtNr.Size = new System.Drawing.Size(76, 13);
            this.la_rohArtNr.TabIndex = 2;
            this.la_rohArtNr.Text = "Artikelnummer:";
            // 
            // tbx_rohBezeichnung
            // 
            this.tbx_rohBezeichnung.Location = new System.Drawing.Point(291, 45);
            this.tbx_rohBezeichnung.Name = "tbx_rohBezeichnung";
            this.tbx_rohBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.tbx_rohBezeichnung.TabIndex = 3;
            // 
            // la_rohBezeichnung
            // 
            this.la_rohBezeichnung.AutoSize = true;
            this.la_rohBezeichnung.Location = new System.Drawing.Point(209, 48);
            this.la_rohBezeichnung.Name = "la_rohBezeichnung";
            this.la_rohBezeichnung.Size = new System.Drawing.Size(72, 13);
            this.la_rohBezeichnung.TabIndex = 2;
            this.la_rohBezeichnung.Text = "Bezeichnung:";
            // 
            // btn_rohLoeschen
            // 
            this.btn_rohLoeschen.Location = new System.Drawing.Point(316, 166);
            this.btn_rohLoeschen.Name = "btn_rohLoeschen";
            this.btn_rohLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btn_rohLoeschen.TabIndex = 1;
            this.btn_rohLoeschen.Text = "Löschen";
            this.btn_rohLoeschen.Click += new System.EventHandler(this.btn_rohLoeschen_Click);
            // 
            // btn_rohAktualisieren
            // 
            this.btn_rohAktualisieren.Location = new System.Drawing.Point(316, 137);
            this.btn_rohAktualisieren.Name = "btn_rohAktualisieren";
            this.btn_rohAktualisieren.Size = new System.Drawing.Size(75, 23);
            this.btn_rohAktualisieren.TabIndex = 0;
            this.btn_rohAktualisieren.Text = "Aktualisieren";
            this.btn_rohAktualisieren.UseVisualStyleBackColor = true;
            this.btn_rohAktualisieren.Click += new System.EventHandler(this.btn_rohAktualisieren_Click);
            // 
            // btn_rohHinzufuegen
            // 
            this.btn_rohHinzufuegen.Location = new System.Drawing.Point(316, 108);
            this.btn_rohHinzufuegen.Name = "btn_rohHinzufuegen";
            this.btn_rohHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btn_rohHinzufuegen.TabIndex = 0;
            this.btn_rohHinzufuegen.Text = "Hinzufügen";
            this.btn_rohHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_rohHinzufuegen.Click += new System.EventHandler(this.btn_rohHinzufuegen_Click);
            // 
            // gbx_fertigwaren
            // 
            this.gbx_fertigwaren.Controls.Add(this.pbx_fertigBild);
            this.gbx_fertigwaren.Controls.Add(this.btn_fertigBild);
            this.gbx_fertigwaren.Controls.Add(this.btn_stueckLoeschen);
            this.gbx_fertigwaren.Controls.Add(this.btn_stueckAktualisieren);
            this.gbx_fertigwaren.Controls.Add(this.dgv_stueckliste);
            this.gbx_fertigwaren.Controls.Add(this.btn_rohwaren);
            this.gbx_fertigwaren.Controls.Add(this.tbx_fertigPreis);
            this.gbx_fertigwaren.Controls.Add(this.tbx_fertigBild);
            this.gbx_fertigwaren.Controls.Add(this.la_fertigPreis);
            this.gbx_fertigwaren.Controls.Add(this.lbx_fertigwaren);
            this.gbx_fertigwaren.Controls.Add(this.la_fertigBild);
            this.gbx_fertigwaren.Controls.Add(this.tbx_fertigArtNr);
            this.gbx_fertigwaren.Controls.Add(this.la_fertigArtNr);
            this.gbx_fertigwaren.Controls.Add(this.tbx_fertigBezeichnung);
            this.gbx_fertigwaren.Controls.Add(this.la_fertigBezeichnung);
            this.gbx_fertigwaren.Controls.Add(this.btn_fertigLoeschen);
            this.gbx_fertigwaren.Controls.Add(this.btn_fertigAktualisieren);
            this.gbx_fertigwaren.Controls.Add(this.btn_fertigHinzufuegen);
            this.gbx_fertigwaren.Location = new System.Drawing.Point(16, 12);
            this.gbx_fertigwaren.Name = "gbx_fertigwaren";
            this.gbx_fertigwaren.Size = new System.Drawing.Size(772, 424);
            this.gbx_fertigwaren.TabIndex = 4;
            this.gbx_fertigwaren.TabStop = false;
            this.gbx_fertigwaren.Text = "Fertigwaren";
            // 
            // pbx_fertigBild
            // 
            this.pbx_fertigBild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_fertigBild.Location = new System.Drawing.Point(209, 124);
            this.pbx_fertigBild.Name = "pbx_fertigBild";
            this.pbx_fertigBild.Size = new System.Drawing.Size(198, 176);
            this.pbx_fertigBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fertigBild.TabIndex = 8;
            this.pbx_fertigBild.TabStop = false;
            // 
            // btn_fertigBild
            // 
            this.btn_fertigBild.Location = new System.Drawing.Point(212, 306);
            this.btn_fertigBild.Name = "btn_fertigBild";
            this.btn_fertigBild.Size = new System.Drawing.Size(100, 23);
            this.btn_fertigBild.TabIndex = 7;
            this.btn_fertigBild.Text = "Bild";
            this.btn_fertigBild.UseVisualStyleBackColor = true;
            this.btn_fertigBild.Click += new System.EventHandler(this.btn_fertigBild_Click);
            // 
            // btn_stueckLoeschen
            // 
            this.btn_stueckLoeschen.Location = new System.Drawing.Point(596, 253);
            this.btn_stueckLoeschen.Name = "btn_stueckLoeschen";
            this.btn_stueckLoeschen.Size = new System.Drawing.Size(170, 23);
            this.btn_stueckLoeschen.TabIndex = 6;
            this.btn_stueckLoeschen.Text = "Stück löschen";
            this.btn_stueckLoeschen.UseVisualStyleBackColor = true;
            this.btn_stueckLoeschen.Click += new System.EventHandler(this.btn_stueckLoeschen_Click);
            // 
            // btn_stueckAktualisieren
            // 
            this.btn_stueckAktualisieren.Location = new System.Drawing.Point(414, 253);
            this.btn_stueckAktualisieren.Name = "btn_stueckAktualisieren";
            this.btn_stueckAktualisieren.Size = new System.Drawing.Size(170, 23);
            this.btn_stueckAktualisieren.TabIndex = 6;
            this.btn_stueckAktualisieren.Text = "Stückliste aktualisieren";
            this.btn_stueckAktualisieren.UseVisualStyleBackColor = true;
            this.btn_stueckAktualisieren.Click += new System.EventHandler(this.btn_stueckAktualisieren_Click);
            // 
            // dgv_stueckliste
            // 
            this.dgv_stueckliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stueckliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stueckliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rohIdCol,
            this.rohBezCol,
            this.mengeCol,
            this.rohEinheitCol});
            this.dgv_stueckliste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_stueckliste.Location = new System.Drawing.Point(414, 19);
            this.dgv_stueckliste.Name = "dgv_stueckliste";
            this.dgv_stueckliste.Size = new System.Drawing.Size(352, 228);
            this.dgv_stueckliste.TabIndex = 5;
            this.dgv_stueckliste.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_stueckliste_DataError);
            this.dgv_stueckliste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_stueckliste_EditingControlShowing);
            // 
            // rohIdCol
            // 
            this.rohIdCol.HeaderText = "ArtNr";
            this.rohIdCol.Name = "rohIdCol";
            this.rohIdCol.ReadOnly = true;
            // 
            // rohBezCol
            // 
            this.rohBezCol.HeaderText = "Bezeichnung";
            this.rohBezCol.Name = "rohBezCol";
            this.rohBezCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rohBezCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mengeCol
            // 
            this.mengeCol.HeaderText = "Menge";
            this.mengeCol.Name = "mengeCol";
            // 
            // rohEinheitCol
            // 
            this.rohEinheitCol.HeaderText = "Einheit";
            this.rohEinheitCol.Name = "rohEinheitCol";
            this.rohEinheitCol.ReadOnly = true;
            this.rohEinheitCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btn_rohwaren
            // 
            this.btn_rohwaren.Location = new System.Drawing.Point(691, 395);
            this.btn_rohwaren.Name = "btn_rohwaren";
            this.btn_rohwaren.Size = new System.Drawing.Size(75, 23);
            this.btn_rohwaren.TabIndex = 4;
            this.btn_rohwaren.Text = "Rohwaren";
            this.btn_rohwaren.UseVisualStyleBackColor = true;
            this.btn_rohwaren.Click += new System.EventHandler(this.btn_rohwaren_Click);
            // 
            // tbx_fertigPreis
            // 
            this.tbx_fertigPreis.Location = new System.Drawing.Point(291, 71);
            this.tbx_fertigPreis.Name = "tbx_fertigPreis";
            this.tbx_fertigPreis.Size = new System.Drawing.Size(100, 20);
            this.tbx_fertigPreis.TabIndex = 3;
            // 
            // tbx_fertigBild
            // 
            this.tbx_fertigBild.Location = new System.Drawing.Point(212, 335);
            this.tbx_fertigBild.Name = "tbx_fertigBild";
            this.tbx_fertigBild.Size = new System.Drawing.Size(372, 20);
            this.tbx_fertigBild.TabIndex = 3;
            // 
            // la_fertigPreis
            // 
            this.la_fertigPreis.AutoSize = true;
            this.la_fertigPreis.Location = new System.Drawing.Point(209, 74);
            this.la_fertigPreis.Name = "la_fertigPreis";
            this.la_fertigPreis.Size = new System.Drawing.Size(33, 13);
            this.la_fertigPreis.TabIndex = 2;
            this.la_fertigPreis.Text = "Preis:";
            // 
            // lbx_fertigwaren
            // 
            this.lbx_fertigwaren.FormattingEnabled = true;
            this.lbx_fertigwaren.Location = new System.Drawing.Point(6, 19);
            this.lbx_fertigwaren.Name = "lbx_fertigwaren";
            this.lbx_fertigwaren.Size = new System.Drawing.Size(197, 394);
            this.lbx_fertigwaren.TabIndex = 0;
            this.lbx_fertigwaren.SelectedIndexChanged += new System.EventHandler(this.lbx_fertigwaren_SelectedIndexChanged);
            // 
            // la_fertigBild
            // 
            this.la_fertigBild.AutoSize = true;
            this.la_fertigBild.Location = new System.Drawing.Point(209, 100);
            this.la_fertigBild.Name = "la_fertigBild";
            this.la_fertigBild.Size = new System.Drawing.Size(27, 13);
            this.la_fertigBild.TabIndex = 2;
            this.la_fertigBild.Text = "Bild:";
            // 
            // tbx_fertigArtNr
            // 
            this.tbx_fertigArtNr.Location = new System.Drawing.Point(291, 19);
            this.tbx_fertigArtNr.Name = "tbx_fertigArtNr";
            this.tbx_fertigArtNr.ReadOnly = true;
            this.tbx_fertigArtNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_fertigArtNr.TabIndex = 3;
            // 
            // la_fertigArtNr
            // 
            this.la_fertigArtNr.AutoSize = true;
            this.la_fertigArtNr.Location = new System.Drawing.Point(209, 22);
            this.la_fertigArtNr.Name = "la_fertigArtNr";
            this.la_fertigArtNr.Size = new System.Drawing.Size(76, 13);
            this.la_fertigArtNr.TabIndex = 2;
            this.la_fertigArtNr.Text = "Artikelnummer:";
            // 
            // tbx_fertigBezeichnung
            // 
            this.tbx_fertigBezeichnung.Location = new System.Drawing.Point(291, 45);
            this.tbx_fertigBezeichnung.Name = "tbx_fertigBezeichnung";
            this.tbx_fertigBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.tbx_fertigBezeichnung.TabIndex = 3;
            // 
            // la_fertigBezeichnung
            // 
            this.la_fertigBezeichnung.AutoSize = true;
            this.la_fertigBezeichnung.Location = new System.Drawing.Point(209, 48);
            this.la_fertigBezeichnung.Name = "la_fertigBezeichnung";
            this.la_fertigBezeichnung.Size = new System.Drawing.Size(72, 13);
            this.la_fertigBezeichnung.TabIndex = 2;
            this.la_fertigBezeichnung.Text = "Bezeichnung:";
            // 
            // btn_fertigLoeschen
            // 
            this.btn_fertigLoeschen.Location = new System.Drawing.Point(374, 390);
            this.btn_fertigLoeschen.Name = "btn_fertigLoeschen";
            this.btn_fertigLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btn_fertigLoeschen.TabIndex = 1;
            this.btn_fertigLoeschen.Text = "Löschen";
            this.btn_fertigLoeschen.Click += new System.EventHandler(this.btn_fertigLoeschen_Click);
            // 
            // btn_fertigAktualisieren
            // 
            this.btn_fertigAktualisieren.Location = new System.Drawing.Point(293, 390);
            this.btn_fertigAktualisieren.Name = "btn_fertigAktualisieren";
            this.btn_fertigAktualisieren.Size = new System.Drawing.Size(75, 23);
            this.btn_fertigAktualisieren.TabIndex = 0;
            this.btn_fertigAktualisieren.Text = "Aktualisieren";
            this.btn_fertigAktualisieren.UseVisualStyleBackColor = true;
            this.btn_fertigAktualisieren.Click += new System.EventHandler(this.btn_fertigAktualisieren_Click);
            // 
            // btn_fertigHinzufuegen
            // 
            this.btn_fertigHinzufuegen.Location = new System.Drawing.Point(212, 390);
            this.btn_fertigHinzufuegen.Name = "btn_fertigHinzufuegen";
            this.btn_fertigHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btn_fertigHinzufuegen.TabIndex = 0;
            this.btn_fertigHinzufuegen.Text = "Hinzufügen";
            this.btn_fertigHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_fertigHinzufuegen.Click += new System.EventHandler(this.btn_fertigHinzufuegen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_fertigwaren);
            this.Controls.Add(this.gbx_rohwaren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbx_rohwaren.ResumeLayout(false);
            this.gbx_rohwaren.PerformLayout();
            this.gbx_fertigwaren.ResumeLayout(false);
            this.gbx_fertigwaren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fertigBild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stueckliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_rohwaren;
        private System.Windows.Forms.GroupBox gbx_rohwaren;
        private System.Windows.Forms.TextBox tbx_rohEinheit;
        private System.Windows.Forms.Label la_rohEinheit;
        private System.Windows.Forms.TextBox tbx_rohArtNr;
        private System.Windows.Forms.Label la_rohArtNr;
        private System.Windows.Forms.TextBox tbx_rohBezeichnung;
        private System.Windows.Forms.Label la_rohBezeichnung;
        private System.Windows.Forms.Button btn_rohLoeschen;
        private System.Windows.Forms.Button btn_rohHinzufuegen;
        private System.Windows.Forms.Button btn_rohAktualisieren;
        private System.Windows.Forms.GroupBox gbx_fertigwaren;
        private System.Windows.Forms.Button btn_rohwaren;
        private System.Windows.Forms.TextBox tbx_fertigBild;
        private System.Windows.Forms.ListBox lbx_fertigwaren;
        private System.Windows.Forms.Label la_fertigBild;
        private System.Windows.Forms.TextBox tbx_fertigArtNr;
        private System.Windows.Forms.Label la_fertigArtNr;
        private System.Windows.Forms.TextBox tbx_fertigBezeichnung;
        private System.Windows.Forms.Label la_fertigBezeichnung;
        private System.Windows.Forms.Button btn_fertigLoeschen;
        private System.Windows.Forms.Button btn_fertigAktualisieren;
        private System.Windows.Forms.Button btn_fertigHinzufuegen;
        private System.Windows.Forms.Button btn_fertigwaren;
        private System.Windows.Forms.TextBox tbx_fertigPreis;
        private System.Windows.Forms.Label la_fertigPreis;
        private System.Windows.Forms.DataGridView dgv_stueckliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn rohIdCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn rohBezCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rohEinheitCol;
        private System.Windows.Forms.Button btn_stueckAktualisieren;
        private System.Windows.Forms.Button btn_stueckLoeschen;
        private System.Windows.Forms.ListBox lbx_rohFertig;
        private System.Windows.Forms.Button btn_fertigBild;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbx_fertigBild;
    }
}

