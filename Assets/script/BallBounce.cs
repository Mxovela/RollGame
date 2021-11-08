using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace bounce
{


    public class BallBounce : MonoBehaviour
    {
        string playerTag;
        float bounceForce;
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.transform.tag == playerTag)
            {
                Rigidbody otherRB = collision.rigidbody;
                otherRB.AddExplosionForce(bounceForce, collision.contacts[0].point, 3);
            }
        }
    }
}
