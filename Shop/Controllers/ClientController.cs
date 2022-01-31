using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Shop.Enities;
using Shop.Enities.DTOs;
using Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public ClientController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }


     
        [HttpGet]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = await _repository.Client.GetAllClientsWithAddress();

            var clientsToReturn = new List<ClientDTO>();

            foreach(var client in clients)
            {
                clientsToReturn.Add(new ClientDTO(client));
            }

            return Ok(clientsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            var client = await _repository.Client.GetByIDWithAddress(id);

            return Ok(new ClientDTO(client));
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(CreateClientDTO client)
        {
            Client newClient = new Client();

            newClient.FirstName = client.FirstName;
            newClient.LastName = client.LastName;
            newClient.Address = client.Address;

            _repository.Client.Create(newClient);

            await _repository.SaveAsync();

            return Ok(new ClientDTO(newClient));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientById(int id)
        {
            var client = await _repository.Client.GetByIdAsync(id);

            if(client == null)
            {
                return NotFound("Client dosen't exist.");
            }

            _repository.Client.Delete(client);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateClientById(int id, [FromBody] ClientDTO newClient)
        {
            var client = await _repository.Client.GetByIdAsync(id);
            client.FirstName = newClient.FirstName;
            client.LastName = newClient.LastName;
            client.Address = newClient.Address;

            if (client == null)
            {
                return NotFound("Client dosen't exist.");
            }

            _repository.Client.Update(client);

            await _repository.SaveAsync();

            return Ok(client);
        }
    }
}
