using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0.020f, 0f);
            if (transform.position.y > 2.66f)
            {

                transform.position = new Vector3(transform.position.x, 2.66f, 0f);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -0.020f, 0f);
            if (transform.position.y < -2.66f)
            {

                transform.position = new Vector3(transform.position.x, -2.66f, 0f);
            }

        }
    }
}
