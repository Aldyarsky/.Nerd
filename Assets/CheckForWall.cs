using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForWall : MonoBehaviour
{
    private bool isWallNear = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            isWallNear = true;
        }
        print(isWallNear);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            isWallNear = false;
        }
        print(isWallNear);
    }
}
