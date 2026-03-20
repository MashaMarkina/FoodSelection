using FoodSelection.Model;
using System.Net.Http.Json;
using Xunit;

namespace FoodSelectionApi.Test
{
    public class UnitTest1
    {
        protected readonly HttpClient _client;
        const int TEST1 = 100;
        const int TEST2 = 10000;
        private Random rand;
       string[] ArrStr = { "2", "3", "4" };
        public UnitTest1()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7210/");
            rand = new Random();
        }
        [Fact]
        public async Task Add100Elements()
        {
            var ClRes = await _client.DeleteAsync("api/FoodProduct/DeleteAll");
            ClRes.EnsureSuccessStatusCode();

            int CountSuccess = 0;

            for(int i = 0; i < TEST1; i++)
            {
                var newElem = new FoodProduct
                {
                    Name = "sdasd",
                    Category = ArrStr[rand.NextInt64(0, 2)],
                    Protein = rand.NextInt64(0, 100),
                    Carbs = rand.NextInt64(0, 100),
                    Fats = rand.NextInt64(0, 100),
                    Calories = 20,
                    IsVegan = false,
                    IsVegetarian = false
                };
                var resp = await _client.PostAsJsonAsync("api/FoodProduct", newElem);
                if (resp.IsSuccessStatusCode) CountSuccess++;
            }
            Assert.Equal(TEST1, CountSuccess);
        }
        [Fact]
        public async Task Add10000Elements()
        {
            var ClRes = await _client.DeleteAsync("api/FoodProduct/DeleteAll");
            ClRes.EnsureSuccessStatusCode();

            int CountSuccess = 0;

            for (int i = 0; i < TEST2; i++)
            {
                var newElem = new FoodProduct
                {
                    Name = "sdasd",
                    Category = ArrStr[rand.Next(0, 2)],
                    Protein = rand.NextInt64(0, 100),
                    Carbs = rand.NextInt64(0, 100),
                    Fats = rand.NextInt64(0, 100),
                    Calories = 20,
                    IsVegan = false,
                    IsVegetarian = false
                };
                var resp = await _client.PostAsJsonAsync("api/FoodProduct", newElem);
                if (resp.IsSuccessStatusCode) CountSuccess++;
            }
            Assert.Equal(TEST2, CountSuccess);
        }

        [Fact]
        public async Task DeleteAll()
        {
            var getResponse = await _client.DeleteAsync("api/FoodProduct/DeleteAll");
            getResponse.EnsureSuccessStatusCode();
        }
    }
}
