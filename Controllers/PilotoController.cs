using Formula1Backend.Models.Piloto.Dto;
using Formula1Backend.Services;
using Formula1Backend.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Formula1Backend.Controllers
{
    [Route("api/pilotos")]
    [ApiController]
    public class PilotoController : ControllerBase
    {
        private readonly PilotoServices _pilotoServices;

        public PilotoController(PilotoServices pilotoServices)
        {
            _pilotoServices = pilotoServices;
        }

        [HttpGet]
        public async Task<List<AllPilotosDTO>> GetPilotos()
        {
            return await _pilotoServices.GetAll();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult<AllPilotosDTO>> GetPiloto(int id)
        {
            try
            {
                var piloto = await _pilotoServices.GetOneById(id);
                return Ok(piloto);
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage("Algo salió mal"));
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AllPilotosDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult> Create([FromBody] CreatePilotoDTO piloto)
        {
            try
            {
                var created = await _pilotoServices.CreateOne(piloto);
                return Created("api/pilotos", created);
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage("Algo salió mal creando el piloto"));
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AllPilotosDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult<AllPilotosDTO>> Update(int id, [FromBody] UpdatePilotoDTO piloto)
        {
            try
            {
                var updated = await _pilotoServices.UpdateOneById(id, piloto);
                return Ok(updated);
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage($"Algo salió mal actualizando el piloto con ID = {id}"));
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _pilotoServices.DeleteOneById(id);
                return Ok(new HttpMessage($"Piloto con ID = {id} eliminado correctamente."));
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage($"Algo salió mal eliminando el piloto con ID = {id}"));
            }
        }
    }
}
