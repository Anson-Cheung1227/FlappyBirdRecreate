using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    [SerializeField] private GameObject _endScreen;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.DeathState += ((sender, args) => _endScreen.SetActive(true));
    }

    // Update is called once per frame
    void Update()
    {
        string text = "";
        for (int i = 0; i < GameManager.Instance.Score.ToString().Length; ++i)
        {
            text += $"<sprite index={GameManager.Instance.Score.ToString()[i]}>";
        }

        _scoreText.text = text;
    }

    public void OnRestartButtonPress()
    {
        PersistentSceneManager.Instance.Restart();
    }
}
