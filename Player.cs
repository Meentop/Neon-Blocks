using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public void Move(int direction, ref int horizontal, ref int vertical)
    {
        if(direction == 0 && vertical != -1)
        {
            vertical--;
            transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        }
        else if(direction == 1 && horizontal != 1)
        {
            horizontal++;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
        }
        else if(direction == 2 && vertical != 1)
        {
            vertical++;
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
        else if (direction == 3 && horizontal != -1)
        {
            horizontal--;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && Score.playerAlive)
        {
            StartCoroutine(Lose());
            Score.playerAlive = false;
        }
        else if (collision.gameObject.tag == "Coin")
        {
            Score.Enemy--;
            Score.coins++;
            Destroy(collision.gameObject);
        }
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1f);
        Camera.main.GetComponent<UI>().Lose();
    }
}
