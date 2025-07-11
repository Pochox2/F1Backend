using Formula1Backend.Models.Pista.Dto;
using Formula1Backend.Services;
using Formula1Backend.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Formula1Backend.Controllers
{
    [Route("api/pistas")]
    [ApiController]
    public class PistaController : ControllerBase
    {
        private readonly PistaServices _pistaServices;

        public PistaController(PistaServices pistaServices) 
        {
            _pistaServices = pistaServices;
        }

        [HttpGet]

        public async Task<List<AllPistasDTO>> GetPistas()
        {
            return await _pistaServices.GetAll();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]

        public async Task<ActionResult<AllPistasDTO>> GetPista(int id)
        {
            try
            {
                var pista = await _pistaServices.GetOneById(id);
                return Ok(pista);
            }
            catch (HttpError ex) 
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage ("Algo salió mal"));
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AllPistasDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult> Create([FromBody] CreatePistaDTO pista)
        {
            try
            {
                var created = await _pistaServices.CreateOne(pista);
                return Created("api/pistas", created);
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage("Algo salió mal creando la pista"));
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AllPistasDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult<AllPistasDTO>> Update(int id, [FromBody] UpdatePistaDTO pista)
        {
            try
            {
                var updated = await _pistaServices.UpdateOneById(id, pista);
                return Ok(updated);
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage($"Algo salió mal actualizando la pista con ID = {id}"));
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _pistaServices.DeleteOneById(id);
                return Ok(new HttpMessage($"Pista con ID = {id} eliminada correctamente."));
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage($"Algo salió mal eliminando la pista con ID = {id}"));
            }
        }
    }
}
