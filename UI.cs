using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] Text phases;
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
    }

    public void Return()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
