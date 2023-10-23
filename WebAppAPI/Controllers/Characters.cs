using Microsoft.AspNetCore.Mvc;

using WebAppAPI.Model;
using WebAppAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private CharacterService characterService = new CharacterService();
        // GET: api/<Characters>
        [HttpGet]
        public Characters Get()
        {
            return new Characters(characterService.Characters);
        }

        // GET api/<Characters>/5
        [HttpGet("{id}")]
        public Character Get(int id)
        {
            return characterService.Characters[id];
        }

        // POST api/<Characters>
        [HttpPost]
        public void Post([FromBody] Character value)
        {
            characterService.Characters.Add(value);
        }

        // PUT api/<Characters>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Characters>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
