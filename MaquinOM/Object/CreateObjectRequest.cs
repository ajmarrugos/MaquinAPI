namespace MaquinOM.Object;

// REQUEST Model
public record CreateObjectRequest
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Tags,
    List<string> Labels
);
