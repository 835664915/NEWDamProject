using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownPanelView : MonoBehaviour
{
    private bool isShow = false;
    private bool isShows = false;
    public Button[] childrenButton;
    public GameObject[] panelGo;
    private void Start()
    {
       // childrenButton = GetComponentsInChildren<Button>();
       //// print(childrenButton.Length);

       // childrenButton[0].onClick.AddListener(delegate ()
       // {
       //     isShow = !isShow;
       //     print(childrenButton[0].name);
       //     if (isShow)
       //     {

       //         panelGo[0].SetActive(false);

       //     }
       //     else
       //     {
       //         panelGo[0].SetActive(true);

       //         for (int i = 0; i < panelGo.Length; i++)
       //         {
       //             if (panelGo[i].activeSelf)
       //             {
       //                 panelGo[i].SetActive(false);
       //             }


       //         }


       //     }



       // }
       //     );

       // childrenButton[1].onClick.AddListener(delegate ()
       // {
       //     isShows = !isShows;
       //     print(childrenButton[1].name);
       //     if (isShows)
       //     {

       //         panelGo[1].SetActive(false);

       //     }
       //     else
       //     {
       //         panelGo[1].SetActive(true);

       //         for (int i = 0; i < panelGo.Length; i++)
       //         {
       //             if (panelGo[i].activeSelf)
       //             {
       //                 panelGo[i].SetActive(false);
       //             }


       //         }


       //     }



       // }
       //    );






    }







}