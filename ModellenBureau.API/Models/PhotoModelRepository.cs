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

        public PhotoModel GetModelById(int photoModelId)
        {
            return _mbDbContext.PhotoModels.FirstOrDefault(p => p.PhotoModelID == photoModelId);
        }

        public PhotoModel AddModel(PhotoModel photoModel)
        {
            var addedEntity = _mbDbContext.PhotoModels.Add(photoModel);
            _mbDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public PhotoModel UpdateModel(PhotoModel photoModel)
        {
            var foundPhotoModel = _mbDbContext.PhotoModels.FirstOrDefault(p => p.PhotoModelID == photoModel.PhotoModelID);

            if (foundPhotoModel != null)
            {
                foundPhotoModel.PhotoModelID = photoModel.PhotoModelID;
                foundPhotoModel.Leeftijd = photoModel.Leeftijd;
                foundPhotoModel.Geboortedatum = photoModel.Geboortedatum;
                foundPhotoModel.Geslacht = photoModel.Geslacht;
                foundPhotoModel.Bovenwijdte = photoModel.Bovenwijdte;
                foundPhotoModel.Taillewijdte = photoModel.Taillewijdte;
                foundPhotoModel.Heupwijdte = photoModel.Heupwijdte;
                foundPhotoModel.Fotos = photoModel.Fotos;

                _mbDbContext.SaveChanges();

                return foundPhotoModel;
            }

            return null;
        }

        public void DeleteModel(int photoModelId)
        {
            var foundPhotoModel = _mbDbContext.PhotoModels.FirstOrDefault(p => p.PhotoModelID == photoModelId);
            if (foundPhotoModel == null) return;

            _mbDbContext.PhotoModels.Remove(foundPhotoModel);
            _mbDbContext.SaveChanges();
        }
    }
}
