using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float speed;

    private void Start()
    {
        speed = Camera.main.GetComponent<Main>().speed;
    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
