using ModellenBureau.Main.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.Server.Services
{
    public interface IPhotoModelDataService
    {
        Task<IEnumerable<PhotoModel>> GetAllPhotoModels();
        Task<PhotoModel> GetPhotoModelDetails(int photoModelId);
        Task<PhotoModel> AddPhotoModel(PhotoModel photoModel);
        Task UpdatePhotoModel(PhotoModel photoModel);
        Task DeletePhotoModel(int photoModelId);
    }
}
