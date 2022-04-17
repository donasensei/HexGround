using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSpinner : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init(true, true, LogBehaviour.Default);
        Rotate();
    }

    public void Rotate()
    {
        transform.DORotate(new Vector3(0,0,360), 10f, RotateMode.FastBeyond360)
            .SetEase(Ease.InOutBounce)
            .SetLoops(-1);//Loop Inifinite
    }
}
