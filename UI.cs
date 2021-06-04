using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] Text phases, score, record, coinInGames, allCoin, coinInLose;
    [SerializeField] Image panel;

    [SerializeField] GameObject lose, newRecord;

    private void Start()
    {
        lose.SetActive(false);
    }

    private void Update()
    {
        phases.text = Score.phases.ToString();
        coinInGames.text = Score.coins.ToString();
    }

    public void Lose()
    {
        lose.SetActive(true);
        PlayerPrefs.SetInt("Score", Score.phases);
        if (PlayerPrefs.HasKey("Record"))
        {
            if (Score.phases > PlayerPrefs.GetInt("Record"))
            {
                PlayerPrefs.SetInt("Record", Score.phases);
                newRecord.SetActive(true);
            }
            else
            {
                newRecord.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("Record", Score.phases);
        }
        score.text = PlayerPrefs.GetInt("Score").ToString();
        record.text = PlayerPrefs.GetInt("Record").ToString();
        coinInLose.text = "+" + Score.coins.ToString();
        PlayerPrefs.SetInt("AllCoins", PlayerPrefs.GetInt("AllCoins") + Score.coins);
        allCoin.text = PlayerPrefs.GetInt("AllCoins").ToString();
    }

    public void Return()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
