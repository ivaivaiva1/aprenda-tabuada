using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public GameObject telaInicial;
    public GameObject telaChoose;
    public GameObject telaCreditos;
    public GameObject telaTabuda;
    public GameObject Lettering;
    public GameObject textinhoFofo;

    public static int maxNumber1;
    public static int maxNumber2 = 11;

    public void BotãoJogar()
    {
       telaTabuda.SetActive(false);
       telaCreditos.SetActive(false);
       telaInicial.SetActive(false);
       telaChoose.SetActive(true);
       textinhoFofo.SetActive(true);
       Lettering.SetActive(true);
    }

    public void Voltar()
    {
       telaInicial.SetActive(true);
       telaChoose.SetActive(false);
       telaCreditos.SetActive(false);
       telaTabuda.SetActive(false);
       textinhoFofo.SetActive(true);
       Lettering.SetActive(true);
    }

    public void BotãoCréditos()
    {
       telaInicial.SetActive(false);
       telaCreditos.SetActive(true);
       textinhoFofo.SetActive(false);
       Lettering.SetActive(false);
    }

    public void BotãoTabuada()
    {
       textinhoFofo.SetActive(false);
       Lettering.SetActive(false);
       telaChoose.SetActive(false);
       telaInicial.SetActive(false);
       telaTabuda.SetActive(true);
    }


    //só mudar maxNumber2, o 1 só no +20
    public void onGameModeClick(int whichMode)
    {
        if(whichMode == 3)
        {
          maxNumber1 = 3;
          maxNumber2 = 11;
          SceneManager.LoadScene (1);
        } else 
        if(whichMode == 4)
        {
          maxNumber1 = 4;
          maxNumber2 = 11;
          SceneManager.LoadScene (1);
        } else 
        if(whichMode == 5)
        {
          maxNumber1 = 5;
          maxNumber2 = 11;
          SceneManager.LoadScene (1);
        } else 
        if(whichMode == 6)
        {
          maxNumber1 = 6;
          maxNumber2 = 11;
          SceneManager.LoadScene (1);
        } else 
        if(whichMode == 7)
        {
          maxNumber1 = 7;
          maxNumber2 = 11;
          SceneManager.LoadScene (1);
        } else 
        if(whichMode == 8)
        {
          maxNumber1 = 8;
          maxNumber2 = 11;
          SceneManager.LoadScene (1);
        } else 
        if(whichMode == 9)
        {
          maxNumber1 = 9;
          maxNumber2 = 11;
          SceneManager.LoadScene (1);
        } else 
        if(whichMode == 10)
        {
          maxNumber1 = 10;
          maxNumber2 = 11;
          SceneManager.LoadScene (1);
        } else 
        if(whichMode == 21)
        {
          maxNumber1 = 21;
          maxNumber2 = 21;
          SceneManager.LoadScene (1);
        }
    }

}
