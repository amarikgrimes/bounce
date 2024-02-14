using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-11f, 11), Random.Range(-11f, 11f));
    }

    // Update is called once per frame
    void Update()
        {
           
        }
    private void OnCollisionEnter2D(Collision2D collision)
        {
        AudioSource audiosource;
        audiosource = GetComponent<AudioSource>();
        audiosource.Play();
        }

}
