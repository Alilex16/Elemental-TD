using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GainedRating : MonoBehaviour
{

    //public Text DTText;
    //private Animation anim;

    public GameObject gem;


    void OnEnable() // every time the object gets enabled
    {
        StartCoroutine(Blurp());
        //GameManager.rating = 75; //Test TOREMOVE
        gem.GetComponent<Image>().fillAmount = 0; //test
        //Debug.Log("Rating: " + GameManager.rating);
        
        //gem.GetComponent<Image>().fillAmount = 0.05f;

        //gem.GetComponent<Image>().fillAmount = (GameManager.rating / 100);

        //Debug.Log("Filled amount: " + gem.GetComponent<Image>().fillAmount);
    }

    IEnumerator Blurp()
    {
        //DTText.text = "0";
        int dt = 0;

        yield return new WaitForSeconds(0.8f); //0.7f

        while (dt < GameManager.rating) //
        {
            dt += 5;
            gem.GetComponent<Image>().fillAmount += 0.05f;

            //Color testing:
            if (dt == 5)
            {
                gem.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            }
            if (dt == 10) // 2/20 or 1/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(255, 30, 4, 255);
            }

            if (dt == 15) // 3/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(255, 60, 8, 255); //
            }
            if (dt == 20) // 4/20 or 2/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(255, 90, 12, 255);
            }
            if (dt == 25) // 5/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(255, 119, 16, 255); //Orange
            }
            if (dt == 30) // 6/20 or 3/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(255, 151, 12, 255);
            }
            if (dt == 35) // 7/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(255, 183, 8, 255);
            }
            if (dt == 40) // 8/20 or 4/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(255, 215, 4, 255);
            }
            if (dt == 45) // 9/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(255, 248, 0, 255); // Yellow
            }
            if (dt == 50) // 10/20 or 5/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(228, 249, 0, 255);
            }
            if (dt == 55) // 11/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(201, 251, 0, 255);
            }
            if (dt == 60) // 12/20 or 6/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(174, 253, 0, 255);
            }
            if (dt == 65) // 13/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(146, 255, 0, 255); //Light green
            }
            if (dt == 70) // 14/20 or 7/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(126, 255, 0, 255);
            }
            if (dt == 75) // 15/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(106, 255, 0, 255);
            }
            if (dt == 80) // 16/20 or 8/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(86, 255, 0, 255);
            }
            if (dt == 85) // 17/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(66, 255, 0, 255); //
            }
            if (dt == 90) // 18/20 or 9/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(46, 255, 0, 255);
            }
            if (dt == 95) // 19/20 lives left
            {
                gem.GetComponent<Image>().color = new Color32(26, 255, 0, 255);
            }
            if (dt == 100) // 20/20 or 10/10 lives left
            {
                gem.GetComponent<Image>().color = new Color32(9, 255, 0, 255); // Dark green // ?Color.green;
            }
            
            yield return new WaitForSeconds(0.07f); //0.05f
        }


    }
}
