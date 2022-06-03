using ContainerizeLearning.Core.Domain;

namespace  ContainerizeLearning.EndPoints.APIs.ViewModels
{
public class UpdateViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string PersonnelNumber { get; set; }

    public Personnel To() => new Personnel(Id, Name, Family, PersonnelNumber); 
}
}