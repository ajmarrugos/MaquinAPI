namespace MaquinOM.User;

// RESPONSE Model
public record UserResponse
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Tags,
    List<string> Labels
);
