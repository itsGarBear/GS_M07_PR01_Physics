using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBall : MonoBehaviour
{
    public GameManager gm;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;

            gm.TargetBall(collision.gameObject);
        }
    }
}
