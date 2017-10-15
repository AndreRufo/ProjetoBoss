﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static List<GameObject> LifePointList { get; set; }
    public static GameObject[] LifePointArray { get; set; }

    //public Text MiddleCanvasText;
    //public static GameObject LifeBarPanel { get; set; }
    public GameObject LifeBarPanel;
    public Canvas Canvas;

    private void Awake()
    {

        //LifeBarPanel = Resources.Load<GameObject>("Prefabs/LifeBarPanel");
        //GameObject.Instantiate(LifeBarPanel, Canvas.transform);
    }
    private void Start()
    {
        LifePointList = new List<GameObject>();

        LifePointArray = new GameObject[20];

        //LifePointArray[0] = Resources.Load<GameObject>("Prefabs/LifePoint");

        //GameObject.Instantiate(LifePointArray[0], LifeBarPanel.transform);

        //for (int i = 1; i < 20; i++)
        //{
        //    LifePointArray[i] = LifePointArray[i - 1];
        //    GameObject.Instantiate(LifePointArray[i], LifeBarPanel.transform);
        //}

        //for (int i = 0; i < 20; i++)
        //{
        //    LifePointArray[i] = Resources.Load<Image>("Prefabs/LifePoint");
        //    GameObject.Instantiate<Image>(LifePointArray[i], LifeBarPanel.transform);
        //}
        for (int i = 0; i < 20; i++)
        {
            //GameObject go = Resources.Load<GameObject>("Prefabs/LifePoint");
            LifePointArray[i] = Resources.Load<GameObject>("Prefabs/LifePoint");
            //LifePointList.Add(go);
            //print(i);
            LifePointList.Add(GameObject.Instantiate(LifePointArray[i], LifeBarPanel.transform));
        }
        //for (int i = 0; i < 20; i++)
        //{
        //    LifePointArray[i] = LifePointList[i];
        //}
    }

    //TIRAR PONTOS DE VIDA NA BARRA, AO PLAYER
    public static void LifeBarDecrease(int damage, int totalDamageTaken)
    {
        print(PlayerController.MaxHealth);
        for (int i = PlayerController.MaxHealth-1 - totalDamageTaken; i > PlayerController.MaxHealth-1-totalDamageTaken - damage && i>=0; i--)
        {
            LifePointList[i].GetComponent<CanvasGroup>().alpha = 0f;
        }
    }

    //FAZER GAME OVER
    public static void GameOverScreen()
    {
        GameOver.GameOverText.text = "You Died";
    }
}
