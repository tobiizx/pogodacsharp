using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace pogoda
{

    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            pobieranieDanych();
            timerAktualizacji();
        }

        private void timerAktualizacji()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 15 * 60 * 1000;
            timer.Tick += async (sender, e) => await pobieranieDanych();
            timer.Start();
        }

        private async Task pobieranieDanych()
        {
            string pogodaAPI = "https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&hourly=temperature_2m,relative_humidity_2m,precipitation_probability";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage odpowiedzAPI = await client.GetAsync(pogodaAPI);
                    odpowiedzAPI.EnsureSuccessStatusCode();
                    string odpowiedzBody = await odpowiedzAPI.Content.ReadAsStringAsync();
                    Root danePogody = JsonConvert.DeserializeObject<Root>(odpowiedzBody);

                    Aktualizuj(danePogody);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas pobierania danych z API: {ex.Message}");
                }
            }
        }

        private void Aktualizuj(Root danePogody)
        {
            if (danePogody?.hourly?.time != null && danePogody.hourly.time.Count > 0)
            {
                temperatureLabel.Text = $"Temperatura: {danePogody.hourly.temperature_2m[0]}°C";
                humidityLabel.Text = $"Wilgotnoœæ: {danePogody.hourly.relative_humidity_2m[0]}%";
                precipitationLabel.Text = $"Szansa opadów: {danePogody.hourly.precipitation_probability[0]}%";
                lastUpdatedLabel.Text = $"Aktualizacja: {DateTime.Now}";
                generatedTime.Text = $"Czas generowania: {danePogody.generationtime_ms}ms";
            }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Hourly
        {
            public List<string> time { get; set; } = new List<string>();
            public List<double> temperature_2m { get; set; } = new List<double>();
            public List<int> relative_humidity_2m { get; set; } = new List<int>();
            public List<int> precipitation_probability { get; set; } = new List<int>();
            public List<int> rain { get; set; } = new List<int>();
        }

        public class HourlyUnits
        {
            public string time { get; set; } = string.Empty;
            public string temperature_2m { get; set; } = string.Empty;
            public string relative_humidity_2m { get; set; } = string.Empty;
            public string precipitation_probability { get; set; } = string.Empty;
            public string rain { get; set; } = string.Empty;
        }

        public class Root
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double generationtime_ms { get; set; }
            public int utc_offset_seconds { get; set; }
            public string timezone { get; set; } = string.Empty;
            public string timezone_abbreviation { get; set; } = string.Empty;
            public double elevation { get; set; }
            public HourlyUnits hourly_units { get; set; } = new HourlyUnits();
            public Hourly hourly { get; set; } = new Hourly();
        }
    }
}
