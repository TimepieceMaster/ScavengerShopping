﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{ 
    List<GameObject> prefabList = new List<GameObject>();
    List<Transform> locationList = new List<Transform>();
    List<GameObject> TprefabList = new List<GameObject>();
    List<Transform> TlocationList = new List<Transform>();
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    public GameObject prefab5;
    public GameObject prefab6;
    public GameObject prefab7;
    public GameObject prefab8;
    public GameObject prefab9;
    public GameObject prefab10;
    public GameObject prefab11;
    public GameObject prefab12;
    public GameObject prefab13;
    public GameObject prefab14;
    public GameObject prefab15;
    public GameObject prefab16;
    public GameObject prefab17;
    public GameObject prefab18;
    public GameObject prefab19;
    public GameObject prefab20;
    public GameObject prefab21;
    public GameObject prefab22;
    public GameObject prefab23;
    public GameObject prefab24;
    public GameObject prefab25;
    public GameObject prefab26;
    public GameObject prefab27;
    public GameObject prefab28;
    public GameObject prefab29;
    public GameObject prefab30;
    public GameObject prefab31;
    public GameObject prefab32;
    public GameObject prefab33;
    public GameObject prefab34;
    public GameObject prefab35;
    public GameObject prefab36;
    public GameObject prefab37;
    public GameObject prefab38;
    public GameObject prefab39;
    public GameObject prefab40;
    public GameObject prefab41;
    public GameObject prefab42;

    public GameObject Tprefab1;
    public GameObject Tprefab2;
    public GameObject Tprefab3;
    public GameObject Tprefab4;
    public GameObject Tprefab5;
    public GameObject Tprefab6;
    public GameObject Tprefab7;
    public GameObject Tprefab8;
    public GameObject Tprefab9;
    public GameObject Tprefab10;
    public GameObject Tprefab11;
    public GameObject Tprefab12;

    private int[] RandomArray = new int[192];
    private int[] RandomTArray = new int[36];
    public Transform S1Location1;
    public Transform S1Location2;
    public Transform S1Location3;
    public Transform S1Location4;
    public Transform S1Location5;
    public Transform S1Location6;
    public Transform S1Location7;
    public Transform S1Location8;
    public Transform S1Location9;
    public Transform S1Location10;
    public Transform S1Location11;
    public Transform S1Location12;
    public Transform S2Location1;
    public Transform S2Location2;
    public Transform S2Location3;
    public Transform S2Location4;
    public Transform S2Location5;
    public Transform S2Location6;
    public Transform S2Location7;
    public Transform S2Location8;
    public Transform S2Location9;
    public Transform S2Location10;
    public Transform S2Location11;
    public Transform S2Location12;
    public Transform S3Location1;
    public Transform S3Location2;
    public Transform S3Location3;
    public Transform S3Location4;
    public Transform S3Location5;
    public Transform S3Location6;
    public Transform S3Location7;
    public Transform S3Location8;
    public Transform S3Location9;
    public Transform S3Location10;
    public Transform S3Location11;
    public Transform S3Location12;
    public Transform S4Location1;
    public Transform S4Location2;
    public Transform S4Location3;
    public Transform S4Location4;
    public Transform S4Location5;
    public Transform S4Location6;
    public Transform S4Location7;
    public Transform S4Location8;
    public Transform S4Location9;
    public Transform S4Location10;
    public Transform S4Location11;
    public Transform S4Location12;
    public Transform S5Location1;
    public Transform S5Location2;
    public Transform S5Location3;
    public Transform S5Location4;
    public Transform S5Location5;
    public Transform S5Location6;
    public Transform S5Location7;
    public Transform S5Location8;
    public Transform S5Location9;
    public Transform S5Location10;
    public Transform S5Location11;
    public Transform S5Location12;
    public Transform S6Location1;
    public Transform S6Location2;
    public Transform S6Location3;
    public Transform S6Location4;
    public Transform S6Location5;
    public Transform S6Location6;
    public Transform S6Location7;
    public Transform S6Location8;
    public Transform S6Location9;
    public Transform S6Location10;
    public Transform S6Location11;
    public Transform S6Location12;
    public Transform S7Location1;
    public Transform S7Location2;
    public Transform S7Location3;
    public Transform S7Location4;
    public Transform S7Location5;
    public Transform S7Location6;
    public Transform S7Location7;
    public Transform S7Location8;
    public Transform S7Location9;
    public Transform S7Location10;
    public Transform S7Location11;
    public Transform S7Location12;
    public Transform S8Location1;
    public Transform S8Location2;
    public Transform S8Location3;
    public Transform S8Location4;
    public Transform S8Location5;
    public Transform S8Location6;
    public Transform S8Location7;
    public Transform S8Location8;
    public Transform S8Location9;
    public Transform S8Location10;
    public Transform S8Location11;
    public Transform S8Location12;
    public Transform S9Location1;
    public Transform S9Location2;
    public Transform S9Location3;
    public Transform S9Location4;
    public Transform S9Location5;
    public Transform S9Location6;
    public Transform S9Location7;
    public Transform S9Location8;
    public Transform S9Location9;
    public Transform S9Location10;
    public Transform S9Location11;
    public Transform S9Location12;
    public Transform S10Location1;
    public Transform S10Location2;
    public Transform S10Location3;
    public Transform S10Location4;
    public Transform S10Location5;
    public Transform S10Location6;
    public Transform S10Location7;
    public Transform S10Location8;
    public Transform S10Location9;
    public Transform S10Location10;
    public Transform S10Location11;
    public Transform S10Location12;
    public Transform S11Location1;
    public Transform S11Location2;
    public Transform S11Location3;
    public Transform S11Location4;
    public Transform S11Location5;
    public Transform S11Location6;
    public Transform S11Location7;
    public Transform S11Location8;
    public Transform S11Location9;
    public Transform S11Location10;
    public Transform S11Location11;
    public Transform S11Location12;
    public Transform S12Location1;
    public Transform S12Location2;
    public Transform S12Location3;
    public Transform S12Location4;
    public Transform S12Location5;
    public Transform S12Location6;
    public Transform S12Location7;
    public Transform S12Location8;
    public Transform S12Location9;
    public Transform S12Location10;
    public Transform S12Location11;
    public Transform S12Location12;
    public Transform S13Location1;
    public Transform S13Location2;
    public Transform S13Location3;
    public Transform S13Location4;
    public Transform S13Location5;
    public Transform S13Location6;
    public Transform S13Location7;
    public Transform S13Location8;
    public Transform S13Location9;
    public Transform S13Location10;
    public Transform S13Location11;
    public Transform S13Location12;
    public Transform S14Location1;
    public Transform S14Location2;
    public Transform S14Location3;
    public Transform S14Location4;
    public Transform S14Location5;
    public Transform S14Location6;
    public Transform S14Location7;
    public Transform S14Location8;
    public Transform S14Location9;
    public Transform S14Location10;
    public Transform S14Location11;
    public Transform S14Location12;
    public Transform S15Location1;
    public Transform S15Location2;
    public Transform S15Location3;
    public Transform S15Location4;
    public Transform S15Location5;
    public Transform S15Location6;
    public Transform S15Location7;
    public Transform S15Location8;
    public Transform S15Location9;
    public Transform S15Location10;
    public Transform S15Location11;
    public Transform S15Location12;
    public Transform S16Location1;
    public Transform S16Location2;
    public Transform S16Location3;
    public Transform S16Location4;
    public Transform S16Location5;
    public Transform S16Location6;
    public Transform S16Location7;
    public Transform S16Location8;
    public Transform S16Location9;
    public Transform S16Location10;
    public Transform S16Location11;
    public Transform S16Location12;

    public Transform T1Location1;
    public Transform T1Location2;
    public Transform T1Location3;
    public Transform T1Location4;
    public Transform T1Location5;
    public Transform T1Location6;
    public Transform T2Location1;
    public Transform T2Location2;
    public Transform T2Location3;
    public Transform T2Location4;
    public Transform T2Location5;
    public Transform T2Location6;
    public Transform T3Location1;
    public Transform T3Location2;
    public Transform T3Location3;
    public Transform T3Location4;
    public Transform T3Location5;
    public Transform T3Location6;
    public Transform T4Location1;
    public Transform T4Location2;
    public Transform T4Location3;
    public Transform T4Location4;
    public Transform T4Location5;
    public Transform T4Location6;
    public Transform T5Location1;
    public Transform T5Location2;
    public Transform T5Location3;
    public Transform T5Location4;
    public Transform T5Location5;
    public Transform T5Location6;
    public Transform T6Location1;
    public Transform T6Location2;
    public Transform T6Location3;
    public Transform T6Location4;
    public Transform T6Location5;
    public Transform T6Location6;

    void Start()
    {
        prefabList.Add(prefab1);
        prefabList.Add(prefab2);
        prefabList.Add(prefab3);
        prefabList.Add(prefab4);
        prefabList.Add(prefab5);
        prefabList.Add(prefab6);
        prefabList.Add(prefab7);
        prefabList.Add(prefab8);
        prefabList.Add(prefab9);
        prefabList.Add(prefab10);
        prefabList.Add(prefab11);
        prefabList.Add(prefab12);
        prefabList.Add(prefab13);
        prefabList.Add(prefab14);
        prefabList.Add(prefab15);
        prefabList.Add(prefab16);
        prefabList.Add(prefab17);
        prefabList.Add(prefab18);
        prefabList.Add(prefab19);
        prefabList.Add(prefab20);
        prefabList.Add(prefab21);
        prefabList.Add(prefab22);
        prefabList.Add(prefab23);
        prefabList.Add(prefab24);
        prefabList.Add(prefab25);
        prefabList.Add(prefab26);
        prefabList.Add(prefab27);
        prefabList.Add(prefab28);
        prefabList.Add(prefab29);
        prefabList.Add(prefab30);
        prefabList.Add(prefab31);
        prefabList.Add(prefab32);
        prefabList.Add(prefab33);
        prefabList.Add(prefab34);
        prefabList.Add(prefab35);
        prefabList.Add(prefab36);
        prefabList.Add(prefab37);
        prefabList.Add(prefab38);
        prefabList.Add(prefab39);
        prefabList.Add(prefab40);
        prefabList.Add(prefab41);
        prefabList.Add(prefab42);

        TprefabList.Add(Tprefab1);
        TprefabList.Add(Tprefab2);
        TprefabList.Add(Tprefab3);
        TprefabList.Add(Tprefab4);
        TprefabList.Add(Tprefab5);
        TprefabList.Add(Tprefab6);
        TprefabList.Add(Tprefab7);
        TprefabList.Add(Tprefab8);
        TprefabList.Add(Tprefab9);
        TprefabList.Add(Tprefab10);
        TprefabList.Add(Tprefab11);
        TprefabList.Add(Tprefab12);

        locationList.Add(S1Location1);
        locationList.Add(S1Location2);
        locationList.Add(S1Location3);
        locationList.Add(S1Location4);
        locationList.Add(S1Location5);
        locationList.Add(S1Location6);
        locationList.Add(S1Location7);
        locationList.Add(S1Location8);
        locationList.Add(S1Location9);
        locationList.Add(S1Location10);
        locationList.Add(S1Location11);
        locationList.Add(S1Location12);
        locationList.Add(S2Location1);
        locationList.Add(S2Location2);
        locationList.Add(S2Location3);
        locationList.Add(S2Location4);
        locationList.Add(S2Location5);
        locationList.Add(S2Location6);
        locationList.Add(S2Location7);
        locationList.Add(S2Location8);
        locationList.Add(S2Location9);
        locationList.Add(S2Location10);
        locationList.Add(S2Location11);
        locationList.Add(S2Location12);
        locationList.Add(S3Location1);
        locationList.Add(S3Location2);
        locationList.Add(S3Location3);
        locationList.Add(S3Location4);
        locationList.Add(S3Location5);
        locationList.Add(S3Location6);
        locationList.Add(S3Location7);
        locationList.Add(S3Location8);
        locationList.Add(S3Location9);
        locationList.Add(S3Location10);
        locationList.Add(S3Location11);
        locationList.Add(S3Location12);
        locationList.Add(S4Location1);
        locationList.Add(S4Location2);
        locationList.Add(S4Location3);
        locationList.Add(S4Location4);
        locationList.Add(S4Location5);
        locationList.Add(S4Location6);
        locationList.Add(S4Location7);
        locationList.Add(S4Location8);
        locationList.Add(S4Location9);
        locationList.Add(S4Location10);
        locationList.Add(S4Location11);
        locationList.Add(S4Location12);
        locationList.Add(S5Location1);
        locationList.Add(S5Location2);
        locationList.Add(S5Location3);
        locationList.Add(S5Location4);
        locationList.Add(S5Location5);
        locationList.Add(S5Location6);
        locationList.Add(S5Location7);
        locationList.Add(S5Location8);
        locationList.Add(S5Location9);
        locationList.Add(S5Location10);
        locationList.Add(S5Location11);
        locationList.Add(S5Location12);
        locationList.Add(S6Location1);
        locationList.Add(S6Location2);
        locationList.Add(S6Location3);
        locationList.Add(S6Location4);
        locationList.Add(S6Location5);
        locationList.Add(S6Location6);
        locationList.Add(S6Location7);
        locationList.Add(S6Location8);
        locationList.Add(S6Location9);
        locationList.Add(S6Location10);
        locationList.Add(S6Location11);
        locationList.Add(S6Location12);
        locationList.Add(S7Location1);
        locationList.Add(S7Location2);
        locationList.Add(S7Location3);
        locationList.Add(S7Location4);
        locationList.Add(S7Location5);
        locationList.Add(S7Location6);
        locationList.Add(S7Location7);
        locationList.Add(S7Location8);
        locationList.Add(S7Location9);
        locationList.Add(S7Location10);
        locationList.Add(S7Location11);
        locationList.Add(S7Location12);
        locationList.Add(S8Location1);
        locationList.Add(S8Location2);
        locationList.Add(S8Location3);
        locationList.Add(S8Location4);
        locationList.Add(S8Location5);
        locationList.Add(S8Location6);
        locationList.Add(S8Location7);
        locationList.Add(S8Location8);
        locationList.Add(S8Location9);
        locationList.Add(S8Location10);
        locationList.Add(S8Location11);
        locationList.Add(S8Location12);
        locationList.Add(S9Location1);
        locationList.Add(S9Location2);
        locationList.Add(S9Location3);
        locationList.Add(S9Location4);
        locationList.Add(S9Location5);
        locationList.Add(S9Location6);
        locationList.Add(S9Location7);
        locationList.Add(S9Location8);
        locationList.Add(S9Location9);
        locationList.Add(S9Location10);
        locationList.Add(S9Location11);
        locationList.Add(S9Location12);
        locationList.Add(S10Location1);
        locationList.Add(S10Location2);
        locationList.Add(S10Location3);
        locationList.Add(S10Location4);
        locationList.Add(S10Location5);
        locationList.Add(S10Location6);
        locationList.Add(S10Location7);
        locationList.Add(S10Location8);
        locationList.Add(S10Location9);
        locationList.Add(S10Location10);
        locationList.Add(S10Location11);
        locationList.Add(S10Location12);
        locationList.Add(S11Location1);
        locationList.Add(S11Location2);
        locationList.Add(S11Location3);
        locationList.Add(S11Location4);
        locationList.Add(S11Location5);
        locationList.Add(S11Location6);
        locationList.Add(S11Location7);
        locationList.Add(S11Location8);
        locationList.Add(S11Location9);
        locationList.Add(S11Location10);
        locationList.Add(S11Location11);
        locationList.Add(S11Location12);
        locationList.Add(S12Location1);
        locationList.Add(S12Location2);
        locationList.Add(S12Location3);
        locationList.Add(S12Location4);
        locationList.Add(S12Location5);
        locationList.Add(S12Location6);
        locationList.Add(S12Location7);
        locationList.Add(S12Location8);
        locationList.Add(S12Location9);
        locationList.Add(S12Location10);
        locationList.Add(S12Location11);
        locationList.Add(S12Location12);
        locationList.Add(S13Location1);
        locationList.Add(S13Location2);
        locationList.Add(S13Location3);
        locationList.Add(S13Location4);
        locationList.Add(S13Location5);
        locationList.Add(S13Location6);
        locationList.Add(S13Location7);
        locationList.Add(S13Location8);
        locationList.Add(S13Location9);
        locationList.Add(S13Location10);
        locationList.Add(S13Location11);
        locationList.Add(S13Location12);
        locationList.Add(S14Location1);
        locationList.Add(S14Location2);
        locationList.Add(S14Location3);
        locationList.Add(S14Location4);
        locationList.Add(S14Location5);
        locationList.Add(S14Location6);
        locationList.Add(S14Location7);
        locationList.Add(S14Location8);
        locationList.Add(S14Location9);
        locationList.Add(S14Location10);
        locationList.Add(S14Location11);
        locationList.Add(S14Location12);
        locationList.Add(S15Location1);
        locationList.Add(S15Location2);
        locationList.Add(S15Location3);
        locationList.Add(S15Location4);
        locationList.Add(S15Location5);
        locationList.Add(S15Location6);
        locationList.Add(S15Location7);
        locationList.Add(S15Location8);
        locationList.Add(S15Location9);
        locationList.Add(S15Location10);
        locationList.Add(S15Location11);
        locationList.Add(S15Location12);
        locationList.Add(S16Location1);
        locationList.Add(S16Location2);
        locationList.Add(S16Location3);
        locationList.Add(S16Location4);
        locationList.Add(S16Location5);
        locationList.Add(S16Location6);
        locationList.Add(S16Location7);
        locationList.Add(S16Location8);
        locationList.Add(S16Location9);
        locationList.Add(S16Location10);
        locationList.Add(S16Location11);
        locationList.Add(S16Location12);

        TlocationList.Add(T1Location1);
        TlocationList.Add(T1Location2);
        TlocationList.Add(T1Location3);
        TlocationList.Add(T1Location4);
        TlocationList.Add(T1Location5);
        TlocationList.Add(T1Location6);
        TlocationList.Add(T2Location1);
        TlocationList.Add(T2Location2);
        TlocationList.Add(T2Location3);
        TlocationList.Add(T2Location4);
        TlocationList.Add(T2Location5);
        TlocationList.Add(T2Location6);
        TlocationList.Add(T3Location1);
        TlocationList.Add(T3Location2);
        TlocationList.Add(T3Location3);
        TlocationList.Add(T3Location4);
        TlocationList.Add(T3Location5);
        TlocationList.Add(T3Location6);
        TlocationList.Add(T4Location1);
        TlocationList.Add(T4Location2);
        TlocationList.Add(T4Location3);
        TlocationList.Add(T4Location4);
        TlocationList.Add(T4Location5);
        TlocationList.Add(T4Location6);
        TlocationList.Add(T5Location1);
        TlocationList.Add(T5Location2);
        TlocationList.Add(T5Location3);
        TlocationList.Add(T5Location4);
        TlocationList.Add(T5Location5);
        TlocationList.Add(T5Location6);
        TlocationList.Add(T6Location1);
        TlocationList.Add(T6Location2);
        TlocationList.Add(T6Location3);
        TlocationList.Add(T6Location4);
        TlocationList.Add(T6Location5);
        TlocationList.Add(T6Location6);



        //initialling array from 0 to 191
        for (int i = 0; i < 192; i++)
        {
            RandomArray[i] = i;
        }
 
        for (int m = RandomArray.Length - 1; m >= 0; m--)
        {
            int r = Random.Range(0, m);
            int tmp = RandomArray[m];
            RandomArray[m] = RandomArray[r];
            RandomArray[r] = tmp;
        }

        for (int n = 0; n < 192; n++)
        {
            Instantiate(prefabList[RandomArray[n] % 42],locationList[n].position, prefabList[RandomArray[n] % 42].transform.rotation);
        }

        for (int a = 0; a < 36; a++)
        {
            RandomTArray[a] = a;
        }

        for (int b = RandomTArray.Length - 1; b >= 0; b--)
        {
            int rn = Random.Range(0, b);
            int temp = RandomTArray[b];
            RandomTArray[b] = RandomTArray[rn];
            RandomTArray[rn] = temp;
        }
        for (int n = 0; n < 36; n++)
        {
            Instantiate(TprefabList[RandomTArray[n] % 12], TlocationList[n].position, TprefabList[RandomTArray[n] % 12].transform.rotation);
        }
    }
}
