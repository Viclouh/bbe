using WebAppAPI.Model;

namespace WebAppAPI.Services
{
    public class CharacterService
    {
		private List<Character> _characters;

		public List<Character> Characters
		{
			get { return _characters; }
			set { _characters = value; }
		}

		public CharacterService()
		{
            string BASE_URL = "https://rickandmortyapi.com/api/";


            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };


            HttpClient client = new HttpClient(clientHandler);
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync("character").Result;
            if (response.IsSuccessStatusCode)
            {
                Characters dataObj = response.Content.ReadFromJsonAsync<Characters>().Result;
                Characters = dataObj.Results;
            }


        }
	}
}
