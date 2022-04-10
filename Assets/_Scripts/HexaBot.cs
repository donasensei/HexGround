using HexaGround;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexaBot : MonoBehaviour
{
    public EHexaDirection direction = EHexaDirection.NONE;

    void Start()
    {
        for(int number = 0; number < (int)EHexaDirection.DIRCOUNT; ++number)
        {
            Move((EHexaDirection)number);
        }
    }

    public void Move(EHexaDirection direction)
    {
        switch(direction)
        {
            case EHexaDirection.TOP_LEFT:
            case EHexaDirection.TOP_RIGHT:
            case EHexaDirection.DOWN_LEFT:
            case EHexaDirection.DOWN_RIGHT:
            case EHexaDirection.LEFT:
            case EHexaDirection.RIGHT:
                Debug.Log($"Move {direction}!");
                break;
            default:
                Debug.Log("Wrong Direction");
                break;
        }
    }
}
