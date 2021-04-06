using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStairManager : MonoBehaviour
{
    public static bool isFinishCol = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("isFinishCol  " + CanvasStairManager.isFinishCol);

    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            isFinishCol = true; //면 계단 놓을수 없다
        }

        //if (other.gameObject.tag == "ColObject")
        //{
        //    isEmptyObj = true; //면 계단 놓을수있다.
        //}

        //if (other.gameObject.tag == "floor")
        //{
        //    isFloorSet = true;
        //}
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            isFinishCol = false;
        }

        //if (other.gameObject.tag == "ColObject")
        //{
        //    isEmptyObj = false;
        //}

        //if (other.gameObject.tag == "floor")
        //{
        //    isFloorSet = false;
        //}
    }


}