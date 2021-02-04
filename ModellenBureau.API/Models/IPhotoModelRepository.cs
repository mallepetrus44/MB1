using ModellenBureau.Main.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.API.Models
{
    public interface IPhotoModelRepository
    {
        IEnumerable<PhotoModel> GetAllModels();
        PhotoModel GetModelById(int modelId);
        PhotoModel AddModel(int modelId);
        PhotoModel UpdateModel(int modelId);
        void DeleteModel(int modelId);
    }
}
