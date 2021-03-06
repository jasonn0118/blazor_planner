using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using PlannerApp.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlannerApp.Client
{
    public class LocalAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _storageService;
        
        public LocalAuthenticationStateProvider(ILocalStorageService storageService)
        {
            _storageService = storageService;
        }
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //Any object in local storage as named as User.
            if(await _storageService.ContainKeyAsync("User"))
            {
                //Create User
                var userInfo = await _storageService.GetItemAsync<LocalUserInfo>("User");

                var claims = new[]
                {
                    new Claim("Email", userInfo.Email),
                    new Claim("FirstName", userInfo.FirstName),
                    new Claim("LastName", userInfo.LastName),
                    new Claim("AccessToken", userInfo.AccessToken),
                    new Claim(ClaimTypes.NameIdentifier, userInfo.Id)
                };

                var identity = new ClaimsIdentity(claims, "BearerToken");
                var user = new ClaimsPrincipal(identity);
                var state = new AuthenticationState(user);
                //Blazor app doesn't automatically notify the change.
                NotifyAuthenticationStateChanged(Task.FromResult(state));

                return state;
            }

            return new AuthenticationState(new ClaimsPrincipal());
        }

        public async Task LogoutAsync()
        {
            //Remove User data in the local storage.
            await _storageService.RemoveItemAsync("User");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal())));
        }
    }
}
