using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Facile_S : ISurgir<GameObject>
{
    public void Surgir(GameObject[] phantomList, GameObject parent)
    {
        for (int i = 0; i < 3; i++)
        {
            var phantom = GameObject.Instantiate(phantomList[0], parent.transform);
            phantom.transform.position += new Vector3(10 * i, 0, 0);
        }
    }
}