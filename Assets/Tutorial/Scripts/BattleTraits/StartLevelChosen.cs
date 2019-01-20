using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartLevelChosen : MonoBehaviour, IPointerClickHandler{

    public SceneFader sceneFader;

    private int levelStart;

    private string myLevel; 
    private string a = "Level01"; //Scene name
    private string b = "Level02";
    private string c = "Level03";
    private string d = "Level04";
    private string e = "Level05";
    private string f = "Level06";
    private string g = "Level07";
    private string h = "Level08";
    private string i = "Level09";
    private string j = "Level10";
    //etc

    public void Start()
    {
        if (LevelStart.a == true)
        {
            myLevel = a.ToString();
            //LevelStart.a = false;
        }
        if (LevelStart.b == true)
        {
            myLevel = b.ToString();
            //LevelStart.b = false;
        }
        if (LevelStart.c == true)
        {
            myLevel = c.ToString();
            //LevelStart.c = false;
        }
        if (LevelStart.d == true)
        {
            myLevel = d.ToString();
            //LevelStart.d = false;
        }
        if (LevelStart.e == true)
        {
            myLevel = e.ToString();
            //LevelStart.e = false;
        }
        if (LevelStart.f == true)
        {
            myLevel = f.ToString();
            //LevelStart.f = false;
        }
        if (LevelStart.g == true)
        {
            myLevel = g.ToString();
            //LevelStart.g = false;
        }
        if (LevelStart.h == true)
        {
            myLevel = h.ToString();
            //LevelStart.h = false;
        }
        if (LevelStart.i == true)
        {
            myLevel = i.ToString();
            //LevelStart.i = false;
        }
        if (LevelStart.j == true)
        {
            myLevel = j.ToString();
            //LevelStart.j = false;
        }
        //etc
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        sceneFader.FadeTo(myLevel);
    }
}
