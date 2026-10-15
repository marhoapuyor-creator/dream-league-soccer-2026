# PlayFab integration (stub)

This file contains example steps to integrate PlayFab for authentication and leaderboards.

1) Sign up at https://playfab.com and create a new title.
2) In Unity, import the PlayFab SDK (available via package or Unity Asset Store).
3) Example pseudocode for login:

```csharp
using PlayFab;
using PlayFab.ClientModels;

public void LoginDevice()
{
    var request = new LoginWithCustomIDRequest { CustomId = SystemInfo.deviceUniqueIdentifier, CreateAccount = true };
    PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFail);
}

void OnLoginSuccess(LoginResult r) { Debug.Log("PlayFab login success"); }
void OnLoginFail(PlayFabError e) { Debug.LogError(e.GenerateErrorReport()); }
```

4) Submit leaderboard score example:

```csharp
var req = new UpdatePlayerStatisticsRequest { Statistics = new List<StatisticUpdate> { new StatisticUpdate { StatisticName = "TopScore", Value = score } } };
PlayFabClientAPI.UpdatePlayerStatistics(req, (r)=>Debug.Log("Score submitted"), (e)=>Debug.LogError(e.GenerateErrorReport()));
```

