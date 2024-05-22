using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.API;
using GameJolt.UI;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool isSignedIn) =>
        {
            if (isSignedIn)
            {
                UnLockTrophy();
                SceneManager.LoadScene("Level1");
            }
            else
            {
                Debug.Log("error");
            }
        });
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void UnLockTrophy()
    {
        Trophies.TryUnlock(233711);
    }
}
