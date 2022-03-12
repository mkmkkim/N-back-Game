using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void LobbyScene()
    {
        SceneManager.LoadScene("LobbyScene");
    }
    /*public void EndingScene()
    {
        SceneManager.LoadScene("EndingScene");
    }*/
}
