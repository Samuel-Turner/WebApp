using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.DTOs;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinoController : ControllerBase
    {
        private readonly IDinoRepo _repository;
        private readonly IMapper _mapper;

        public DinoController(IDinoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DinoReadDTO>> GetAllDinos()
        {
            var dino = _repository.GetAllDinos();
            return Ok(_mapper.Map<IEnumerable<DinoReadDTO>>(dino));
        }

        [HttpGet("{id}", Name = "GetDinoById")]
        public ActionResult<DinoReadDTO> GetDinoById(int id)
        {
            var dino = _repository.GetDinoById(id);
            if (dino != null)
            {

                return Ok(_mapper.Map<DinoReadDTO>(dino));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<DinoReadDTO> CreateDino(DinoCreateDTO dinoCreateDTO)
        {
            var dinoModel = _mapper.Map<Dino>(dinoCreateDTO);

            _repository.CreateDino(dinoModel);
            _repository.SaveChanges();

            var dino = _mapper.Map<DinoReadDTO>(dinoModel);

            return CreatedAtRoute(nameof(GetDinoById), new { Id = dino.Id }, dino);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, DinoUpdateDTO dinoUpdateDTO)
        {
            var dino = _repository.GetDinoById(id);
            if (dino == null)
            {
                return NotFound();
            }
            _mapper.Map(dinoUpdateDTO, dino);
            _repository.UpdateDino(id, dino);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialUpdateDino(int id, JsonPatchDocument<DinoUpdateDTO> patchDoc)
        {
            var dino = _repository.GetDinoById(id);
            if (dino == null)
            {
                return NotFound();
            }
            var dinoToPatch = _mapper.Map<DinoUpdateDTO>(dino);
            patchDoc.ApplyTo(dinoToPatch, ModelState);
            if (!TryValidateModel(dinoToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(dinoToPatch, dino);
            _repository.UpdateDino(id, dino);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDino(int id)
        {
            var dino = _repository.GetDinoById(id);
            if (dino == null)
            {
                return NotFound();
            }
            _repository.DeleteDino(dino);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
