﻿using System.Collections.Generic;
using UnityEngine;

/*****************************************************
// Author: The Messy Coder
// Date: January 2018
// Video Tutorial: https://youtu.be/6d7pmRE0T6c
// Please support the channel, facebook and on twitter
// YouTube:  www.YouTube.com/TheMessyCoder
// Facebook: www.Facebook.com/TheMessyCoder
// Twitter:  www.Twitter.com/TheMessyCoder
*****************************************************/

namespace Messyspace
{

    [CreateAssetMenu(menuName = "RPG Generator/Player/Create Skill")]
    public class Skills : ScriptableObject
    {
        public string Description;
        public Sprite Icon;
        public int LevelNeeded;
        public int XPNeeded;

        public List<PlayerAttributes> AffectedAttributes = new List<PlayerAttributes>();



        //Public Method to set the values in the Skills UI 
        public void SetValues(GameObject SkillDisplayObject, PlayerStats Player)
        {         
            //bit of error handling - make sure that a SO is used
            if (SkillDisplayObject)
            {
                SkillDisplay SD = SkillDisplayObject.GetComponent<SkillDisplay>();
                SD.skillName.text = name;
                if (SD.skillDescription)
                    SD.skillDescription.text = Description;

                if (SD.skillIcon)
                    SD.skillIcon.sprite = Icon;

                if (SD.skillLevel)
                    SD.skillLevel.text = LevelNeeded.ToString();

                if (SD.skillXPNeeded)
                    SD.skillXPNeeded.text = XPNeeded.ToString() + "XP";

                if (SD.skillAttribute)
                    SD.skillAttribute.text = AffectedAttributes[0].attribute.ToString();

                if (SD.skillAttrAmount)
                    SD.skillAttrAmount.text = "+" + AffectedAttributes[0].amount.ToString();
            }
        }

        //check if the player is able to get the skill
        public bool CheckSkills(PlayerStats Player)
        {
            //check if player is the right level
            if (Player.PlayerLevel < LevelNeeded)
                return false;

            //check if player has enough xp
            if (Player.PlayerXP < XPNeeded)
                return false;

            //otherwise they can enable this skill
            return true;
        }

        //check if the player already has the skill
        public bool EnableSkill(PlayerStats Player)
        {
            //go through all the skills that the player currently has
            List<Skills>.Enumerator skills = Player.PlayerSkills.GetEnumerator();
            while (skills.MoveNext())
            {
                var CurrSkill = skills.Current;
                if (CurrSkill.name == this.name)
                {
                    return true;
                }
            }
            return false;
        }

        //get new skill
        public bool GetSkill(PlayerStats Player)
        {
            int i = 0;
            //List through the Skill's Attributes
            List<PlayerAttributes>.Enumerator attributes = AffectedAttributes.GetEnumerator();
            while (attributes.MoveNext())
            {
                //List through the Players Attributes and match with Skill attribute
                List<PlayerAttributes>.Enumerator PlayerAttr = Player.Attributes.GetEnumerator();
                while (PlayerAttr.MoveNext())
                {
                    if (attributes.Current.attribute.name.ToString() == PlayerAttr.Current.attribute.name.ToString())
                    {
                        //update the players attributes
                        PlayerAttr.Current.amount += attributes.Current.amount;
                        //mark that an attribute was updated
                        i++;
                    }
                }
                if (i > 0)
                {
                    //reduce the XP from  the player
                    Player.PlayerXP -= this.XPNeeded;
                    //add to the list of skills
                    Player.PlayerSkills.Add(this);
                    return true;
                }
            }
            return false;
        }
    }

}