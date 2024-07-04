using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentSceneManager : MonoBehaviour
{
    public static PersistentSceneManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        if (!Application.isEditor)
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Additive);
            SceneManager.LoadScene("UI", LoadSceneMode.Additive);
        }
    }

    public void Restart()
    {
        SceneManager.UnloadSceneAsync("UI");
        SceneManager.UnloadSceneAsync("Main");
        SceneManager.LoadScene("Main", LoadSceneMode.Additive);
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
    }
}
