using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace TheBugTracker.Client.Helpers
{
    public static class UserInfoHelper
    {
        public static async Task<UserInfo> GetUserInfoAsync(Task<AuthenticationState>? authStateTask)
        {
            if (authStateTask is null) return null;

            AuthenticationState authState = await authStateTask;
            ClaimsPrincipal user = authState.User;

            try
            {
                return new UserInfo
                {
                    UserId = user.FindFirst(ClaimTypes.NameIdentifier)!.Value,
                    Email = user.FindFirst(ClaimTypes.Email)!.Value,
                    FirstName = user.FindFirst("FirstName")!.Value,
                    LastName = user.FindFirst("LastName")!.Value
                };
            }
            catch
            {
                return null;
            }
        }
    }
}
