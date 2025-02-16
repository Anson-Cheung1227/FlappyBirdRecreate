using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Score;
    public event EventHandler DeathState;
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InvokeDeathState()
    {
        AudioManager.Instance.PlaySound("Die");
        DeathState?.Invoke(this, EventArgs.Empty);
    }
}
