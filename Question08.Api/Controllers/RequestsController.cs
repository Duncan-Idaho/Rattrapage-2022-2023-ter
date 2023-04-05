using Microsoft.AspNetCore.Mvc;
using Question08.Api.Repositories;

namespace Question08.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RequestsController : ControllerBase
{
    readonly RequestsRepository requestsRepository;

    public RequestsController(RequestsRepository requestsRepository)
    {
        this.requestsRepository = requestsRepository;
    }

    [HttpGet]
    public IEnumerable<Request> GetAll()
        => requestsRepository.GetAll().OrderBy(a => a.Id);

    [HttpGet("{id}")]
    public Request? Get(int id)
        => requestsRepository.Get(id);

    [HttpPost]
    public Request Get(RequestCreation creation)
        => requestsRepository.Save(creation.Create(requestsRepository.NextId));
}
