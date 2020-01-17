using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Stückliste
{
    public partial class Form1 : Form
    {
        private Database db;
        private List<Fertigware> fertigwarenList;
        private List<Stueckliste> stuecklisteList;
        private List<Rohware> rohwarenList;
        public Form1()
        {
            InitializeComponent();

            db = new Database();
            GetLists();

            gbx_rohwaren.Hide();
            PopulateLbxFertigwaren();
            PopulateLbxRohwaren();
            CreateColumns();
        }

        private void GetLists()
        {
            fertigwarenList = db.GetFertigwaren();
            rohwarenList = db.GetRohwaren();
            stuecklisteList = db.GetStuecklisten();
        }

        private void PopulateLbxRohwaren()
        {
            lbx_rohwaren.Items.Clear();
            foreach (var item in rohwarenList)
                lbx_rohwaren.Items.Add(item);
        }

        private void PopulateLbxFertigwaren()
        {
            lbx_fertigwaren.Items.Clear();
            foreach (var item in fertigwarenList)
                lbx_fertigwaren.Items.Add(item);
        }

        private void PopulateLbxRohFertig(int rohNr)
        {
            lbx_rohFertig.Items.Clear();
            foreach (Stueckliste fertigware in from x in stuecklisteList where x.RohId == rohNr select x)
                lbx_rohFertig.Items.Add(fertigware.FertigwareString());
        }

        private void lbx_rohwaren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_rohwaren.SelectedIndex > -1)
            {
                var rohware = rohwarenList[lbx_rohwaren.SelectedIndex];
                tbx_rohArtNr.Text = rohware.ArtNr.ToString();
                tbx_rohBezeichnung.Text = rohware.Bezeichnung;
                tbx_rohEinheit.Text = rohware.Einheit;

                PopulateLbxRohFertig(rohware.ArtNr);
            }
        }

        private void btn_rohHinzufuegen_Click(object sender, EventArgs e)
        {
            var rohware = new Rohware(-1, tbx_rohBezeichnung.Text, tbx_rohEinheit.Text);
            db.AddRohware(rohware);
            GetLists();
            PopulateLbxRohwaren();
            if (lbx_fertigwaren.SelectedIndex > -1)
                PopulateDgvStueckliste();
        }

        private void btn_rohLoeschen_Click(object sender, EventArgs e)
        {
            if (lbx_rohwaren.SelectedIndex > -1)
            {
                if (MessageBox.Show("Wirklich löschen?", "Nachfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.DeleteRohware(rohwarenList[lbx_rohwaren.SelectedIndex].ArtNr);
                    GetLists();
                    PopulateLbxRohwaren();
                    if (lbx_fertigwaren.SelectedIndex > -1)
                        PopulateDgvStueckliste();
                }
            }
        }

        private void btn_rohAktualisieren_Click(object sender, EventArgs e)
        {
            if (lbx_rohwaren.SelectedIndex > -1)
            {
                var rohware = new Rohware(Convert.ToInt32(tbx_rohArtNr.Text), tbx_rohBezeichnung.Text, tbx_rohEinheit.Text);
                db.UpdateRohware(rohware);
                GetLists();
                PopulateLbxRohwaren();
                if (lbx_fertigwaren.SelectedIndex > -1)
                    PopulateDgvStueckliste();
            }
        }

        private void btn_rohwaren_Click(object sender, EventArgs e)
        {
            gbx_fertigwaren.Hide();
            gbx_rohwaren.Show();
        }

        private void btn_fertigwaren_Click(object sender, EventArgs e)
        {
            gbx_fertigwaren.Show();
            gbx_rohwaren.Hide();
        }

        private void btn_fertigLoeschen_Click(object sender, EventArgs e)
        {
            if (lbx_fertigwaren.SelectedIndex > -1)
            {
                if (MessageBox.Show("Wirklich löschen?", "Nachfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.DeleteFertigware(fertigwarenList[lbx_fertigwaren.SelectedIndex].ArtNr);
                    GetLists();
                    PopulateLbxFertigwaren();
                    dgv_stueckliste.Rows.Clear();
                }
            }
        }

        private void CreateColumns()
        {
            //dgv_stueckliste.Columns.Add("rohIdCol", "ArtNr");
            //dgv_stueckliste.Columns.Add("rohBezCol", "Bezeichnung");
            //dgv_stueckliste.Columns.Add("mengeCol", "Menge");
            //dgv_stueckliste.Columns.Add("rohEinheitCol", "Einheit");

            dgv_stueckliste.Columns[0].ValueType = typeof(int);
            dgv_stueckliste.Columns[1].ValueType = typeof(string);
            dgv_stueckliste.Columns[2].ValueType = typeof(double);
            dgv_stueckliste.Columns[3].ValueType = typeof(string);
        }

        private void PopulateDgvStueckliste()
        {
            if (lbx_fertigwaren.SelectedIndex > -1)
            {
                dgv_stueckliste.Rows.Clear();
                int fertigID = fertigwarenList[lbx_fertigwaren.SelectedIndex].ArtNr;
                foreach (var item in from x in stuecklisteList where x.FertigId == fertigID select x)
                    dgv_stueckliste.Rows.Add(item.RohId, item.RohBez, item.Menge.ToString(), item.Einheit);
            }

            foreach (DataGridViewRow row in dgv_stueckliste.Rows)
            {
                var cbxCell = (DataGridViewComboBoxCell)row.Cells[1];
                string bez = "";
                foreach (var item in rohwarenList)
                {
                    if (item.Bezeichnung != bez)
                    {
                        cbxCell.Items.Add(item.Bezeichnung);
                        bez = item.Bezeichnung;
                    }
                }
            }
        }

        private void lbx_fertigwaren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_fertigwaren.SelectedIndex > -1)
            {
                var fertigware = fertigwarenList[lbx_fertigwaren.SelectedIndex];
                tbx_fertigArtNr.Text = fertigware.ArtNr.ToString();
                tbx_fertigBezeichnung.Text = fertigware.Bezeichnung;
                tbx_fertigBild.Text = fertigware.Bild;
                tbx_fertigPreis.Text = fertigware.Preis.ToString("0.00");
                try
                {
                    pbx_fertigBild.Image = new Bitmap(fertigware.Bild);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    pbx_fertigBild.Image = null;
                }
            }
            PopulateDgvStueckliste();
        }

        private void btn_fertigHinzufuegen_Click(object sender, EventArgs e)
        {
            double.TryParse(tbx_fertigPreis.Text, out double preis);
            var fertigware = new Fertigware(-1, tbx_fertigBezeichnung.Text, tbx_fertigBild.Text, preis);
            db.AddFertigware(fertigware);
            GetLists();
            PopulateLbxFertigwaren();
        }

        private void dgv_stueckliste_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_fertigAktualisieren_Click(object sender, EventArgs e)
        {
            if (lbx_fertigwaren.SelectedIndex > -1)
            {
                double.TryParse(tbx_fertigPreis.Text, out double preis);
                var fertigware = new Fertigware(Convert.ToInt32(tbx_fertigArtNr.Text), tbx_fertigBezeichnung.Text, tbx_fertigBild.Text, preis);
                db.UpdateFertigware(fertigware);
                GetLists();
                PopulateLbxFertigwaren();
            }
        }

        private void dgv_stueckliste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell.ColumnIndex == 1)
            {
                ComboBox cbx = (ComboBox)e.Control;
                if (cbx != null)
                {
                    cbx.SelectionChangeCommitted -= new EventHandler(cbx_SelectedIndexChanged);
                    cbx.SelectionChangeCommitted += new EventHandler(cbx_SelectedIndexChanged);
                }
            }
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            //int rowIndex = dgv_stueckliste.CurrentRow.Index;
            DataGridViewRow row = dgv_stueckliste.CurrentRow;
            int index = cbx.SelectedIndex;
            row.Cells[0].Value = rohwarenList[index].ArtNr;
            row.Cells[3].Value = rohwarenList[index].Einheit;
        }

        private void btn_stueckAktualisieren_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dgv_stueckliste.Rows)
            for (int i = 0; i < dgv_stueckliste.RowCount - 1; i++)
            {
                var row = dgv_stueckliste.Rows[i];
                double.TryParse(row.Cells[2].Value.ToString(), out double menge);
                if (row.Cells[2].Value != null)
                {
                    Stueckliste stueckliste = new Stueckliste(
                               Convert.ToInt32(tbx_fertigArtNr.Text),
                               tbx_fertigBezeichnung.Text,
                               Convert.ToInt32(row.Cells[0].Value),
                               row.Cells[1].Value.ToString(),
                               menge,
                               row.Cells[3].Value.ToString()
                               );
                    //foreach (DataGridViewCell cell in row.Cells)
                    //    Console.WriteLine(cell.ValueType);
                    db.UpdateStueckliste(stueckliste);
                }
            }
            GetLists();
            PopulateDgvStueckliste();
        }
        private void btn_stueckLoeschen_Click(object sender, EventArgs e)
        {
            if (dgv_stueckliste.CurrentRow.Index > -1 && dgv_stueckliste.CurrentRow.Index < dgv_stueckliste.RowCount - 1)
            {
                int.TryParse(tbx_fertigArtNr.Text, out int fertigNr);
                int.TryParse(dgv_stueckliste.CurrentRow.Cells[0].Value.ToString(), out int rohNr);
                db.DeleteStueckliste(fertigNr, rohNr);
                GetLists();
                PopulateDgvStueckliste();
            }
        }

        private void btn_fertigBild_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            openFileDialog1.Filter =
"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
"All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbx_fertigBild.Text = openFileDialog1.FileName;
                pbx_fertigBild.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}