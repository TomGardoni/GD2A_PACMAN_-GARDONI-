using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Difficile_S : ISurgir<GameObject>
{
    public void Surgir(GameObject[] phantomList, GameObject parent)
    {
        for (int i = 0; i < 5; i++)
        {
            var phantom = GameObject.Instantiate(phantomList[1], parent.transform);
            phantom.transform.position += new Vector3(10 * i, 0, 0);
        }
    }
}
