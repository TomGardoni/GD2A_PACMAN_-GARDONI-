using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context_S : MonoBehaviour
{
    [SerializeField] private GameObject[] phantomPrefab;
    private ISurgir<GameObject> spawnLogic;
    [SerializeField] private GameObject phantomCanva;

    public void PickDifficulty(int difficulty)
    {
        if (difficulty == 0)
        {
            spawnLogic = new Facile_S();
            SpawnPhantom();
        }

        else if (difficulty == 1)
        {
            spawnLogic = new Difficile_S();
            SpawnPhantom();
        }

        else
        {
            Debug.Log("Unknown Difficulty");
        }
    }

    private void SpawnPhantom()
    {
        spawnLogic.Surgir(phantomPrefab, phantomCanva);
    }

}
