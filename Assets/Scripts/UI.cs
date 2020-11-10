﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text Menu;
    public Text Ing1;
    public Text Ing2;
    public Text Ing3;
    public Text Ing4;
    public Text Ing5;
    public Text Ing6;
    public Text BonusSushi;

    bool fin = false;
    string[,] MenuList = new string[10, 7] {{"Pancake","Egg","Flour","Milk","Sugar","Whipped Cream","Chocolate Syrup"},
                                      {"Chicken Soup","Chicken","Soup","Rice ","Salt","Salt Crackers","Sugar"},
                                      {"Bread","Bread","Jam","Cheese","Mustard","Mayonnaise","Peanut Butter"},
                                      {"Breakfast","Cereal","Coffee","Macaroni & Cheese","Creme Fraiche","Salami","Pudding"},
                                      {"Spaghetti","Pasta ","Tuna","Salt","Soda","Bottle Beans","Ice cream"},
                                      {"Fast Food","Chicken Nuggets","French Fries","Fish Sticks","Soda","Katchup","Cookies"},
                                      {"Noodle","Noodles","Luncheon Meat","Pudding","Juice","Milk","Egg"},
                                      {"Baked Salmon","Salmon","Potato","Salt","Butter","Beer Can","Lolipop"},
                                      {"Rice Bowl","Minced Meat","Rice","Potato","Salt","Six pack","Candy Bar"},
                                      {"BBQ Party","Cutlet","Candy Bar","Lolipop","Potato Chips","Bubblegum","Creamy Buns" }};
    string[] Sushi = new string[5] {"Chutoro Sushi","Ebi Sushi","Nigiri Sushi","Piece Sushi","Tamagoyaki Sushi"};


    void Update()
    {
        int num = Random.Range(1, 11);
        int bonus = Random.Range(1, 6);
        if (!fin)
        {
            Menu.text = MenuList[num,0];
            Ing1.text = MenuList[num,1];
            Ing2.text = MenuList[num,2];
            Ing3.text = MenuList[num,3];
            Ing4.text = MenuList[num,4];
            Ing5.text = MenuList[num,5];
            Ing6.text = MenuList[num,6];
            BonusSushi.text = Sushi[bonus];
            fin = true;
        }
    }
}
