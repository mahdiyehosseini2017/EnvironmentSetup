namespace  ContainerizeLearning.EndPoints.APIs.ViewModels
{
using ContainerizeLearning.Core.Domain;

public class AddViewModel
{
    public string Name { get; set; }
    public string Family { get; set; }
    public string PersonnelNumber { get; set; }

        public Personnel To() => new Personnel(0, Name, Family, PersonnelNumber);
    }
}