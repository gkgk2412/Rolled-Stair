using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteStair : MonoBehaviour
{
    private static SpriteStair instance;
    public static SpriteStair Instance => instance;

    public Sprite[] stairSprite = new Sprite[8];

    public SpriteStair()
    {
        //자기 자신에 대한 정보를 static 형태의 instacne 변수에 저장하여 외부에서 접근이 쉽도록 함
        instance = this;
    }
}
