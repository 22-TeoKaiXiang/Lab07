using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GUIScript : MonoBehaviour
{
    public void OnRestart()
    {
        SceneManager.LoadScene(0);
    }
}
