using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ScreenChanger : MonoBehaviour
{
    public void GameStarter()
    {
        SceneManager.LoadScene("Game");
    }
}
