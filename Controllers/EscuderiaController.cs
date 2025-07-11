using Formula1Backend.Models.Escuderia.Dto;
using Formula1Backend.Services;
using Formula1Backend.Utils;
using Microsoft.AspNetCore.Mvc;


namespace Formula1Backend.Controllers
{
    [Route("api/escuderias")]
    [ApiController]
    public class EscuderiaController : ControllerBase
    {
        private readonly EscuderiaServices _escuderiaServices;

        public EscuderiaController(EscuderiaServices escuderiaServices)
        {
            _escuderiaServices = escuderiaServices;
        }

        [HttpGet]
        public async Task<List<AllEscuderiasDTO>> GetEscuderias()
        {
            return await _escuderiaServices.GetAll();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult<AllEscuderiasDTO>> GetEscuderia(int id)
        {
            try
            {
                var escuderia = await _escuderiaServices.GetOneById(id);
                return Ok(escuderia);
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
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AllEscuderiasDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult> Create([FromBody] CreateEscuderiaDTO escuderia)
        {
            try
            {
                var created = await _escuderiaServices.CreateOne(escuderia);
                return Created("api/escuderias", created);
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage("Algo salió mal creando la escudería"));
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AllEscuderiasDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult<AllEscuderiasDTO>> Update(int id, [FromBody] UpdateEscuderiaDTO escuderia)
        {
            try
            {
                var updated = await _escuderiaServices.UpdateOneById(id, escuderia);
                return Ok(updated);
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage($"Algo salió mal actualizando la escudería con ID = {id}"));
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(HttpMessage))]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _escuderiaServices.DeleteOneById(id);
                return Ok(new HttpMessage($"Escudería con ID = {id} eliminada correctamente."));
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage($"Algo salió mal eliminando la escudería con ID = {id}"));
            }
        }
    }
}
