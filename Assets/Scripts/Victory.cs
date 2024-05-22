using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using GameJolt.API;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
         
         UnLockTrophy1();
         SceneManager.LoadScene("MainMenu");  
        }
    }
    void UnLockTrophy1()
    {
        Trophies.TryUnlock(233713);
    }
}
