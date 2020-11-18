using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;

public class UI : MonoBehaviour
{
    ObjectsInCarts objectsInAllCarts;

    public Text Menu;
    public Text Ing1;
    public Text Ing2;
    public Text Ing3;
    public Text Ing4;
    public Text Ing5;
    public Text Ing6;
    public Text BonusSushi;

    public Text ItemsInCartText;

    string[,] MenuList = new string[10, 7] {{"Pancake","Eggs","Flour","Milk","Sugar","Whipped Cream","Chocolate Syrup"},
                                      {"Chicken Soup","Chicken","Soup","Rice","Salt","Salt Crackers","Sugar"},
                                      {"Sandwich","Bread","Jam","Cheese","Mustard","Mayonnaise","Peanut Butter"},
                                      {"Breakfast","Cereal","Coffee","Macaroni & Cheese","Creme Fraiche","Salami","Pudding"},
                                      {"Spaghetti","Pasta","Tuna","Salt","Soda","Canned Beans","Ice cream"},
                                      {"Fast Food","Chicken Nuggets","French Fries","Fish Sticks","Soda","Ketchup","Cookies"},
                                      {"Noodle Dish","Noodles","Luncheon Meat","Pudding","Juice","Milk","Eggs"},
                                      {"Baked Salmon","Salmon","Potatoes","Salt","Butter","Beer Can","Lollipop"},
                                      {"Rice Bowl","Minced Meat","Rice","Potatoes","Salt","Six Pack","Candy Bar"},
                                      {"BBQ Party","Cutlets","Candy Bar","Lollipop","Potato Chips","Bubblegum","Creamy Buns" }};
    string[] Sushi = new string[5] {"Chutoro Sushi","Ebi Sushi","Nigiri Sushi","Maki Sushi","Tamagoyaki Sushi"};

    void Start() {

        objectsInAllCarts = FindObjectOfType<ObjectsInCarts>();

        int num = Random.Range(0, 9);
        int bonus = Random.Range(0, 4);

        if (PhotonNetwork.LocalPlayer.IsMasterClient)
        {
            ExitGames.Client.Photon.Hashtable CustomeValue = new ExitGames.Client.Photon.Hashtable();
            CustomeValue.Add("num", num);
            CustomeValue.Add("bonus", bonus);
            PhotonNetwork.CurrentRoom.SetCustomProperties(CustomeValue);
        }
        else {
            num = int.Parse(PhotonNetwork.CurrentRoom.CustomProperties["num"].ToString());
            bonus = int.Parse(PhotonNetwork.CurrentRoom.CustomProperties["bonus"].ToString());
        }

        SetMenuText(num, bonus);

    }

    void Update()
	{
        ItemsInCartText.text = objectsInAllCarts.GetItemsText();
	}

    void SetMenuText(int num,int bonus) {
        Menu.text = MenuList[num,0];
        Ing1.text = MenuList[num,1];
        Ing2.text = MenuList[num,2];
        Ing3.text = MenuList[num,3];
        Ing4.text = MenuList[num,4];
        Ing5.text = MenuList[num,5];
        Ing6.text = MenuList[num,6];
        BonusSushi.text = Sushi[bonus];
    }
}
