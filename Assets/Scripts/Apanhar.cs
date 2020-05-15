using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apanhar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))// && this.enabled==true)
        {
            //verificar se o player já leva um ovo
            if (other.GetComponentInChildren<Apanhar>() == null)
            {
                transform.parent = other.transform;
                GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
}
