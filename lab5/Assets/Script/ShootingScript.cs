using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    
    public GameObject particleSystemToSpawn;
    public Transform spawnPoint;
    public AudioSource source;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //TODO Shooting logic
            source.Play();
            GameObject particleSystem = Instantiate(particleSystemToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);
            Destroy(particleSystem, 3);
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Target")
                {
                    GameObject target = hit.collider.gameObject;
                    TargetComponent tc = target.GetComponent<TargetComponent>();
                    if (tc != null)
                    {
                        tc.ProcessHit();
                    }
                    Debug.Log("i hit a target");
                }
            }
        }
        
    }
}
