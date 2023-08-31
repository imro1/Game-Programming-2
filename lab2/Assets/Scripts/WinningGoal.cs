using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningGoal : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("You win!");

        }
    }
}
