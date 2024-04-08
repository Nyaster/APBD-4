using LegacyApp;

namespace LegacyAppTest;

public class IntegrationTest
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

    [Fact]
    public void EmaiLFailInputDogCheck()
    {
        var userService = new UserService();
        var addUser = userService.AddUser("John", "Doe", "johndoegmail.com", DateTime.Parse("1982-03-21"), 1);
        Assert.False(addUser);
    }

    [Fact]
    public void EmaiLFailInputDotCheck()
    {
        var userService = new UserService();
        var addUser = userService.AddUser("John", "Doe", "johndoe@gmailcom", DateTime.Parse("1982-03-21"), 1);
        Assert.False(addUser);
    }

    [Fact]
    public void EmailGlobalFailCheck()
    {
        var userService = new UserService();
        var addUser = userService.AddUser("John", "Doe", "johndoegmailcom", DateTime.Parse("1982-03-21"), 1);
        Assert.False(addUser);
    }

    [Fact]
    public void FailAgeCheck()
    {
        var userService = new UserService();
        var addUser = userService.AddUser("John", "Doe", "johndoegmailcom", DateTime.Parse("2007-03-21"), 1);
        Assert.False(addUser);
    }
    
}