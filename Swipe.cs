using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    Player player;

    int vertical = 0, horizontal = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (eventData.delta.x < 0 && eventData.delta.y > 0)
        {
            player.Move(0, ref vertical, ref horizontal);
        }
        else if (eventData.delta.x > 0 && eventData.delta.y > 0)
        {
            player.Move(1, ref vertical, ref horizontal);
        }
        else if (eventData.delta.x > 0 && eventData.delta.y < 0)
        {
            player.Move(2, ref vertical, ref horizontal);
        }
        else if (eventData.delta.x < 0 && eventData.delta.y < 0)
        {
            player.Move(3, ref vertical, ref horizontal);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
