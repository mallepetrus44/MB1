using ModellenBureau.Main.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.API.Models
{
    public interface IPhotoModelRepository
    {
        IEnumerable<PhotoModel> GetAllPhotoModels();
        PhotoModel GetPhotoModelById(int photoModelId);
        PhotoModel AddPhotoModel(PhotoModel photoModel);
        PhotoModel UpdatePhotoModel(PhotoModel photoModel);
        void DeletePhotoModel(int photoModelId);
    }
}
