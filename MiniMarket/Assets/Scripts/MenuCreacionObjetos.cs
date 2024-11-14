using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCreacionObjetos : MonoBehaviour
{

    [SerializeField]
    GameObject creacionobj;

    void Start()
    {
        creacionobj.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void ShowCreacion()
    {
        creacionobj.SetActive(true);
        LeanTween.moveLocalX(creacionobj, 346f, 0f);
       
    }
}
