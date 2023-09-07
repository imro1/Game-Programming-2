using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    public float maxTime = 3.0f;
    public float inputTimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            inputTimer += Time.deltaTime;
        }
        if(Input.GetButtonUp("Fire1"))
        {
            float ratio = inputTimer / maxTime;
            ratio = Mathf.Clamp(ratio, 0.0f, 1.0f);

            GameObject spawnedBullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            BulletComponent bulletComp = spawnedBullet.GetComponent<BulletComponent>();
            if(bulletComp != null)
            {
                bulletComp.strengthRatio = ratio;
            }
            inputTimer = 0.0f;
        }
    }
}
