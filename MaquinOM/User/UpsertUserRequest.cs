namespace MaquinOM.User;

// UPSERT REQUEST Model
public record UpsertUserRequest
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Tags,
    List<string> Labels
);
