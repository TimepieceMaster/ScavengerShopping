using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForWin : MonoBehaviour
{
    bool gameWon = false;
    AudioSource gameWinSFX;

    UI ui;
    ObjectsInCarts objectsInCarts;

    // Start is called before the first frame update
    void Start()
    {
        gameWinSFX = GetComponent<AudioSource>();
        ui = FindObjectOfType<UI>();
        objectsInCarts = FindObjectOfType<ObjectsInCarts>();
    }

    // Update is called once per frame
    void Update()
    {
       if (!gameWon)
		{
            CheckForItemsInCarts();
		}
    }

    void CheckForItemsInCarts()
	{
        List<string> itemsToWin = ui.GetIngredientNames();
        List<string> objectsInAllCarts = objectsInCarts.objectsInAllCarts;

        foreach (string item in itemsToWin)
        {
            bool foundThisItem = false;
            foreach (string cartItem in objectsInAllCarts)
            {
                if (item.Equals(cartItem))
				{
                    foundThisItem = true;
                    break;
				}
            }
            if (!foundThisItem)
			{
                return;
			}
        }
        gameWon = true;
        AudioSource music = GameObject.Find("Music").GetComponent<AudioSource>();
        music.Stop();
        gameWinSFX.Play();
    }
}
