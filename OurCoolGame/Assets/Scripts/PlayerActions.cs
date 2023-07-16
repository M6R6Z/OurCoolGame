using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10.0f;
    [SerializeField] private GameObject ObjectToSpawn;
    public static float vertical, horizontal;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(ObjectToSpawn, new Vector3Int(0, 0, 0), new Quaternion(0, 0, 0, 0));
        }

        horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);
        vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);

        
    }
}
