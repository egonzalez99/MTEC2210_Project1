using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    bool red, blue;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().material.color = new Color(0, 0, 255);
        red = true;
        blue = true;
    }

    // Update is called once per frame
    void Update()
    {
    

        if (Input.GetKeyDown(KeyCode.Space))

            if (red)
            {
                GetComponent<SpriteRenderer>().material.color = new Color(255, 0, 0);
                red = false;
            }

            else if (Input.GetKeyDown(KeyCode.Space))

                if (!red)
                {
                    GetComponent<SpriteRenderer>().material.color = new Color(0, 255, 0);
                    red = true;
                }
                

    }
}
