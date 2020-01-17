using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stückliste
{
    internal class Database
    {
        private MySqlConnection con = new MySqlConnection("SERVER=localhost;UID=root;Password=root;DATABASE=stueckliste;");
        private MySqlCommand com;

        private void OpenDB()
        {
            con.Open();
        }

        private void CloseDB()
        {
            if (con != null)
                con.Close();
        }

        public List<Rohware> GetRohwaren()
        {
            var rohwarenList = new List<Rohware>();

            try
            {
                OpenDB();
                com = con.CreateCommand();
                com.CommandText = "SELECT * FROM tbl_roh;";

                var reader = com.ExecuteReader();

                while (reader.Read())
                {
                    var rohware = new Rohware(
                        reader.GetInt32(0),
                        !reader.IsDBNull(1) ? reader.GetString(1) : "", // Bezeichnung
                        !reader.IsDBNull(2) ? reader.GetString(2) : ""  // Einheit
                        );
                    rohwarenList.Add(rohware);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GR: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return rohwarenList;
        }

        public List<Fertigware> GetFertigwaren()
        {
            var fertigwarenList = new List<Fertigware>();

            try
            {
                OpenDB();
                com = con.CreateCommand();
                com.CommandText = "SELECT * FROM tbl_fertig;";

                var reader = com.ExecuteReader();

                while (reader.Read())
                {
                    var fertigware = new Fertigware(
                        reader.GetInt32(0),
                        !reader.IsDBNull(1) ? reader.GetString(1) : "", // Bezeichnung
                        !reader.IsDBNull(2) ? reader.GetString(2) : "", // Bildpfad
                        !reader.IsDBNull(3) ? reader.GetDouble(3) : 0.0 // Preis
                        );
                    fertigwarenList.Add(fertigware);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GF: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return fertigwarenList;
        }

        public List<Stueckliste> GetStuecklisten()
        {
            var stuecklistenList = new List<Stueckliste>();

            try
            {
                OpenDB();
                com = con.CreateCommand();
                com.CommandText = "SELECT * FROM v_stueckliste;";

                var reader = com.ExecuteReader();

                while (reader.Read())
                {
                    var stueckliste = new Stueckliste(
                        !reader.IsDBNull(0) ? reader.GetInt32(0) : -1,      // fk_fertig_id
                        !reader.IsDBNull(1) ? reader.GetString(1) : "",     // fertig_bezeichnung
                        !reader.IsDBNull(2) ? reader.GetInt32(2) : -1,      // fk_roh_id
                        !reader.IsDBNull(3) ? reader.GetString(3) : "",     // roh_bezeichnung
                        !reader.IsDBNull(4) ? reader.GetDouble(4) : 0.0,    // Menge
                        !reader.IsDBNull(5) ? reader.GetString(5) : ""      // Einheit
                        );
                    stuecklistenList.Add(stueckliste);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GS: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
            return stuecklistenList;
        }

        public void AddRohware(Rohware rohware)
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();

                com.CommandText = String.Format("INSERT INTO tbl_roh VALUES (null, '{0}', '{1}');", rohware.Bezeichnung, rohware.Einheit);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        public void AddFertigware(Fertigware fertigware)
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();

                com.CommandText = String.Format("INSERT INTO tbl_fertig VALUES (null, '{0}', '{1}', {2});", fertigware.Bezeichnung, fertigware.Bild.Replace("\\", "\\\\"), fertigware.Preis.ToString().Replace(',', '.'));
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AF: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        public void AddStueckliste(Stueckliste stueckliste)
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();

                com.CommandText = String.Format("INSERT INTO tbl_stueckliste VALUES ({0}, {1}, {2});", stueckliste.FertigId.ToString(), stueckliste.RohId.ToString(), stueckliste.Menge.ToString().Replace(',', '.'));
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AS: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        public void DeleteRohware(int rohNr)
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();

                com.CommandText = String.Format("DELETE FROM tbl_roh WHERE roh_id = {0}", rohNr);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("DR: " + ex.Message);
                MessageBox.Show(@"
Möglicherweise existieren noch Fertigwaren, die diese Rohware nutzen.

DR: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        public void DeleteFertigware(int fertigNr)
        {
            DeleteStuecklisteVonFertigware(fertigNr);
            try
            {
                OpenDB();
                com = con.CreateCommand();

                com.CommandText = String.Format("DELETE FROM tbl_fertig WHERE fertig_id = {0}", fertigNr.ToString());
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DF: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        public void DeleteStuecklisteVonFertigware(int fertigNr)
        {
            {
                try
                {
                    OpenDB();
                    com = con.CreateCommand();

                    com.CommandText = String.Format("DELETE FROM tbl_stueckliste WHERE fk_fertig_id = {0}", fertigNr.ToString());
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DSVF: " + ex.Message);
                }
                finally
                {
                    CloseDB();
                }
            }
        }

        public void DeleteStueckliste(int fertigNr, int rohNr)
        {
            {
                try
                {
                    OpenDB();
                    com = con.CreateCommand();

                    com.CommandText = String.Format("DELETE FROM tbl_stueckliste WHERE fk_fertig_id = {0} AND fk_roh_id = {1}", fertigNr.ToString(), rohNr.ToString());
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DS: " + ex.Message);
                }
                finally
                {
                    CloseDB();
                }
            }
        }

        public void UpdateRohware(Rohware rohware)
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();

                com.CommandText = String.Format("UPDATE tbl_roh SET roh_bezeichnung = '{0}', roh_einheit = '{1}' WHERE roh_id = {2};", rohware.Bezeichnung, rohware.Einheit, rohware.ArtNr.ToString());
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UR: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        public void UpdateFertigware(Fertigware fertigware)
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();

                com.CommandText = String.Format(@"UPDATE tbl_fertig SET fertig_bezeichnung = '{0}', fertig_bild = '{1}', fertig_preis = {2} WHERE fertig_id = {3};", fertigware.Bezeichnung, fertigware.Bild.Replace("\\", "\\\\"), fertigware.Preis.ToString().Replace(',', '.'), fertigware.ArtNr.ToString());
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UF: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        public void UpdateStueckliste(Stueckliste stueckliste)
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();
                if (stueckliste.Menge > 0)
                    com.CommandText = String.Format("INSERT INTO tbl_stueckliste VALUES ({0}, {1}, {2}) ON DUPLICATE KEY UPDATE stueckliste_menge = {2};", stueckliste.FertigId.ToString(), stueckliste.RohId.ToString(), stueckliste.Menge.ToString().Replace(',', '.'));
                else
                    com.CommandText = String.Format("DELETE FROM tbl_stueckliste WHERE fk_fertig_id = {0} AND fk_roh_id = {1}", stueckliste.FertigId.ToString(), stueckliste.RohId.ToString());
                //com.CommandText = String.Format("UPDATE tbl_stueckliste SET fk_fertig_id = {0}, fk_roh_id = {1}, stueckliste_menge = {2} WHERE fk_fertig_id = {0} AND fk_roh_id = {1};", stueckliste.FertigId.ToString(), stueckliste.RohId.ToString(), stueckliste.Menge.ToString().Replace(',', '.'));
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UR: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }
    }
}