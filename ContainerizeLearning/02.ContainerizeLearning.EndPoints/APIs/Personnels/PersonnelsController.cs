namespace  ContainerizeLearning.EndPoints.APIs
{
    using ContainerizeLearning.Core.Domain;
    using ContainerizeLearning.EndPoints.APIs.ViewModels;
    using Microsoft.AspNetCore.Mvc;

[Route("api/v1/[controller]")]
[ApiController]
public class PersonnelsController: ControllerBase
{
    private readonly IPersonnelRepository _personnelRepository;

    public PersonnelsController(IPersonnelRepository personnelRepository)
    {
        _personnelRepository = personnelRepository;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id, CancellationToken cancellationToken=default)
        => Ok(await _personnelRepository.Get(id, cancellationToken));

    [HttpPost]
    public async Task<ActionResult> Post(AddViewModel vm, CancellationToken cancellationToken=default)
    {
        await _personnelRepository.Add(vm.To());
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult> Put(UpdateViewModel vm, CancellationToken cancellationToken=default)
    {
        await _personnelRepository.Update(vm.To());
        return Ok();
    }
}
}