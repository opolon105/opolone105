using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaderUp : MonoBehaviour
{

    public Transform teleport_point;
    void OnTriggerStay (Collider other)
    {
        other.transform.position = teleport_point.transform.position;
    }

}
