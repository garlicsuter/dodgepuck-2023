using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange;
    public float yRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(transform.position.x > )

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        //Debug.Log("moveHorizontal: " + moveHorizontal);

        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
        
        //Debug.Log("movement variable is = " + movement);

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Debug.Log("You pressed D");
        //}
    }
}
