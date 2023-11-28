using System;
using System.Data;
using System.Data.SqlClient; 
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

namespace apimaatjes
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=apimaatjes;Uid=root;Pwd=;";
        MySqlConnection connection;
        private HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();

            // Instantieer de HttpClient in de constructor van het formulier
            httpClient = new HttpClient();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Database verbonden");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database niet verbonden: " + ex.Message);
            }
        }


        private async Task MakeApiRequest()
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://apistocks.p.rapidapi.com/monthly?symbol=AAPL&dateStart=2021-01-01&dateEnd=2021-07-31"),
                    Headers =
            {
                { "X-RapidAPI-Key", "4a7901e120msh2b0798676847123p1490aejsn76d155a96d73" },
                { "X-RapidAPI-Host", "apistocks.p.rapidapi.com" },
            },
                };

                using (var response = await httpClient.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var json = await response.Content.ReadAsStringAsync();

                    // Deserialiseer de JSON-respons naar een object
                    var apiData = JsonConvert.DeserializeObject<ApiData>(json);

                    // Sla de gegevens op in de database
                    SaveToDatabase(apiData);

                    MessageBox.Show("API-gegevens succesvol opgehaald en opgeslagen in de database.");
                    txtApiInfo.Text = "API-gegevens succesvol opgehaald en opgeslagen in de database.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het ophalen van API-gegevens: " + ex.Message);
                txtApiInfo.Text = ("Fout bij het ophalen van API-gegevens: " + ex.Message);
            }
        }


        private void SaveToDatabase(ApiData apiData)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    int index = 1;
                    foreach (var result in apiData.Results)
                    {
                        using (var command = new MySqlCommand("INSERT INTO stocks_info (symbol, company_name, open_price, low_price, volume, adj_close, date) VALUES (@Symbol, @CompanyName, @Open, @Low, @Volume, @AdjClose, @Date)", connection))
                        {

                            command.Parameters.AddWithValue("@Open", result.Open);
                            command.Parameters.AddWithValue("@Close", result.Close);
                            command.Parameters.AddWithValue("@High", result.High);
                            command.Parameters.AddWithValue("@Low", result.Low);
                            command.Parameters.AddWithValue("@Volume", result.Volume);
                            command.Parameters.AddWithValue("@AdjClose", result.AdjClose);
                            command.Parameters.AddWithValue("@Date", result.Date);

                            command.Parameters.AddWithValue("@Symbol", apiData.Metadata.Symbol);
                            command.Parameters.AddWithValue("@CompanyName", "YourCompanyName"); 

                            command.ExecuteNonQuery();

                            // Voeg de gegevens toe aan de TextBox in het gewenste formaat
                            textBox1.AppendText($"{index}:\n");
                            textBox1.AppendText($"Date: \"{result.Date}\"\n");
                            textBox1.AppendText($"Open: {result.Open}\n");
                            textBox1.AppendText($"Close: {result.Close}\n");
                            textBox1.AppendText($"High: {result.High}\n");
                            textBox1.AppendText($"Low: {result.Low}\n");
                            textBox1.AppendText($"Volume: {result.Volume}\n");
                            textBox1.AppendText($"AdjClose: {result.AdjClose}\n\n");

                            index++;
                            string lala = "succesvol opgehaald";
                            dbFetchtxt.Text = lala; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fout in de fetch is:" + ex.Message);
                dbFetchtxt.Text = "fout in de fetch is:" + ex.Message;   
            }
        }

        private async void strAandeel_Click(object sender, EventArgs e)
        {
            try
            {
                await MakeApiRequest();
            }
            catch (Exception ex)
            {
                MessageBox.Show("fout button is: " + ex.Message);
            }
        }



        public class ApiData
        {
            public Metadata Metadata { get; set; }
            public Result[] Results { get; set; }
        }

        public class Metadata
        {
            public string Symbol { get; set; }
            public string Interval { get; set; }
            public string Timezone { get; set; }
        }

        public class Result
        {
            public string Date { get; set; }
            public double Open { get; set; }
            public double Close { get; set; }
            public double High { get; set; }
            public double Low { get; set; }
            public long Volume { get; set; }
            public double AdjClose { get; set; }
        }
    }

}