using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
   

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.world);
    }
}
