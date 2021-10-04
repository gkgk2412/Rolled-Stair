using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyObjManager : MonoBehaviour
{
    public static bool isEmptyObj = false;
    public static bool isFloorSet = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "ColObject")
        {
            isEmptyObj = true; //면 계단 놓을수있다.            
        }

        if (other.gameObject.tag == "floor")
        {
            isFloorSet = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ColObject")
        {
            isEmptyObj = false;
        }

        if (other.gameObject.tag == "floor")
        {
            isFloorSet = false;
        }
    }
}
