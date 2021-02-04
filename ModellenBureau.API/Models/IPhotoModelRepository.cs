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
        PhotoModel GetModelById(int photoModelId);
        PhotoModel AddModel(PhotoModel photoModel);
        PhotoModel UpdateModel(PhotoModel photoModel);
        void DeleteModel(int photoModelId);
    }
}
