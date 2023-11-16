namespace UserTestProject.Web.Models.Users;

public class CreateUserProfileRequest
{
  public string Name { get; set; }
  public string SurName { get; set; }

  public string Email { get; set; }

  public string Phone { get; set; }

  public string LastName { get; set; }
}