using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersSkin : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] float speed;

    private void Start()
    {
        transform.position = target.position;
    }

    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
            transform.position = Vector3.Lerp(target.position, transform.position, speed);
        else
            Destroy(gameObject);
    }
}
