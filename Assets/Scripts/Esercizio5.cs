using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    public int find = 10;
    // Start is called before the first frame update
    void Start()
    {
        int[] num = new int[10];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = Random.Range(0, find + 1);
            if (find == num[i])
            {
                Debug.Log("Found");
            }

          else if(find != num[i])
            {
                Debug.Log("Not Found");
            }
            
        }
        Debug.Log("Iterations Finished");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
