using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json.Nodes;
using Microsoft.VisualBasic.Devices;
using System.Net.Sockets;
using System.Data;
using System.Collections.Generic;
using System.Resources.Extensions;
using System.Linq;

namespace BancaDelTempo
{

    public partial class bancaTempo : Form
    {
        private string pathSoci = "../../../Resources/Soci.json";
        private string pathCategorie = "../../../Resources/Categorie.json";
        private string pathPrestazioni = "../../../Resources/Prestazioni.json";
        private List<object> lista = new List<object>();

        public bancaTempo()
        {
            InitializeComponent();
        }

        //funzione per eliminare il contenuto delle textbox
        private void pulisciTxt(TextBox[] txt)
        {
            foreach (TextBox item in txt)
            {
                item.Clear();
            }
        }
        //funzione per eliminare il contenuto delle combobox
        private void pulisciCombo(ComboBox[] cb)
        {
            foreach (ComboBox item in cb)
            {
                item.SelectedIndex = -1;
            }
        }

        //funzione per generare un nuovo id
        private int impostaID(string path)
        {
            int id = 1;
            if (File.Exists(path))
            {
                lista = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText(path));
                if (lista != null)
                {
                    id = lista.Count + 1;
                }
            }
            return id;
        }

        //funzione per popolare la combobox relativa ai soci nella tab "Prestazioni"
        private void comboboxSoci(string path, ComboBox cb)
        {
            cb.Items.Clear();
            List<Soci> listaSoci = new List<Soci>();
            listaSoci = JsonConvert.DeserializeObject<List<Soci>>(File.ReadAllText(path));
            if (listaSoci != null)
            {
                foreach (Soci s in listaSoci)
                {
                    cb.Items.Add($"{s.Cognome} {s.Nome}");

                }
            }
        }

        //funzione per aggiungere i due soci (Esecutore e Ricevitore) alla Prestazione salvata
        private Soci aggiungiRiceventeEsecutore(string path, int id)
        {
            List<Soci> listaSoci = new List<Soci>();
            listaSoci = JsonConvert.DeserializeObject<List<Soci>>(File.ReadAllText(path));

            if (id >= 0)
            {
                Soci socio = new Soci(listaSoci[id].IdSocio, listaSoci[id].Cognome, listaSoci[id].Nome, listaSoci[id].Telefono, listaSoci[id].OrePrestate, listaSoci[id].OreRicevute);
                return socio;
            }
            else
            {
                throw new Exception("Aggiungere un Socio prima di procedere");
            }
        }

        //funzione per popolare la combobox relativa alle categorie nella tab "Prestazioni"
        private void comboboxCategorie(string path, ComboBox cb)
        {
            cb.Items.Clear();
            List<Categorie> listaCat = new List<Categorie>();
            listaCat = JsonConvert.DeserializeObject<List<Categorie>>(File.ReadAllText(path));
            if (listaCat != null)
            {
                foreach (Categorie s in listaCat)
                {
                    cb.Items.Add($"{s.NomeCategoria}");
                }
            }
        }

        //funzione per aggiungere la Categoria alla Prestazione salvata
        private Categorie aggiuntiCategoria(string path, int id)
        {
            List<Categorie> listaCat = new List<Categorie>();
            listaCat = JsonConvert.DeserializeObject<List<Categorie>>(File.ReadAllText(path));
            if (id >= 0)
            {
                Categorie cat = new Categorie(listaCat[id].IdCategoria, listaCat[id].NomeCategoria);
                return cat;
            }
            else
            {
                throw new Exception("Aggiungere una Categoria prima di procedere");
            }
        }


