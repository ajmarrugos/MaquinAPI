namespace MaquinOM.Object;

// UPSERT REQUEST Model
public record UpsertObjectRequest
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Tags,
    List<string> Labels
);
