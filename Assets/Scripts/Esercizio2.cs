using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public int[] arr = { 10, 78, 5, 37 };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[0] + arr[1] + arr[2] + arr[3]);
            Debug.Log(arr[0] * arr[1] * arr[2] * arr[3]);
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    
