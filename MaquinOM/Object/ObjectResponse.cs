namespace MaquinOM.ObjectResponse;

// RESPONSE Model
public record ObjectResponse
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Tags,
    List<string> Labels
);
