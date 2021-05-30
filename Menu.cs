using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] Text coins;

    private void Start()
    {
        Time.timeScale = 1;
        if(!PlayerPrefs.HasKey("AllCoins"))
        {
            PlayerPrefs.SetInt("AllCoins", 0);
        }
        coins.text = PlayerPrefs.GetInt("AllCoins").ToString();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
