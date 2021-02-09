using Microsoft.AspNetCore.Mvc;
using ModellenBureau.API.Models;
using ModellenBureau.Main.Shared;

namespace ModellenBureau.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoModelController : Controller
    {
        public readonly IPhotoModelRepository _photoModelRepository;

        public PhotoModelController(IPhotoModelRepository photoModelRepository)
        {

            _photoModelRepository = photoModelRepository;
        }

        [HttpGet]
        public IActionResult GetAllPhotoModels()
        {
            return Ok(_photoModelRepository.GetAllPhotoModels());
        }

        [HttpGet("{id}")]
        public IActionResult GetPhotoModelById(int id)
        {
            return Ok(_photoModelRepository.GetPhotoModelById(id));
        }

        [HttpPost]
        public IActionResult CreatePhotoModel([FromBody] PhotoModel photoModel)
        {
            if (photoModel == null)
                return BadRequest();

            //if (photoModel.Voornaam == string.Empty || photoModel.Achternaam == string.Empty)
            //{
            //    ModelState.AddModelError("Naam/Voornaam", "De naam kan niet leeg zijn");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdPhotoModel = _photoModelRepository.AddPhotoModel(photoModel);

            return Created("photomodel", createdPhotoModel);
        }

        [HttpPut]
        public IActionResult UpdatePhotoModel([FromBody] PhotoModel photoModel)
        {
            if (photoModel == null)
                return BadRequest();

            //if (photoModel.Voornaam == string.Empty || photoModel.Achternaam == string.Empty)
            //{
            //    ModelState.AddModelError("Naam/Voornaam", "De naam kan niet leeg zijn");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var PhotoModelToUpdate = _photoModelRepository.GetPhotoModelById(photoModel.PhotoModelID);

            if (PhotoModelToUpdate == null)
                return NotFound();

            _photoModelRepository.UpdatePhotoModel(photoModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePhotoModel(int id)
        {
            if (id == 0)
                return BadRequest();

            var photoModelToDelete = _photoModelRepository.GetPhotoModelById(id);

            if (photoModelToDelete == null)
                return NotFound();

            _photoModelRepository.DeletePhotoModel(id);

            return NoContent();
        }
    }
}
