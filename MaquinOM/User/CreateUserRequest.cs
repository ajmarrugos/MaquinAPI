namespace MaquinOM.User;

// REQUEST Model
public record CreateUserRequest
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Tags,
    List<string> Labels
);
