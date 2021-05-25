using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Text phases;

    private void Update()
    {
        phases.text = Score.phases.ToString();
    }
}
