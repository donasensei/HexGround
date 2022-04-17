using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCaculator : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CaculRoutine());
    }

    IEnumerator CaculRoutine()
    {
        float measureTerm = 1.0f;
        while(true)
        {
            measureTerm = Random.Range(0.5f, 1.5f);
            if (isLayDown(transform, target))
            {
                Debug.Log("is Lay Down!");
                Debug.Break();
            }
            else
            {
                Debug.Log("Not Lay Down!");
            }

            yield return new WaitForSeconds(measureTerm);
        }
    }

    bool isLayDown(Transform origin, Transform target)
    {
        float angle = Vector3.Angle(target.up, origin.up);
        if (angle >= 8f || angle <= -8f)
            return true;
        return false;
    }
}