        /// <summary>
        /// funzione di scrittura file JSON - viene utilizzata ogni qual volta si vogliono salvare dei dati in un file JSON
        /// </summary>
        /// <param name="obj">l'oggetto da modificare (Socio, Categoria, Prestazione);</param>
        /// <param name="path">percorso del file da modificare; </param>
        /// <param name="tipo">variabile di gestione, per inserire il messaggio di conferma opportuno</param>
        private void scriviJson(object obj, string path, int tipo)
        {
            string azione = "";

            try
            {
                lista = new List<object>();
                if (File.Exists(path))
                {
                    lista = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText(path));
                    if (lista == null)
                    {
                        lista = new List<object> { obj };
                    }
                    else
                    {
                        lista.Add(obj);
                    }

                    string json = JsonConvert.SerializeObject(lista);
                    File.WriteAllText(path, json);
                }
                else
                {
                    File.Create(path);
                    lista.Add(obj);
                    string json = JsonConvert.SerializeObject(lista);
                    File.WriteAllText(path, json);
                }

                //swicth per gestire la variabile da inserire nel messaggio di inseriemento dati
                switch (tipo)
                {
                    case 1:
                        azione = "Socio";
                        break;
                    case 2:
                        azione = "Categoria";
                        break;
                    case 3:
                        azione = "Prestazione";
                        break;
                }
                MessageBox.Show($"Inserimento {azione} completato", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore");
            }
        }

        //funzione per modificare le ore Prestate e Lavorate di un determinato Socio
        private void modificaJson(int id, int ore, string path, bool ricevuto)
        {
            List<Soci> listaSoci = new List<Soci>();
            listaSoci = JsonConvert.DeserializeObject<List<Soci>>(File.ReadAllText(path));

            if (listaSoci != null)
            {
                if (ricevuto)
                {
                    listaSoci[id].OreRicevute += ore;
                }
                else
                {
                    listaSoci[id].OrePrestate += ore;
                }

                string json = JsonConvert.SerializeObject(listaSoci);
                File.WriteAllText(path, json);
            }
        }

        //evento salvataggio Soci - TAB Soci
        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                Soci socio = new Soci(impostaID(pathSoci), txtCognome.Text, txtNome.Text, txtTelefono.Text, 0, 0);
                scriviJson((object)socio, pathSoci, 1);
                pulisciTxt(new TextBox[] { txtCognome, txtNome, txtTelefono });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Griglia Soci in "DEBITO" - TAB Soci
        private void compilaDataGridDebito(string path)
        {
            dgwDebito.DataSource = null;
            List<Soci> listaSoci = new List<Soci>();
            List<Soci> listaTemp = new List<Soci>();
            if (File.Exists(path))
            {
                listaTemp = JsonConvert.DeserializeObject<List<Soci>>(File.ReadAllText(path));
                if (listaTemp != null)
                {
                    foreach (Soci s in listaTemp)
                    {
                        if (s.OreRicevute > s.OrePrestate)
                        {
                            listaSoci.Add(s);
                        }
                    }

                    dgwDebito.DataSource = listaSoci;

                    dgwDebito.Columns[0].Visible = false;
                    dgwDebito.Columns[1].HeaderText = "Cognome";
                    dgwDebito.Columns[2].HeaderText = "Nome";
                    dgwDebito.Columns[3].HeaderText = "Telefono";
                    dgwDebito.Columns[4].HeaderText = "Ore Prestate";
                    dgwDebito.Columns[5].HeaderText = "Ore Ricevute";
                }
            }
        }

