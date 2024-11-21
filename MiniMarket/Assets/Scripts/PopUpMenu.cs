using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PopUp : MonoBehaviour
{
    [SerializeField]
    GameObject popup;
    [SerializeField]
    float timeAnim;

    void Start()
    {
        {
            popup.SetActive(false);
           
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))

        {
            if (popup.activeSelf)
            {
                HidePopUp();
            }

            else
            {
                ShowPopUp();
            }
        }
    }

    public void ShowPopUp()
    {

        popup.SetActive(true);
        LeanTween.moveLocalY(popup, -347f, 1f);
        LeanTween.moveLocalY(popup, -347f, timeAnim).setEase(LeanTweenType.animationCurve);
    }

    public void HidePopUp()
    {
        LeanTween.moveLocalY(popup, -561f, timeAnim).setEase(LeanTweenType.animationCurve).setOnComplete(() =>
        {
            popup.SetActive(false);

        });



    }

    
}
