using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Badges : MonoBehaviour
{
    
    //0 = +2 / 1 = +3/ 2 = +4/ 3 = +5/ 4 = +6/ 5 = +7/ 6 = +8/ 7 = +9/ 8 = +20

    public List<Image> badgesP;
    public List<Image> badgesG;

    public static int maxPoints2, maxPoints3, maxPoints4, maxPoints5, maxPoints6, maxPoints7, maxPoints8, maxPoints9, maxPoints20;

    void Start()
    {
       GetSaved();
       //ZeroPoints();
       GoldBadges();
       PrataBadges();
    }

    public void PrataBadges()
    {
       if (maxPoints2 > 45)
       {
           badgesP[0].gameObject.SetActive(true);
       } 
       if (maxPoints3 > 45)
       {
           badgesP[1].gameObject.SetActive(true);
       } 
       if (maxPoints4 > 45)
       {
           badgesP[2].gameObject.SetActive(true);
       } 
       if (maxPoints5 > 45)
       {
           badgesP[3].gameObject.SetActive(true);
       } 
       if (maxPoints6 > 45)
       {
           badgesP[4].gameObject.SetActive(true);
       } 
       if (maxPoints7 > 45)
       {
           badgesP[5].gameObject.SetActive(true);
       } 
       if (maxPoints8 > 45)
       {
           badgesP[6].gameObject.SetActive(true);
       } 
       if (maxPoints9 > 45)
       {
           badgesP[7].gameObject.SetActive(true);
       } 
       if (maxPoints20 > 45)
       {
           badgesP[8].gameObject.SetActive(true);
       } 
    }

    public void GoldBadges()
    {
       if (maxPoints2 > 60)
       {
           badgesG[0].gameObject.SetActive(true);
       } 
       if (maxPoints3 > 60)
       {
           badgesG[1].gameObject.SetActive(true);
       } 
       if (maxPoints4 > 60)
       {
           badgesG[2].gameObject.SetActive(true);
       } 
       if (maxPoints5 > 60)
       {
           badgesG[3].gameObject.SetActive(true);
       } 
       if (maxPoints6 > 60)
       {
           badgesG[4].gameObject.SetActive(true);
       } 
       if (maxPoints7 > 60)
       {
           badgesG[5].gameObject.SetActive(true);
       } 
       if (maxPoints8 > 60)
       {
           badgesG[6].gameObject.SetActive(true);
       } 
       if (maxPoints9 > 60)
       {
           badgesG[7].gameObject.SetActive(true);
       } 
       if (maxPoints20 > 60)
       {
           badgesG[8].gameObject.SetActive(true);
       } 
    }
    
    public void GetSaved()
    {
        maxPoints2 = PlayerPrefs.GetInt("maxPoints2Pref");
        maxPoints3 = PlayerPrefs.GetInt("maxPoints3Pref");
        maxPoints4 = PlayerPrefs.GetInt("maxPoints4Pref");
        maxPoints5 = PlayerPrefs.GetInt("maxPoints5Pref");
        maxPoints6 = PlayerPrefs.GetInt("maxPoints6Pref");
        maxPoints7 = PlayerPrefs.GetInt("maxPoints7Pref");
        maxPoints8 = PlayerPrefs.GetInt("maxPoints8Pref");
        maxPoints9 = PlayerPrefs.GetInt("maxPoints9Pref");
        maxPoints20 = PlayerPrefs.GetInt("maxPoints20Pref");
    }

    public void ZeroPoints()
    {
        PlayerPrefs.SetInt("maxPoints2Pref", 0);
        PlayerPrefs.SetInt("maxPoints3Pref", 0);
        PlayerPrefs.SetInt("maxPoints4Pref", 0);
        PlayerPrefs.SetInt("maxPoints5Pref", 0);
        PlayerPrefs.SetInt("maxPoints6Pref", 0);
        PlayerPrefs.SetInt("maxPoints7Pref", 0);
        PlayerPrefs.SetInt("maxPoints8Pref", 0);
        PlayerPrefs.SetInt("maxPoints9Pref", 0);
        PlayerPrefs.SetInt("maxPoints20Pref", 0);
    }

}
