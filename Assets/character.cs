using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class character : MonoBehaviour {

    public Text healthPointsText; //жизни
    public int healthPoints;

    public Text coinsText; //деньги
    public int coins;

    public Text exPointsText; //опыт
    public int exPoints;

    public Text armoText; //броня
    public int armo;

    public Text damageText; //сила
    public int damage;


   

    // Use this for initialization
    void Start ()
    {
        coinsText.text = "Деньги";
        healthPointsText.text = "Жизни";
        exPointsText.text = "Опыт";
        armoText.text = "Броня";
        damageText.text = "Сила";

        healthPoints = 100;
        coins = 3;
        exPoints = 0;
        armo = 25;
        damage = 15;

       
    }



    // Update is called once per frame
    void Update()
    {

        coinsText.text = coins.ToString();
        healthPointsText.text = healthPoints.ToString();
        exPointsText.text = exPoints.ToString();
        armoText.text = armo.ToString();
        damageText.text = damage.ToString();



    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "monster")
        {
            healthPoints = healthPoints - 15;
            exPoints = exPoints + 5;
            armo = armo - 1;
            damage = damage + 1; 
        }

        if (other.tag == "moneta")
        {
            coins += 5;
            exPoints += 3;
            Destroy(other.gameObject);
        }
        if (other.tag == "apteca")
        {
            healthPoints += 35;
            exPoints += 4;
            Destroy(other.gameObject);
        }
        if (other.tag == "bag")
        {
            coins += 15;
            exPoints += 9;
            Destroy(other.gameObject);
        }
        if (other.tag == "sword")
        {
            damage += 3;
            armo += 2;
            exPoints += 7;
            Destroy(other.gameObject);
        }
        if (other.tag == "broniy")
        {
            armo += 10;
            healthPoints += 1;
            exPoints += 10;
            Destroy(other.gameObject);
        }

    }
}
