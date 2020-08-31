using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using testingTemp.Shared.Models;

namespace testingTemp.Services
{
    public class ApiService
    {
        public HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        string Message = "";
        public async Task<List<Contact>> GetContactsAsync()
        {
            var response = await _httpClient.GetAsync("api/contacts");
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await System.Text.Json.JsonSerializer.DeserializeAsync<List<Contact>>(responseContent);
        }
        public async Task<Contact> GetContactById(int id)
        {
            var response = await _httpClient.GetAsync($"api/contacts/{id}");
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await System.Text.Json.JsonSerializer.DeserializeAsync<Contact>(responseContent);
        }
    }
}
