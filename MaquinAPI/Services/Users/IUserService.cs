namespace MaquinAPI.Services.Users;

// Public Interface that defines the internal model methods
public interface IUserService
{
    void CreateUser(User user);
    Users GetUser(Guid id);
}
