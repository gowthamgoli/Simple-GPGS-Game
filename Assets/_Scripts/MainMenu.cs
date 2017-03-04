using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class MainMenu : MonoBehaviour {

    void Awake() {
        /*PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
            // enables saving game progress.
            // require access to a player's Google+ social graph (usually not needed)
            .Build();

        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();*/
    }
    void Start() {
        // authenticate user:
        MultiplayerController.Instance.SignInAndStartMPGame();
        /*Social.localUser.Authenticate((bool success) => {
            // handle success or failure
            if (success)
            {
                Debug.Log("Sucess login");
            }
            else
            {
                Debug.Log("Failed");
            }
        });*/
    }

	public void StartMultiPlayer()
    {
        Debug.Log("CLicked MP button");
        MultiplayerController.Instance.SignInAndStartMPGame();

    }

    public void ShowLeaderBoard () {
        Debug.Log("CLicked Leader button");
    }

    public void ShowAchievements()
    {
        Debug.Log("CLicked Acheive button");
        PlayGamesPlatform.Instance.SignOut();
    }
}
