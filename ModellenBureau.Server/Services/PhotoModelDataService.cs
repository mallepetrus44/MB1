using ModellenBureau.Main.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModellenBureau.Server.Services
{
    public class PhotoModelDataService : IPhotoModelDataService
    {
        private readonly HttpClient _httpClient;

        public PhotoModelDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PhotoModel>> GetAllPhotoModels()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<PhotoModel>>
                (await _httpClient.GetStreamAsync($"api/photomodel"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<PhotoModel> GetPhotoModelDetails(int photoModelId)
        {
            return await JsonSerializer.DeserializeAsync<PhotoModel>
                (await _httpClient.GetStreamAsync($"api/photomodel/{photoModelId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<PhotoModel> AddPhotoModel(PhotoModel photoModel)
        {
            var photoModelJson =
                new StringContent(JsonSerializer.Serialize(photoModel), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/photomodel", photoModelJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<PhotoModel>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task UpdatePhotoModel(PhotoModel photoModel)
        {
            var photoModelJson =
                new StringContent(JsonSerializer.Serialize(photoModel), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/photomodel", photoModelJson);
        }

        public async Task DeletePhotoModel(int photoModelId)
        {
            await _httpClient.DeleteAsync($"api/photomodel/{photoModelId}");
        }
    }
}
