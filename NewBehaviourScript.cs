using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Çäîðîâüå
    public int healt = 5;
    // óðîâåíü
    public int level = 1;
    // ñêîðîñòü
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 newPosition = transform.position;
        healt += level;
        print(" healt =  " + healt);
        print(newPosition);
        newPosition.z = speed * Time.deltaTime;
        transform.position = newPosition;
    }
    
}