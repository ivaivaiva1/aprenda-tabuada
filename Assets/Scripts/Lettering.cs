using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;

public class Lettering : MonoBehaviour
{

    public TMP_Text lettering;

    public List<string> textinhoFofo;

    public float letSize;
    public bool letIncrease;

    public float minFont;
    public float maxFont;

    public float speedBoing;

   
      void OnEnable()  
     {
        ChangeText();
        letSize = (maxFont + minFont) / 2;
     }

     void Start()
    {
        ChangeText();
        letSize = (maxFont + minFont) / 2;
    }

    void ChangeText()
    {
        var wichText = Random.Range(0,29);
        lettering.text = textinhoFofo[wichText].ToString();
        StartCoroutine("recall");
    }

     IEnumerator recall()
    {
        yield return new WaitForSeconds(10f);
        ChangeText();
    }


    void FixedUpdate()
    {
        //LetteringTimer();
        lettering.fontSize = letSize;
        if (letIncrease == true)
        {
            letSize = letSize + speedBoing;
        } else
        if (letIncrease == false)
        {
            letSize = letSize - speedBoing;
        }
        if (letSize <= minFont)
        {
            letIncrease = true;
        } 
        if (letSize >= maxFont)
        {
            letIncrease = false;
        }
    }

}
