using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public Gameobject position;
    public float test;
    void Start()
    {
        prefabList.Add(a);
        prefabList.Add(b);
        prefabList.Add(c);
        

        int prefabIndex = UnityEngine.Random.Range(0, 3);
        Instantiate(prefabList[prefabIndex], position, Quaternion.identity);

    }
 

}
