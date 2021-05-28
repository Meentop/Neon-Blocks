using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] Text phases, score, record;
    [SerializeField] Image panel;

    [SerializeField] GameObject lose;

    private void Update()
    {
        phases.text = Score.phases.ToString();
    }

    public void Lose()
    {
        lose.SetActive(true);
        panel.color = new Color(0f, 0f, 0f, 0.35f);
        PlayerPrefs.SetInt("Score", Score.phases);
        if (PlayerPrefs.HasKey("Record"))
        {
            if (Score.phases > PlayerPrefs.GetInt("Record"))
                PlayerPrefs.SetInt("Record", Score.phases);
        }
        else
        {
            PlayerPrefs.SetInt("Record", Score.phases);
        }
        score.text = PlayerPrefs.GetInt("Score").ToString();
        record.text = PlayerPrefs.GetInt("Record").ToString();
    }

    public void Return()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
