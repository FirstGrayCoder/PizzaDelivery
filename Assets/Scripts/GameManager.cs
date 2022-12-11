using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _playButton;
    public static bool _isPlay;
    [SerializeField] private GameObject losePanel;
    // Start is called before the first frame update
    void Start()
    {
        _isPlay = true;
        Time.timeScale = 0;
        _playButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPlay == false)
        {
            losePanel.SetActive(true);
        }
    }

    public void StartGame()
    {
        _isPlay = true;
        _playButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        _isPlay = true;
        SceneManager.LoadScene(0);
    }

}
