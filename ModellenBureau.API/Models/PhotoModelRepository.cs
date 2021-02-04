using ModellenBureau.Main.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.API.Models
{
    public class PhotoModelRepository : IPhotoModelRepository
    {
        private readonly MBDbContext _mbDbContext;

        public PhotoModelRepository(MBDbContext mbDbContext)
        {
            _mbDbContext = mbDbContext;
        }

        public IEnumerable<PhotoModel> GetAllModels()
        {
            return _mbDbContext.PhotoModels;
        }

        public PhotoModel GetModelById(int modelId)
        {
            return _mbDbContext.PhotoModels.FirstOrDefault(t => t.PhotoModelID == modelId);
        }

        public PhotoModel AddModel(int modelId)
        {
            throw new NotImplementedException();
        }

        public PhotoModel UpdateModel(int modelId)
        {
            throw new NotImplementedException();
        }

        public void DeleteModel(int modelId)
        {
            throw new NotImplementedException();
        }
    }
}
