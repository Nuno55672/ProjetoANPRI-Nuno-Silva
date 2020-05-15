using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropMe : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("DropPoint"))
        {
            //desativar apanhar
            //transform.GetComponent<Apanhar>().enabled = false;
            //remover o componente
            Destroy(GetComponent<Apanhar>());
            //cair
            transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }

}
