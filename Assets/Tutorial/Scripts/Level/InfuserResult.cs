using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InfuserResult : MonoBehaviour, IPointerClickHandler {
    
    private bool provideMetalGem; // Earth + Earth
    private bool provideLightningGem; // Fire + Fire
    private bool provideIceGem; // Water + Water
    private bool provideLavaGem; // Earth + Fire
    private bool provideSteamGem; // Fire + Water
    private bool provideMudGem; // Earth + Water

    public GameObject imageMetalGem;
    public GameObject imageLightningGem;
    public GameObject imageIceGem;
    public GameObject imageLavaGem;
    public GameObject imageSteamGem;
    public GameObject imageMudGem;


    [Header("Testing parent stuff")]
    public GameObject earthGem1;
    public GameObject earthGem2;
    public GameObject parentEarth;
    public GameObject fireGem1;
    public GameObject fireGem2;
    public GameObject parentFire;
    public GameObject waterGem1;
    public GameObject waterGem2;
    public GameObject parentWater;

    public GameObject insertLeftGem; //the image
    public GameObject insertRightGem; //the image


    InfuserSlotLeft infuserSlotLeft;
    InfuserSlotRight infuserSlotRight;

    //private bool slotsFilled;

    void Start ()
    {
        provideMetalGem = false;
        provideLightningGem = false;
        provideIceGem = false;
        provideLavaGem = false;
        provideSteamGem = false;
        provideMudGem = false;
}


    void Update()
    {
        // add another restriction.. FAVOR REQUIRED!
        // metal. if LEFT has child earth && RIGHT has child earth -> 

        if (provideMetalGem == false && (insertLeftGem.transform.Find("GemEarthItem") && insertRightGem.transform.Find("GemEarthItem") && PlayerStats.gemsEarthAmount >= 2))
        {
            Debug.Log("Metal gem is ready");
            provideMetalGem = true;
            imageMetalGem.GetComponent<Image>().enabled = true; //
        }

        //Lightning
        if (provideLightningGem == false && (insertLeftGem.transform.Find("GemFireItem") && insertRightGem.transform.Find("GemFireItem") && PlayerStats.gemsFireAmount >= 2))
        {
            Debug.Log("Lightning gem is ready");
            provideLightningGem = true;
            imageLightningGem.GetComponent<Image>().enabled = true; //
        }

        //Ice
        if (provideIceGem == false && (insertLeftGem.transform.Find("GemWaterItem") && insertRightGem.transform.Find("GemWaterItem") && PlayerStats.gemsWaterAmount >= 2))
        {
            Debug.Log("Ice gem is ready");
            provideIceGem = true;
            imageIceGem.GetComponent<Image>().enabled = true; //
        }

        //Lava
        if (provideLavaGem == false && (((insertLeftGem.transform.Find("GemEarthItem") && insertRightGem.transform.Find("GemFireItem")) || (insertLeftGem.transform.Find("GemFireItem") && insertRightGem.transform.Find("GemEarthItem"))) && PlayerStats.gemsEarthAmount >= 1 && PlayerStats.gemsFireAmount >= 1))
        {
            Debug.Log("Lava gem is ready");
            provideLavaGem = true;
            imageLavaGem.GetComponent<Image>().enabled = true; //
        }
        
        //steam
        if (provideSteamGem == false && (((insertLeftGem.transform.Find("GemWaterItem") && insertRightGem.transform.Find("GemFireItem")) || (insertLeftGem.transform.Find("GemFireItem") && insertRightGem.transform.Find("GemWaterItem"))) && PlayerStats.gemsFireAmount >= 1 && PlayerStats.gemsWaterAmount >= 1))
        {
            Debug.Log("Steam gem is ready");
            provideSteamGem = true;
            imageSteamGem.GetComponent<Image>().enabled = true; //
        }

        //Mud
        if (provideMudGem == false && (((insertLeftGem.transform.Find("GemEarthItem") && insertRightGem.transform.Find("GemWaterItem")) || (insertLeftGem.transform.Find("GemWaterItem") && insertRightGem.transform.Find("GemEarthItem"))) && PlayerStats.gemsEarthAmount >= 1 && PlayerStats.gemsWaterAmount >= 1))
        {
            Debug.Log("Mud gem is ready");
            provideMudGem = true;
            imageMudGem.GetComponent<Image>().enabled = true; //
        }
        //else
        //{
        //    provideMudGem = false;
        //    imageMudGem.GetComponent<Image>().enabled = false;
        //}
    }


 //   void OnMouseDown()

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (provideMetalGem == true)
        {
            Debug.Log("Metal gem Claimed");
            imageMetalGem.GetComponent<Image>().enabled = false;
            provideMetalGem = false;
            PlayerStats.gemsEarthAmount -= 2; //UI earth gem -2
            PlayerStats.gemsMetalAmount += 1; //UI metal gem +1
            ResetParentGems(); //removes both gems left and right
            ResetInfuserSlots();
        }

        if (provideLightningGem == true)
        {
            Debug.Log("Lightning gem Claimed");
            imageLightningGem.GetComponent<Image>().enabled = false;
            provideLightningGem = false;
            PlayerStats.gemsFireAmount -= 2;
            PlayerStats.gemsLightningAmount += 1;
            ResetParentGems();
            ResetInfuserSlots();
        }

        if (provideIceGem == true)
        {
            imageIceGem.GetComponent<Image>().enabled = false;
            provideIceGem = false;
            PlayerStats.gemsWaterAmount -= 2;
            PlayerStats.gemsIceAmount += 1;
            ResetParentGems();
            ResetInfuserSlots();
        }

        if (provideLavaGem == true)
        {
            imageLavaGem.GetComponent<Image>().enabled = false;
            provideLavaGem = false;
            PlayerStats.gemsEarthAmount -= 1;
            PlayerStats.gemsFireAmount -= 1;
            PlayerStats.gemsLavaAmount += 1;
            ResetParentGems();
            ResetInfuserSlots();
        }

        if (provideSteamGem == true)
        {
            imageSteamGem.GetComponent<Image>().enabled = false;
            provideSteamGem = false;
            PlayerStats.gemsFireAmount -= 1;
            PlayerStats.gemsWaterAmount -= 1;
            PlayerStats.gemsSteamAmount += 1;
            ResetParentGems();
            ResetInfuserSlots();
        }

        if (provideMudGem == true)
        {
            imageMudGem.GetComponent<Image>().enabled = false;
            provideMudGem = false;
            PlayerStats.gemsEarthAmount -= 1;
            PlayerStats.gemsWaterAmount -= 1;
            PlayerStats.gemsMudAmount += 1;
            ResetParentGems();
            ResetInfuserSlots();
        }

    }
    
    public static void ResetInfuserSlots() //static?
    {
        //Debug.Log("Infuser slots have been reset");
        InfuserSlotLeft.hasEarthGemLeft = false;
        InfuserSlotRight.hasEarthGemRight = false;
        InfuserSlotLeft.hasFireGemLeft = false;
        InfuserSlotRight.hasFireGemRight = false;
        InfuserSlotLeft.hasWaterGemLeft = false;
        InfuserSlotRight.hasWaterGemRight = false;
    }


    public void ResetParentGems()
    {
        earthGem1.transform.SetParent(parentEarth.transform, false); //Fix the return position to be Fully Stretched
        earthGem2.transform.SetParent(parentEarth.transform, false); //Fix the return position to be Fully Stretched
        fireGem1.transform.SetParent(parentFire.transform, false); //Fix the return position to be Fully Stretched
        fireGem2.transform.SetParent(parentFire.transform, false); //Fix the return position to be Fully Stretched
        waterGem1.transform.SetParent(parentWater.transform, false); //Fix the return position to be Fully Stretched
        waterGem2.transform.SetParent(parentWater.transform, false); //Fix the return position to be Fully Stretched

        earthGem1.transform.localRotation = Quaternion.identity;
        earthGem1.transform.localScale = Vector3.one;
        earthGem1.transform.localPosition = Vector3.zero;

        earthGem2.transform.localRotation = Quaternion.identity;
        earthGem2.transform.localScale = Vector3.one;
        earthGem2.transform.localPosition = Vector3.zero;

        fireGem1.transform.localRotation = Quaternion.identity;
        fireGem1.transform.localScale = Vector3.one;
        fireGem1.transform.localPosition = Vector3.zero;

        fireGem2.transform.localRotation = Quaternion.identity;
        fireGem2.transform.localScale = Vector3.one;
        fireGem2.transform.localPosition = Vector3.zero;

        waterGem1.transform.localRotation = Quaternion.identity;
        waterGem1.transform.localScale = Vector3.one;
        waterGem1.transform.localPosition = Vector3.zero;

        waterGem2.transform.localRotation = Quaternion.identity;
        waterGem2.transform.localScale = Vector3.one;
        waterGem2.transform.localPosition = Vector3.zero;
    }



    /// <summary>
    /// 
    /// if image* insertGemLeft has earth/fire/water
    /// &&
    /// if image* insertGemRight has earth/fire/water
    /// 
    /// Results in a new gem
    /// Remove gems used in the process
    /// 
    /// PlayerStats.gemsEarthAmount -= 1;
    /// 
    /// if (GameObject.Find("BasicTower(Clone)"))
    /// 
    ///
    ///     if (GameObject.Find("GemEarthItem"))
    ///     {
    ///         Debug.Log("Earth Gem inserted");
    ///     }
    /// 
    /// 
    /// 
    ///         //if (gemLeftImage.name == earthItem.name)
    //{
    //    Debug.Log("Earth Gem inserted");
    //}

    //if (gemLeftImage.gameObject == earthItem.gameObject)
    //{
    //    Debug.Log("Earth Gem inserted");
    //}

    //if (GameObject.Find(""))
    //{
    //
    //}
    /// </summary>


}
