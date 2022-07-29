using Newtonsoft.Json;

namespace PieWorkShop.Models
{
    public static class StaticApiData
    {
        public static async Task<IEnumerable<Student>> GetApiData(string ApiAddress)
        {
            IEnumerable<Student> students = new List<Student>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiAddress))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    students = JsonConvert.DeserializeObject<IEnumerable<Student>>(apiResponse);
                }
            }
            return students;
        }
    }
}
