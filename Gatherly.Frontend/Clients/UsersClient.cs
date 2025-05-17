using System;
using Gatherly.Frontend.Models;

namespace Gatherly.Frontend.Clients;

public class UsersClient(HttpClient httpClient)
{
  public async Task<UserDetail> GetUserByIdAsync(int userId)
  {
    var user = await httpClient.GetFromJsonAsync<UserDetail>($"user/{userId}");
    return user is null ? throw new Exception($"{userId} not found.") : user;
  }
}
