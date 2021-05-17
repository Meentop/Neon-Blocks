using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Vector3 direction;

    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
