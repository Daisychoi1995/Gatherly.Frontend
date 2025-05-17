using System;

namespace Gatherly.Frontend.Models;

public class UserDetail
{
  public int Id { get; set; }

  public required string UserName { get; set; }

  public required string FullName { get; set; }

  public required string Description { get; set; }

  public required string Email { get; set; }

  public required string ProfileUrl { get; set; }

}
