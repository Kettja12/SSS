using Microsoft.AspNetCore.Components;
using SSS.Repositories.Models;
using System.Collections.Generic;

namespace SSS.Services;

public class StateContainer
{
    public User CurrentUser { get; private set; }=new();
    public string AuthToken { get; private set; } = string.Empty;
    public event Action? OnChange;

    public void SetCurrentUser(User user)
    {
        this.CurrentUser = user;
        NotifyStateChanged();
    }
    public bool IsLogin { get { return CurrentUser.Id>0; } }

    private void NotifyStateChanged() => OnChange?.Invoke();
    
    public int SelectedRace { get; set; }
}
