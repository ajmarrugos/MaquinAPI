namespace MaquinAPI.Models;

// Default Object Model Template
public class Object
{
    // Public Definitions
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public List<string> Tags { get; }
    public List<string> Labels { get; }

    // Object Constructor
    public Object(
        Guid id,
        string name,
        string description,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime lastModifiedDateTime,
        List<string> tags,
        List<string> labels)
    {
        // Enforce Invariants
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime ;
        LastModifiedDateTime = lastModifiedDateTime;
        Tags = tags; 
        Labels = labels;
    }
}
