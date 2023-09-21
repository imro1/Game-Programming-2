using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    public void ProcessHit()
    {
        // TODO React to hit 
        gameObject.SetActive(false);
        Invoke("ResetTarget", 5.0f);
        GameManager.Instance.IncrementScore();
    }
    void ResetTarget()
    {
        gameObject.SetActive(true);
        transform.parent.GetComponent<Renderer>().material.color = Color.green;
    }

}
