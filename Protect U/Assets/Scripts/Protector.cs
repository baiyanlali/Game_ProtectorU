using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum State
{
    idle,forward,backward
}

public class Protector : MonoBehaviour
{
    State currentState;

    [SerializeField] private float distance = 1f;
    private float originDistance = 1f;
    public float maxDistance = 3f;

    // Start is called before the first frame update
    void Start()
    {
        currentState = State.idle;
        originDistance = distance;
    }

    void Update()
    {
        gamePlay();
        
    }

    void gamePlay()
    {
        switch (currentState)
        {
            case State.idle:
                if (Input.GetMouseButton(0)) currentState = State.forward;
                    break;
            case State.forward:
                distance += Mathf.Sqrt(Time.deltaTime);
                distance = Mathf.Min(distance, maxDistance);
                if (Input.GetMouseButtonUp(0)) currentState = State.backward;
                break;
            case State.backward:
                distance -= Mathf.Sqrt(Time.deltaTime);
                if (Input.GetMouseButton(0)) currentState = State.forward;
                if (distance<=originDistance)
                    currentState = State.idle;
                break;
            default:
                break;
        }
        //rotate 
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        Vector2 vecMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = vecMouse.normalized * distance;
        float deg = Mathf.Rad2Deg * (float)Mathf.Acos(((vecMouse.x * 0) + transform.position.y * 1) / (1 * distance)) * -1 * transform.position.x / Mathf.Abs(transform.position.x);
        transform.rotation = Quaternion.Euler(0f, 0f, deg).normalized;

       
    }


    
}
