using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] string destroyerTag;

    float speed;

    private void Start()
    {
        speed = Camera.main.GetComponent<Main>().enemySpeed;
        print(speed);
    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == destroyerTag)
        {
            Score.Enemy--;
            Destroy(gameObject);
        }
    }
}
