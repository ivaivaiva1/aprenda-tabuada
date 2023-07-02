using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Final : MonoBehaviour
{ 
    public Text pontuacao;
    public Text recorde;
    public Text Titulo;
    public Text Frase;

    public GameObject TelaJogo;
    public GameObject TelaFinal;

    public void GameFinish()
    {
        pontuacao.text = "Pontuação: " + FindObjectOfType<Controler>().pontuacao.ToString();
        setRecorde();
        //Frase.text = "Você é incrível, parabéns".ToString();
        //Titulo.text = "Junior".ToString();
        print("titulo setado");
        setTitulo();
        TelaJogo.SetActive(false);
        TelaFinal.SetActive(true);
        setSaved();
    }
   
    public void setSaved()
    {
        PlayerPrefs.SetInt("maxPoints2Pref", Badges.maxPoints2);
        PlayerPrefs.SetInt("maxPoints3Pref", Badges.maxPoints3);
        PlayerPrefs.SetInt("maxPoints4Pref", Badges.maxPoints4);
        PlayerPrefs.SetInt("maxPoints5Pref", Badges.maxPoints5);
        PlayerPrefs.SetInt("maxPoints6Pref", Badges.maxPoints6);
        PlayerPrefs.SetInt("maxPoints7Pref", Badges.maxPoints7);
        PlayerPrefs.SetInt("maxPoints8Pref", Badges.maxPoints8);
        PlayerPrefs.SetInt("maxPoints9Pref", Badges.maxPoints9);
        PlayerPrefs.SetInt("maxPoints20Pref", Badges.maxPoints20);
    }

    public void Botoes(int scene)
    {
       if (scene == 0)
       {
           SceneManager.LoadScene (1);
       }
       if (scene == 1)
       {
           SceneManager.LoadScene (0);
       }
       
    }

    public void setTitulo()
    {
       if (FindObjectOfType<Controler>().pontuacao >= 100)
       {
           Frase.text = "ablublubé blublubluble".ToString();
           Titulo.text = "Taz Mania".ToString();
       } else
       if (FindObjectOfType<Controler>().pontuacao >= 60)
       {
           Frase.text = "Voce realmente Domina!".ToString();
           Titulo.text = "Chefinho".ToString();
       } else
       if (FindObjectOfType<Controler>().pontuacao >= 45)
       {
           Frase.text = "Você é incrível, parabéns".ToString();
           Titulo.text = "Rei".ToString();
       } else
       if (FindObjectOfType<Controler>().pontuacao >= 30)
       {
           Frase.text = "Voce vai se tornar um Rei!".ToString();
           Titulo.text = "Principe".ToString();
       } else
       if (FindObjectOfType<Controler>().pontuacao >= 25)
       {
           Frase.text = "Voce e muito inteligente, jogue novamente".ToString();
           Titulo.text = "Professor".ToString();
       } else
       if (FindObjectOfType<Controler>().pontuacao >= 20)
       {
           Frase.text = "Muito perto, voce esta aprendendo".ToString();
           Titulo.text = "Herói".ToString();
       } else
       if (FindObjectOfType<Controler>().pontuacao >= 15)
       {
           Frase.text = "Quase la, o proximo voce ganha!".ToString();
           Titulo.text = "Estudante".ToString();
       } else
       if (FindObjectOfType<Controler>().pontuacao >= 10)
       {
           Frase.text = "Tente de novo, voce vai conseguir!".ToString();
           Titulo.text = "Aluno".ToString();
       } else
       if (FindObjectOfType<Controler>().pontuacao >= 0)
       {
           Frase.text = "Continue Tentando!".ToString();
           Titulo.text = "Enzo".ToString();
       } 
    }

    public void setRecorde()
    {
        //+2
        if (Menu.maxNumber1 == 3)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints2)
            {
                Badges.maxPoints2 = FindObjectOfType<Controler>().pontuacao;
                print("recorde");
                recorde.text = "Recorde: " + Badges.maxPoints2.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints2.ToString();
        } else
        //+3
        if (Menu.maxNumber1 == 4)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints3)
            {
                Badges.maxPoints3 = FindObjectOfType<Controler>().pontuacao;
                recorde.text = "Recorde: " + Badges.maxPoints3.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints3.ToString();
        } else
        //+4
        if (Menu.maxNumber1 == 5)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints4)
            {
                Badges.maxPoints4 = FindObjectOfType<Controler>().pontuacao;
                recorde.text = "Recorde: " + Badges.maxPoints4.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints4.ToString();
        } else
        //+5
        if (Menu.maxNumber1 == 6)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints5)
            {
                Badges.maxPoints5 = FindObjectOfType<Controler>().pontuacao;
                recorde.text = "Recorde: " + Badges.maxPoints5.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints5.ToString();
        } else
        //+6
        if (Menu.maxNumber1 == 7)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints6)
            {
                Badges.maxPoints6 = FindObjectOfType<Controler>().pontuacao;
                recorde.text = "Recorde: " + Badges.maxPoints6.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints6.ToString();
        } else
        //+7
        if (Menu.maxNumber1 == 8)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints7)
            {
                Badges.maxPoints7 = FindObjectOfType<Controler>().pontuacao;
                recorde.text = "Recorde: " + Badges.maxPoints7.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints7.ToString();
        } else
        //+8
        if (Menu.maxNumber1 == 9)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints8)
            {
                Badges.maxPoints8 = FindObjectOfType<Controler>().pontuacao;
                recorde.text = "Recorde: " + Badges.maxPoints8.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints8.ToString();
        } else
        //+9
        if (Menu.maxNumber1 == 10)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints9)
            {
                Badges.maxPoints9 = FindObjectOfType<Controler>().pontuacao;
                recorde.text = "Recorde: " + Badges.maxPoints9.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints9.ToString();
        } else
        //+20
        if (Menu.maxNumber1 == 21)
        {
            if (FindObjectOfType<Controler>().pontuacao > Badges.maxPoints20)
            {
                Badges.maxPoints20 = FindObjectOfType<Controler>().pontuacao;
                recorde.text = "Recorde: " + Badges.maxPoints20.ToString();
            } else
            recorde.text = "Recorde: " + Badges.maxPoints20.ToString();
        }
    }
 
}
