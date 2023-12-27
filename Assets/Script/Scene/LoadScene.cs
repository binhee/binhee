using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScne : MonoBehaviour
{
    public void OnStartButtonClick()
    {        
        SceneManager.LoadScene("MainScene");
    }
}
