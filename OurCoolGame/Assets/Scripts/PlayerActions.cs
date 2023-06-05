using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
   [SerializeField] private GameObject ObjectToSpawn;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(ObjectToSpawn, new Vector3Int(0, 0, 0), new Quaternion(0, 0, 0, 0));
        }
    }
}
