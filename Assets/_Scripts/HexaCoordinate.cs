using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HexaGround
{
    public enum EHexaDirection
    {
        TOP_LEFT,
        TOP_RIGHT,
        DOWN_LEFT,
        DOWN_RIGHT,
        LEFT,
        RIGHT,
        NONE,

        DIRCOUNT
    }

    public class HexaCoordinate
    {
        public Vector3 position;
        public int eulerAngle;

        //Vector3
        //x가 좌우
        //z가 상하
        //y = -X -Z;
    }
}
