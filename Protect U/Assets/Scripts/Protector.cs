using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        
        //Vector2 vecMouse = new Vector2(h, v);
        //Vector2 vecMouse = Input.mousePosition;
        Vector2 vecMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Quaternion rotation = Quaternion.LookRotation(vecMouse - (Vector2)transform.position);
        transform.position = vecMouse.normalized;
        float deg=Mathf.Rad2Deg* Mathf.Acos((vecMouse.x * 0 + transform.position.y * 1) / (1 * 1))*-1*transform.position.x/Mathf.Abs(transform.position.x);
        transform.rotation =  Quaternion.Euler(0,0,deg);

        
    }
}