        //evento salvataggio Categoria - TAB Categorie
        private void btnSalvaCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categorie cat = new Categorie(impostaID(pathCategorie), txtCategoria.Text);
                scriviJson((object)cat, pathCategorie, 2);
                compilaDataGridCategorie(pathCategorie);
                pulisciTxt(new TextBox[] { txtCategoria });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Griglia Categorie - TAB Categorie
        private void compilaDataGridCategorie(string path)
        {
            dgwCategorie.DataSource = null;
            if (File.Exists(path))
            {
                lista = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText(path));
                if (lista != null)
                {
                    dgwCategorie.DataSource = lista;

                    dgwCategorie.Columns[0].Visible = false;
                    dgwCategorie.Columns[1].HeaderText = "Nome Categoria";
                }
            }
        }

        //evento salvataggio Prestazione - TAB Prestazioni
        private void btnsalvaPrestazione_Click(object sender, EventArgs e)
        {
            try
            {

                Prestazioni prest = new Prestazioni(txtPrestazione.Text, aggiuntiCategoria(pathCategorie, cbCategoria.SelectedIndex), aggiungiRiceventeEsecutore(pathSoci, cbEsecutore.SelectedIndex), aggiungiRiceventeEsecutore(pathSoci, cbRicevente.SelectedIndex), int.Parse(numOre.Value.ToString()), DateTime.Parse(dtDataPrestazione.Value.ToString("dd-MM-yyyy")));
                scriviJson((object)prest, pathPrestazioni, 3);
                modificaJson(cbEsecutore.SelectedIndex, int.Parse(numOre.Value.ToString()), pathSoci, false);
                modificaJson(cbRicevente.SelectedIndex, int.Parse(numOre.Value.ToString()), pathSoci, true);
                compilaDataGridPrestazioni(pathPrestazioni);
                pulisciTxt(new TextBox[] { txtPrestazione });
                pulisciCombo(new ComboBox[] { cbCategoria, cbEsecutore, cbRicevente });
                numOre.Value = 0;
                dtDataPrestazione.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Griglia Prestazioni - TAB Prestazioni
        private void compilaDataGridPrestazioni(string path)
        {
            dgwPrestazioni.Rows.Clear();
            List<Prestazioni> listaTemp = new List<Prestazioni>();
            List<Soci> listaSoci = new List<Soci>();
            List<Categorie> listaCategorie = new List<Categorie>();
            if (File.Exists(path) && File.Exists(pathSoci) && File.Exists(pathPrestazioni))
            {
                listaTemp = JsonConvert.DeserializeObject<List<Prestazioni>>(File.ReadAllText(path));
                listaSoci = JsonConvert.DeserializeObject<List<Soci>>(File.ReadAllText(pathSoci));
                listaCategorie = JsonConvert.DeserializeObject<List<Categorie>>(File.ReadAllText(pathCategorie));
                if (listaTemp != null && listaSoci != null && listaCategorie != null)
                {
                    for (int i = 0; i < listaTemp.Count; i++)
                    {
                        dgwPrestazioni.Rows.Add();
                        dgwPrestazioni.Rows[i].Cells[0].Value = listaTemp[i].NomePrestazione;
                        foreach (Categorie cat in listaCategorie)
                        {
                            if (cat.IdCategoria == listaTemp[i].CategoriaPrestazione.IdCategoria)
                            {
                                dgwPrestazioni.Rows[i].Cells[1].Value = cat.NomeCategoria;
                                break;
                            }
                        }
                        foreach (Soci s in listaSoci)
                        {
                            if (s.IdSocio == listaTemp[i].IdEsecutore.IdSocio)
                            {
                                dgwPrestazioni.Rows[i].Cells[2].Value = s.Cognome + " " + s.Nome;
                            }
                            if (s.IdSocio == listaTemp[i].IdRicevente.IdSocio)
                            {
                                dgwPrestazioni.Rows[i].Cells[3].Value = s.Cognome + " " + s.Nome;
                            }
                        }
                        dgwPrestazioni.Rows[i].Cells[4].Value = listaTemp[i].TotaleOre;
                        dgwPrestazioni.Rows[i].Cells[5].Value = listaTemp[i].Data.ToString("dd-MM-yyyy");
                        dgwPrestazioni.Sort(dgwPrestazioni.Columns[4], System.ComponentModel.ListSortDirection.Descending);
                    }
                }
            }
        }

        //Griglia Soci + servizi "Segreteria" - TAB Statistiche
        private void compilaDataGridSegreteria(string path)
        {
            dgwSegreteria.Rows.Clear();
            List<Soci> listaSoci = new List<Soci>();
            List<Prestazioni> listaPres = new List<Prestazioni>();
            if (File.Exists(path))
            {
                listaPres = JsonConvert.DeserializeObject<List<Prestazioni>>(File.ReadAllText(path));
                listaSoci = JsonConvert.DeserializeObject<List<Soci>>(File.ReadAllText(pathSoci));
                List<string[]> temp = new List<string[]>();

                if (listaPres != null && listaSoci != null)
                {
                    foreach (Prestazioni pre in listaPres)
                    {
                        if (pre.CategoriaPrestazione.NomeCategoria == "Segreteria")
                        {
                            for (int i = 0; i < listaSoci.Count; i++)
                            {
                                if (pre.IdEsecutore.IdSocio == listaSoci[i].IdSocio)
                                {
                                    //inserisco in una lista temporanea i soci che hanno fatto un servizio di segreteria
                                    string[] socio = new string[5];
                                    socio[0] = listaSoci[pre.IdEsecutore.IdSocio - 1].IdSocio.ToString();
                                    socio[1] = listaSoci[pre.IdEsecutore.IdSocio - 1].Nome;
                                    socio[2] = listaSoci[pre.IdEsecutore.IdSocio - 1].Cognome;
                                    socio[3] = listaSoci[pre.IdEsecutore.IdSocio - 1].Telefono;
                                    socio[4] = pre.TotaleOre.ToString();
                                    temp.Add(socio);
                                }
                            }
                        }
                    }
                    //controllo che nella lista temporanea non ci siano duplicati, e in tal caso sommo il totale delle ore riferite allo stesso socio
                    for (int i = 0; i < temp.Count; i++)
                    {
                        for (int h = temp.Count - 1; h > 0; h--)
                        {
                            if (temp[i][0] == temp[h][0])
                            {
                                if (i != h)
                                {
                                    int totale = int.Parse(temp[i][4]) + int.Parse(temp[h][4]);
                                    temp[i][4] = totale.ToString();
                                    temp.Remove(temp[h]);
                                }
                            }
                        }
                    }
                    //utilizzo la lista temporanea per popolare la griglia (in questo modo ho i dati corretti con il totale delle ore sommate nel caso di più servizi di segretria)
                    for (int k = 0; k < temp.Count; k++)
                    {
                        dgwSegreteria.Rows.Add();
                        dgwSegreteria.Rows[k].Cells[0].Value = temp[k][1];
                        dgwSegreteria.Rows[k].Cells[1].Value = temp[k][2];
                        dgwSegreteria.Rows[k].Cells[2].Value = temp[k][3];
                        dgwSegreteria.Rows[k].Cells[3].Value = temp[k][4];
                        dgwSegreteria.Rows[k].Cells[4].Value = "Segreteria";
                    }

                }
            }
        }

        //evento di modifica indice Tab
        //viene utilizzato per caricare le griglie al cambio della pagina visualizzata
        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbControl.SelectedIndex)
            {
                case 0:
                    compilaDataGridDebito(pathSoci);
                    break;
                case 1:
                    compilaDataGridCategorie(pathCategorie);
                    break;
                case 2:
                    comboboxSoci(pathSoci, cbRicevente);
                    comboboxSoci(pathSoci, cbEsecutore);
                    comboboxCategorie(pathCategorie, cbCategoria);
                    compilaDataGridPrestazioni(pathPrestazioni);
                    break;
                case 3:
                    compilaDataGridSegreteria(pathPrestazioni);
                    break;
            }
        }

        //evento di modifica indice combobox Ricevente - TAB Prestazioni
        //viene utilizzato per evitare che Esecutore e Ricevente facciano riferiemento allo stesso socio
        private void cbEsecutore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRicevente.Text != "")
            {
                if (cbEsecutore.SelectedIndex == cbRicevente.SelectedIndex)
                {
                    cbEsecutore.SelectedIndex = -1;
                    MessageBox.Show("Non puoi selezionare questo elemento, è già stato scelto come Ricevente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //evento di modifica indice combobox Ricevente - TAB Prestazioni
        //viene utilizzato per evitare che Esecutore e Ricevente facciano riferiemento allo stesso socio
        private void cbRicevente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEsecutore.Text != "")
            {
                if (cbEsecutore.SelectedIndex == cbRicevente.SelectedIndex)
                {
                    cbRicevente.SelectedIndex = -1;
                    MessageBox.Show("Non puoi selezionare questo elemento, è già stato scelto come Esecutore", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //evento di caricamento form
        private void bancaTempo_Load(object sender, EventArgs e)
        {
            dtDataPrestazione.Value = DateTime.Now;
            compilaDataGridDebito(pathSoci);
        }

        private void dgwSegreteria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwPrestazioni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}