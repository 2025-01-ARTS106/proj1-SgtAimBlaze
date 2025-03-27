using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbLadder : MonoBehaviour
{
    private bool isCliming = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) { isCliming = true; }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) { isCliming = false; }
    }
    public bool getisCliming()
    {
        return isCliming;
    }

}
