using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] float speed;

    private void Start()
    {
        transform.position = target.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(target.position, transform.position, speed);
    }
}
