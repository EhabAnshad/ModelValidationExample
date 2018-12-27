using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;
using ModelValidation.Repository;
using System;
using System.Collections.Generic;

namespace ModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> Get()
        {
            return Ok(_userRepository.BrowseAsync());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<UserModel> Get(Guid id)
        {
           return Ok(_userRepository.GetUserAsync(id).Result);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<UserModel> Post([FromBody] UserModel user)
        {
            user.Id = Guid.NewGuid();
            _userRepository.AddUserAsync(user);
            return Ok(user);
        }
 

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<UserModel> Put(Guid id, [FromBody] UserModel user)
        {
            _userRepository.UpdateAsync(user);
            return Ok(user);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            if (_userRepository.Delete(id) < 0)
            {
                return Ok(id.ToString());
            }
            return NotFound();
        }
    }
}
