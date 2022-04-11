using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pastille : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}