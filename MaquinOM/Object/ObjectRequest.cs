namespace MaquinOM.ObjectRequest;

// REQUEST Model
public record ObjectRequest
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Tags,
    List<string> Labels
);
