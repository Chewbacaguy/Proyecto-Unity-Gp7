using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
  /*  private void OnCollisionEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("pared"))
        {
            //obj.Destroy;
            Destroy(collision.gameObject);
            
        }
    }*/

    private void OnCollisionEnter(Collision collision)
    {

        Destroy(collision.gameObject);
    }

}
