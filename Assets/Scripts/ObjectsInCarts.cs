using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsInCarts : MonoBehaviour
{
    public List<string> objectsInAllCarts;
    static Dictionary<string, string> prefabToItemName;


    // Start is called before the first frame update
    void Start()
    {
        objectsInAllCarts = new List<string>();
        prefabToItemName = new Dictionary<string, string>()
        {
            { "Egg_carton", "Eggs" },
            { "Whipped_cream", "Whipped Cream" },
            { "Chocolate_syrup", "Chocolate Syrup" },
            { "Salt_crackers", "Salt Crackers" },
            { "Bread_wrapped", "Bread" },
            { "Peanut_butter", "Peanut Butter" },
            { "Macaroni_cheese", "Macaroni & Cheese" },
            { "Creme_fraiche", "Creme Fraiche" },
            { "Soda_bottle_01", "Soda" },
            { "Canned_beans", "Canned Beans" },
            { "Ice_cream", "Ice Cream" },
            { "Chicken_nuggets 1", "Chicken Nuggets" },
            { "French_fries", "French Fries" },
            { "Fish_sticks", "Fish Sticks" },
            { "Luncheon_meat", "Luncheon Meat" },
            { "Beer_can", "Beer Can" },
            { "Minced_meat", "Minced Meat" },
            { "Six_pack", "Six Pack" },
            { "Candy_bar", "Candy Bar" },
            { "Potato_chips", "Potato Chips" },
            { "Creamy_buns", "Creamy Buns" },
            { "Sushi_dinner_03", "Chutoro Sushi" },
            { "Sushi_dinner_04", "Ebi Sushi" },
            { "Sushi_dinner_05", "Maki Sushi" },
            { "Sushi_dinner_01", "Tamagoyaki Sushi" },
            { "Sushi_dinner_02", "Nigiri Sushi" }
        };
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

    public string GetItemsText()
	{
        string str = "\n";
        foreach (string s in objectsInAllCarts)
        {
            str += s + "\n\n";
        }
        return str;
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
        // remove SMGP_PRE_ / SMGP_pre_
        string processed = objectOriginalName.Replace("SMGP_PRE_", "");
        processed = processed.Replace("SMGP_pre_", "");

        // remove _1024
        processed = processed.Replace("_1024", "");

        // remove (Clone)
        processed = processed.Replace("(Clone)", "");

        if (prefabToItemName.ContainsKey(processed))
		{
            processed = prefabToItemName[processed];
		}

        return processed;
	}
}
