using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

    //place this on enemies, towers, everything that needs a tooltip..

    [Header("Enemy Bools")]
    public bool enemyClicked; // if any enemy is clicked
    public bool enemyClicked1; // or use Coroutines??
    public bool enemyClicked2; // 2nd enemy clicked
    public bool enemyClicked3;

    public int enemyType = 0;

    public GameObject enemyToolTipText;


    private void OnMouseDown() // FIX THIS CODE. Image stays true PER ENEMY
    {
        if (enemyType == 1)
        {
            Debug.Log("Fast Enemy");
            enemyClicked1 = true;
            enemyToolTipText.GetComponent<Text>().enabled = true;
        }
        if (enemyType == 2)
        {
            Debug.Log("Simple Enemy");
            enemyClicked2 = true;
            enemyToolTipText.GetComponent<Text>().enabled = true;
            //tooltip.enemyTooltipObject.SetActive(true);
        }
        if (enemyType == 3)
        {
            Debug.Log("Tough Enemy");
            enemyClicked3 = true;
            enemyToolTipText.GetComponent<Text>().enabled = true;
            //tooltip.enemyTooltip.SetActive(true);
        }
    }

    
    //   public void Update() //change to different function??
    //   {
    //       if (enemy.enemyClicked == true && imageActive == false)
    //       {
    //           enemyTooltipImage.GetComponent<Image>().enabled = true;
    //           enemyTooltipObject.SetActive(true);
    //            imageActive = true;
    //           Debug.Log("Is Active");
    //       }
    //   }



    //   void Start() // every time the object gets enabled
    //   {
    //       StartCoroutine(activeEnemy());
    //   }

    //   IEnumerator activeEnemy()
    //   {
    //       yield return new WaitForSeconds(0.7f);

    //       Debug.Log("Not Active");

    //       if (enemy.enemyClicked1 == true)
    //      {
    //          Debug.Log("Clicked1 active");
    //          yield return new WaitForSeconds(0.05f);
    //      }
    //  }
}


/// <summary>
/// 
/// if (bool.Enemy1 = active
/// {
/// tooltip1.GetComponent<Text>().enabled = true;
/// }
/// 
/// if (Input.GetKeyDown(KeyCode.Escape))
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// </summary>
/// <param name="eventData"></param>



//   private void OnMouseDown()

//description.SetActive(true);

//description.GetComponent<Text>().enabled = true;
//Shows all that monsters Stats and Description in the tooltip box
//Open up the Monsternomicon, on the page of that particular enemy.
//Debug.Log("Get target info");

