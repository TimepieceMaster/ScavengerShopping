using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsInCarts : MonoBehaviour
{
    List<string> objectsInAllCarts;

    // Start is called before the first frame update
    void Start()
    {
        objectsInAllCarts = new List<string>();
    }

	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.P))
		{
            string str = "";
            foreach (string s in objectsInAllCarts)
            {
                str += s + " ";
            }
            Debug.Log(str);
        }
    }

	// Add passed in string to the list
	public void AddToList(string newObject)
	{
        objectsInAllCarts.Add(newObject);
	}

    // Remove passed in string from the list
    public void RemoveFromList(string objectToRemove)
	{
        objectsInAllCarts.Remove(objectToRemove);
    }

    // Convert object names to something more workable
    public static string PreProcess(string objectOriginalName)
	{
        // remove SMGP_PRE_
        string processed = objectOriginalName.Replace("SMGP_PRE_", "");

        // remove _1024
        processed = processed.Replace("_1024", "");

        return processed;
	}
}
