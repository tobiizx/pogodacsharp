using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace pogoda
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Hourly
        {
            public List<string> time { get; set; }
            public List<double> temperature_2m { get; set; }
            public List<int> relative_humidity_2m { get; set; }
            public List<int> precipitation_probability { get; set; }
            public List<int> rain { get; set; }
        }

        public class HourlyUnits
        {
            public string time { get; set; }
            public string temperature_2m { get; set; }
            public string relative_humidity_2m { get; set; }
            public string precipitation_probability { get; set; }
            public string rain { get; set; }
        }

        public class Root
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double generationtime_ms { get; set; }
            public int utc_offset_seconds { get; set; }
            public string timezone { get; set; }
            public string timezone_abbreviation { get; set; }
            public int elevation { get; set; }
            public HourlyUnits hourly_units { get; set; }
            public Hourly hourly { get; set; }
        }




        void searchButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&hourly=temperature_2m,relative_humidity_2m,precipitation_probability,rain&timezone=Europe%2FBerlin&forecast_days=1");
            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(result);
            for (int i = 0; i < myDeserializedClass.hourly.time.Count; i++)
            {
                listBox1.Items.Add("Godzina: " + myDeserializedClass.hourly.temperature_2m[i]);
            }
        }

    }
}
