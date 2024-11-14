using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu1 : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    float timeAnim;
    void Start()
    {
        menu.SetActive(true);
    }

    
    void Update()
    { 
       
      
        /* if(menu.activeSelf)
        {
            ShowMenu();
        }*/
        
        
    }

    public void ShowMenu()
    {
        menu.SetActive(true);
        LeanTween.moveLocalY(menu, -261f, 0f);
        LeanTween.moveLocalY(menu, -261f, timeAnim).setEase(LeanTweenType.animationCurve);
        /*LeanTween.moveLocalY(menu, -1100f, 0f);
        LeanTween.moveLocalY(menu, 0f, timeAnim).setEase(LeanTweenType.animationCurve);*/
    }

    public void HideMenu()
    {
        menu.SetActive(true);
        LeanTween.moveLocalY(menu, -322f, 0f);
        LeanTween.moveLocalY(menu, -322f, timeAnim).setEase(LeanTweenType.animationCurve);
    }
}

