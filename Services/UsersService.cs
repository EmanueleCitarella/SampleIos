namespace iOSExampleApplication.Services;

public class UsersService
{
    private List<User> usersList = new List<User>();
    private string _currentUser;
    
    public UsersService()
    {
        usersList.Add(new User{username = "user1", password = "test123"});
    }

    public List<User> GetUsers()
    {
        return usersList;
    }

    public void AddUser(User user)
    {
        usersList.Add(user);
    }

    public User GetUser(User userToSearch)
    {
        var userFound = usersList.Find(x => x.username == userToSearch.username);
        if (userFound != null && userFound.password == userToSearch.password)
        {
            _currentUser = userFound.username;
            return userFound as User;
        }
        else
        {
            return null;
        }
    }
    
    public string GetCurrentUser()
    {
        return _currentUser ?? usersList[0].username;
    }

    public void Logout()
    {
        _currentUser = null;
    }
}

public class User
{
    public string username { get; set; }
    public string password { get; set; }
    
    
}