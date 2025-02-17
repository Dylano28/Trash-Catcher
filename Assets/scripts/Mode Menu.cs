using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeMenu : MonoBehaviour
{
  
    public void Playgame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Glassmode()
    {
        SceneManager.LoadScene("Glass mode");
    }
}
