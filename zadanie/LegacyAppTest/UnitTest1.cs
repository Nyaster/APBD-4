using LegacyApp;

namespace LegacyAppTest;

public class UnitTest1
{
    [Fact]
    public void AssertTrueChecAddinUser()
    {
        var userService = new UserService();
        var addUser = userService.AddUser("John", "Doe", "johndoe@gmail.com", DateTime.Parse("1982-03-21"), 1);
        Assert.True(addUser);
    }

    [Fact]
    public void UserNameNullCheck()
    {
        var userService = new UserService();
        var addUser = userService.AddUser(null, "Doe", "johndoe@gmail.com", DateTime.Parse("1982-03-21"), 1);
        Assert.False(addUser);
    }

    [Fact]
    public void LastNameNullCheck()
    {
        var userService = new UserService();
        var addUser = userService.AddUser("John", null, "johndoe@gmail.com", DateTime.Parse("1982-03-21"), 1);
        Assert.False(addUser);
    }
    [Fact]
    public void LastNameEmptyCheck()
    {
        var userService = new UserService();
        var addUser = userService.AddUser("John", "", "johndoe@gmail.com", DateTime.Parse("1982-03-21"), 1);
        Assert.False(addUser);
    }
    [Fact]
    public void UserNameEmptyCheck()
    {
        var userService = new UserService();
        var addUser = userService.AddUser("", "Doe", "johndoe@gmail.com", DateTime.Parse("1982-03-21"), 1);
        Assert.False(addUser);
    }
}