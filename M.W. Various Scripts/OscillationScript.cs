﻿using UnityEngine;
using System.Collections;

public class OscillationScript : MonoBehaviour {

    public float speed = 5f;//Base oscillation speed
    public int leftPosx = 68;
    public int rightPosx = 75;


	void FixedUpdate () {


        if (transform.position.x < leftPosx)
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        if (transform.position.x > rightPosx)
        {//Adjust numbers to fit circumstances of the object.  
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        }

    }


    /** This was an attempt at portability. Was not functioning as intended. Would have flipped the visuals on an object as well as made linear movement reverse at the position check.
    GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);

    if (transform.position.x < 68){  
        Flip();
    }
    if (transform.position.x > 75){ 
        Flip();
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    **/
}
