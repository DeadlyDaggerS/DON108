using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public void OnMouseDown()
    {
        CamerController.instance.followTransform = transform;
    }
}
