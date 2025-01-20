using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class CountriesViewModel
{
    public ObservableCollection<Country> Countries { get; } = new ObservableCollection<Country>();
    HttpClient client = new HttpClient();

    public async Task SearchCountry(string name)
    {
        var response = await client.GetAsync($"https://restcountries.com/v3.1/name/{name}?fields=name,region,maps");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var countries = JsonConvert.DeserializeObject<List<Country>>(json); // Adaptar a la estructura exacta de la respuesta
            Countries.Clear();
            foreach (var country in countries)
            {
                Countries.Add(country);
            }
        }
        else
        {
            // Manejar el error
        }
    }
}
