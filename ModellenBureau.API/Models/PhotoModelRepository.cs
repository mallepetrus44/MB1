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

        public IEnumerable<PhotoModel> GetAllPhotoModels()
        {
            return _mbDbContext.PhotoModels;
        }

        public PhotoModel GetPhotoModelById(int photoModelId)
        {
            return _mbDbContext.PhotoModels.FirstOrDefault(p => p.PhotoModelID == photoModelId);
        }

        public PhotoModel AddPhotoModel(PhotoModel photoModel)
        {
            var addedEntity = _mbDbContext.PhotoModels.Add(photoModel);
            _mbDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public PhotoModel UpdatePhotoModel(PhotoModel photoModel)
        {
            var foundPhotoModel = _mbDbContext.PhotoModels.FirstOrDefault(p => p.PhotoModelID == photoModel.PhotoModelID);

            if (foundPhotoModel != null)
            {
                foundPhotoModel.Leeftijd = photoModel.Leeftijd;
                foundPhotoModel.Geboortedatum = photoModel.Geboortedatum;
                foundPhotoModel.Geslacht = photoModel.Geslacht;
                foundPhotoModel.Bovenwijdte = photoModel.Bovenwijdte;
                foundPhotoModel.Taillewijdte = photoModel.Taillewijdte;
                foundPhotoModel.Heupwijdte = photoModel.Heupwijdte;
                foundPhotoModel.Lengte = photoModel.Lengte;
                foundPhotoModel.Fotos = photoModel.Fotos;
                foundPhotoModel.Voornaam = photoModel.Voornaam;
                foundPhotoModel.Achternaam = photoModel.Achternaam;
                foundPhotoModel.Adres = photoModel.Adres;
                foundPhotoModel.Postcode = photoModel.Postcode;
                foundPhotoModel.Stad = photoModel.Stad;

                _mbDbContext.SaveChanges();

                return foundPhotoModel;
            }

            return null;
        }

        public void DeletePhotoModel(int photoModelId)
        {
            var foundPhotoModel = _mbDbContext.PhotoModels.FirstOrDefault(p => p.PhotoModelID == photoModelId);
            if (foundPhotoModel == null) return;

            _mbDbContext.PhotoModels.Remove(foundPhotoModel);
            _mbDbContext.SaveChanges();
        }
    }
}
