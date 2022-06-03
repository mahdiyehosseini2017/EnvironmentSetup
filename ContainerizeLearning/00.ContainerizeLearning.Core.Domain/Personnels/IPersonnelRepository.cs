namespace ContainerizeLearning.Core.Domain
{
public interface IPersonnelRepository
{
    Task<Personnel> Get(int id, CancellationToken cancellationToken = default);
    Task Add(Personnel personnel, CancellationToken cancellationToken = default);
    Task Update(Personnel personnel, CancellationToken cancellationToken = default);
}
}