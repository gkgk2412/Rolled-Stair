using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollectCol : MonoBehaviour
{
    public static bool isCollect = false;

    private void Start()
    {
        isCollect = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ColObject")
        {
            Debug.Log("in");
            isCollect = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ColObject")
        {
            Debug.Log("out");
            isCollect = false;
        }
    }
}
