using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatingGem : MonoBehaviour {
    
    //rating 1-100. Based on % of life left. eg 1/10 left = 10% = score 10. 5/20 left is 1/4 = 25% = score 25.

    ////public int tempRating;

    //public float fillAmount;
    //public Color color;


    //public static RatingGem Instance;

    //private void Awake()
    //{
    //    Instance = this;
    //}


    private void Start()
    {
        //fillAmount = gem.GetComponent<Image>().fillAmount;
        //color = gem.GetComponent<Image>().color;
        //Debug.Log("Rating: " + GameManager.rating);
        //GameManager.rating = tempRating;
        //Debug.Log("Rating: " + GameManager.rating);
    }

    
    public void Awake() //Do NOT USE ON UPDATE!!!! Use a function to call after ending a game?
    {
        if (GameManager.rating >= 1 && GameManager.rating <= 9) // 1/20 lives left
        {
            GetComponent<Image>().color = new Color32(255, 0, 0, 255); // basically Color.red;
        }
        if (GameManager.rating >= 10 && GameManager.rating <= 14) // 2/20 or 1/10 lives left
        {
            GetComponent<Image>().color = new Color32(255, 30, 4, 255);
        }
        if (GameManager.rating == 15) // 3/20 lives left
        {
            GetComponent<Image>().color = new Color32(255, 60, 8, 255); //
        }
        if (GameManager.rating == 20) // 4/20 or 2/10 lives left
        {
            GetComponent<Image>().color = new Color32(255, 90, 12, 255);
        }
        if (GameManager.rating == 25) // 5/20 lives left
        {
            GetComponent<Image>().color = new Color32(255, 119, 16, 255); //Orange
        }
        if (GameManager.rating == 30) // 6/20 or 3/10 lives left
        {
            GetComponent<Image>().color = new Color32(255, 151, 12, 255);
        }
        if (GameManager.rating == 35) // 7/20 lives left
        {
            GetComponent<Image>().color = new Color32(255, 183, 8, 255);
        }
        if (GameManager.rating == 40) // 8/20 or 4/10 lives left
        {
            GetComponent<Image>().color = new Color32(255, 215, 4, 255);
        }
        if (GameManager.rating == 45) // 9/20 lives left
        {
            GetComponent<Image>().color = new Color32(255, 248, 0, 255); // Yellow
        }
        if (GameManager.rating == 50) // 10/20 or 5/10 lives left
        {
            GetComponent<Image>().color = new Color32(228, 249, 0, 255);
        }
        if (GameManager.rating == 55) // 11/20 lives left
        {
            GetComponent<Image>().color = new Color32(201, 251, 0, 255);
        }
        if (GameManager.rating == 60) // 12/20 or 6/10 lives left
        {
            GetComponent<Image>().color = new Color32(174, 253, 0, 255);
        }
        if (GameManager.rating == 65) // 13/20 lives left
        {
            GetComponent<Image>().color = new Color32(146, 255, 0, 255); //Light green
        }
        if (GameManager.rating == 70) // 14/20 or 7/10 lives left
        {
            GetComponent<Image>().color = new Color32(126, 255, 0, 255);
        }
        if (GameManager.rating == 75) // 15/20 lives left
        {
            GetComponent<Image>().color = new Color32(106, 255, 0, 255);
        }
        if (GameManager.rating == 80) // 16/20 or 8/10 lives left
        {
            GetComponent<Image>().color = new Color32(86, 255, 0, 255);
        }
        if (GameManager.rating == 85) // 17/20 lives left
        {
            GetComponent<Image>().color = new Color32(66, 255, 0, 255); //
        }
        if (GameManager.rating == 90) // 18/20 or 9/10 lives left
        {
            GetComponent<Image>().color = new Color32(46, 255, 0, 255);
        }
        if (GameManager.rating == 95) // 19/20 lives left
        {
            GetComponent<Image>().color = new Color32(26, 255, 0, 255);
        }
        if (GameManager.rating == 100) // 20/20 or 10/10 lives left
        {
            GetComponent<Image>().color = new Color32(9, 255, 0, 255); // Dark green // ?Color.green;
        }
        
        //if (GameManager.rating >= 96 && GameManager.rating <= 100) // 19/20 to 20/20 lives left


        //if (fillAmount >= 0.5f)
        //{
        //    gem.GetComponent<Image>().color = Color.red;
        //}
        //if (fillAmount <= 0.5f)
        //{
        //   gem.GetComponent<Image>().color = Color.cyan;
        //}
    }
    
}
