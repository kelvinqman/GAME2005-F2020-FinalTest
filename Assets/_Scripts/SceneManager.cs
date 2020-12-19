using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void GoToScene(string scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
