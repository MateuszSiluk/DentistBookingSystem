using BlazorApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class UserService : IUserService
    {
        private IHttpService _httpService;

        public UserService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<User>> GetAll(string name, string surname)
        {
             return await _httpService.Get<IEnumerable<User>>($"/users?name={name}&surname={surname}");
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _httpService.Get<IEnumerable<User>>($"/users");
        }

        public Task<User> GetMe()
        {
            return _httpService.Get<User>($"/users/me");
        }
    }
}