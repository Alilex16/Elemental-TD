using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelStart : MonoBehaviour, IPointerClickHandler{
    
    public static bool a = false;
    public static bool b = false;
    public static bool c = false;
    public static bool d = false;
    public static bool e = false;
    public static bool f = false;
    public static bool g = false;
    public static bool h = false;
    public static bool i = false;
    public static bool j = false;
    
    public int levelNumber;
    public static int levelNumberStatic;


    public void Start()
    {
        //levelNumberStatic = levelNumber;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        levelNumberStatic = levelNumber;
        
        ResetBools();
        
        if (levelNumber == 1)
        {
            //ResetBools();
            a = true;
        }
        if (levelNumber == 2)
        {
            //ResetBools();
            b = true;
        }
        if (levelNumber == 3)
        {
            //ResetBools();
            c = true;
        }
        if (levelNumber == 4)
        {
            //ResetBools();
            d = true;
        }
        if (levelNumber == 5)
        {
            //ResetBools();
            e = true;
        }
        if (levelNumber == 6)
        {
            //ResetBools();
            f = true;
        }
        if (levelNumber == 7)
        {
            //ResetBools();
            g = true;
        }
        if (levelNumber == 8)
        {
            //ResetBools();
            h = true;
        }
        if (levelNumber == 9)
        {
            //ResetBools();
            i = true;
        }
        if (levelNumber == 10)
        {
            //ResetBools();
            j = true;
        }
    }

    public void ResetBools()
    {
        a = false;
        b = false;
        c = false;
        d = false;
        e = false;
        f = false;
        g = false;
        h = false;
        i = false;
        j = false;
    }


}
