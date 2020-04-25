using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spowner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spownBullet(GameObject bullet)
    {
        GameObject go = Instantiate(bullet, transform.position, Quaternion.identity);
        go.name = bullet.name;
    }
    public void getExistedBullet(GameObject bullet)
    {
        bullet.transform.position = transform.position;
        bullet.transform.rotation = Quaternion.identity;
    }

}
