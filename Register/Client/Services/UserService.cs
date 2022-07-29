using Microsoft.AspNetCore.Components;
using Register.Shared;
using System.Net.Http.Json;

namespace Register.Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public UserService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Users> User { get; set; } = new List<Users>();

        public async Task CreateHero(Users user)
        {
            var result = await _http.PostAsJsonAsync("api/register", user);
            await SetUsers(result);
        }

        public Task GetUser(Users user)
        {
            throw new NotImplementedException();
        }
        private async Task SetUsers(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Users>>();
            User = response;
            _navigationManager.NavigateTo("users");
        }
    }
}
