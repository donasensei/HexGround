using System;
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

    [Serializable]
    public class HexaCoordinate
    {
        public Vector3 CoordPosition
        {
            get => coordPosition;
        }

        Vector3 coordPosition;
        public int eulerAngle;

        public HexaCoordinate()
        { }

        public HexaCoordinate(int x, int z)
        {
            SetPosition(x, z);
        }

        public void SetPosition(int x, int z)
        {
            coordPosition = new Vector3(x, -x - z, z);
        }
        //Vector3
        //x가 좌우
        //z가 상하
        //y = -X -Z;
    }
}
