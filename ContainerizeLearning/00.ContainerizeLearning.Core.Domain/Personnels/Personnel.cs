namespace ContainerizeLearning.Core.Domain
{
public class Personnel
{
    public Personnel(int id, string name, string family, string personnelNumber)
    {
        Id = id;
        Name = name;
        Family = family;
        PersonnelNumber = personnelNumber;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Family { get; private set; }
    public string PersonnelNumber { get; private set; }

    }
}