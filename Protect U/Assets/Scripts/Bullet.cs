using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=1;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = -transform.position.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.transform.tag)
        {
            case "Player":
                BulletSpownerManager.instance.putInBulletPool(this.gameObject);
                //Destroy(gameObject);
                break;
            case "Finish":
                BulletSpownerManager.instance.putInBulletPool(this.gameObject);

                break;

        }
    }

    private void OnDestroy()
    {

        
    }

}
