using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //Debug.Log("moveHorizontal: " + moveHorizontal);

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        Debug.Log("movement variable is = " + movement);

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Debug.Log("You pressed D");
        //}
    }
}
