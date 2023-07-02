using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Controler : MonoBehaviour
{
    
    public bool isDead = false;

    public int Aplauso = 0;

    public AudioControllerGame AudioControl;

    public int pontuacao = 0;

    public float health = 0f;
    public float startingTime = 3f;
    public float healthMax = 3f;

    public Image healthBar;

    public Text pergunta;
    public List<Text> alternativas;
    public List<Button> botoes;

    public int firstNumber = 0;
    public int secondNumber = 0;

    public int whereisCorrect = 0;

    public int respostaCorreta = 0;

    void Start()
    {
        health = startingTime;
        newQuestion();
    }

    
    void FixedUpdate()
    {    
        UpdateHealthBar();
        playerDeath();
    }

    public void newQuestion()
    { 
      AudioControl.PlayQuestion();
      buttonsTrue();
      AlternativasEnabled();
      firstNumber = Random.Range(2, Menu.maxNumber1);
      secondNumber = Random.Range(2, Menu.maxNumber2);
      pergunta.text = firstNumber + " x " + secondNumber.ToString();
      respostaCorreta = firstNumber * secondNumber;
      whereisCorrect = Random.Range(0, 4);
      var algoritimosUsados = new List<int>();
      
      for(var i = 0; i<alternativas.Count; i++){
        if(i== whereisCorrect){
          alternativas[i].text = (firstNumber * secondNumber).ToString();
        } else {
          var algoritmo = Random.Range(1, 9);
          var sucesso = false;

          while(!sucesso)
          {
            if(algoritimosUsados.Contains(algoritmo))
            {
              algoritmo = Random.Range(1, 9);
              sucesso = false;
            } else 
            {
              sucesso = true;
             algoritimosUsados.Add(algoritmo);
            }     
          }

          switch(algoritmo)
          {
            case 1:
            alternativas[i].text = (firstNumber * (secondNumber + 1)).ToString();
            break;
            case 2:
            alternativas[i].text = (firstNumber * (secondNumber + 2)).ToString();
            break;
            case 3:
            alternativas[i].text = (firstNumber * (secondNumber - 1)).ToString();
            break;
            case 4:
            alternativas[i].text = (firstNumber * (secondNumber - 2)).ToString();
            break;
            case 5:
            alternativas[i].text = (secondNumber * (firstNumber + 1)).ToString();
            break;
            case 6:
            alternativas[i].text = (secondNumber * (firstNumber + 2)).ToString();
            break;
            case 7:
            alternativas[i].text = (secondNumber * (firstNumber - 1)).ToString();
            break;
            case 8:
            alternativas[i].text = (secondNumber * (firstNumber - 2)).ToString();
            break;
          }    
        }
      }
    }
    
    public void AlternativasEnabled()
    {
      botoes[0].animator.SetInteger("btn1Anim", 0);
      botoes[1].animator.SetInteger("btn1Anim", 0);
      botoes[2].animator.SetInteger("btn1Anim", 0);
      botoes[3].animator.SetInteger("btn1Anim", 0);
      alternativas[0].enabled = true;
      alternativas[1].enabled = true;
      alternativas[2].enabled = true;
      alternativas[3].enabled = true;
    } 
    public void AlternativasDisabled()
    {
       alternativas[0].enabled = false;
       alternativas[1].enabled = false;
       alternativas[2].enabled = false;
       alternativas[3].enabled = false;
    }
    public void buttonsFalse()
    {
       botoes[0].animator.SetInteger("btn1Anim", -1);
       botoes[1].animator.SetInteger("btn1Anim", -1);
       botoes[2].animator.SetInteger("btn1Anim", -1);
       botoes[3].animator.SetInteger("btn1Anim", -1);
       botoes[0].interactable = false;
       botoes[1].interactable = false;
       botoes[2].interactable = false;
       botoes[3].interactable = false;
    }
    public void buttonsTrue()
    {
       //botoes[0].animator.SetInteger("btn1Anim", 1);
       botoes[0].interactable = true;
       botoes[1].interactable = true;
       botoes[2].interactable = true;
       botoes[3].interactable = true;
    }

    public void OnAlternativaClick(int alternativaIndex)
    {
       buttonsFalse();
       AlternativasDisabled();
       alternativas[whereisCorrect].enabled = true;
       botoes[whereisCorrect].animator.SetInteger("btn1Anim", 1);
       if(alternativaIndex == whereisCorrect)
       {
          acertou();
          return;
       } else
       erou();
    }

    public void acertou()
    {
       AudioControl.PlayCorrect();
       ChangeSpeed();
       pontuacao = pontuacao + 1;
       Debug.Log("Certa reposta");
       if(healthMax > 8)
       {
        health = health + (healthMax/1.6f);
       } else
       {
        health = healthMax;
       }
       StartCoroutine("waitnewQuestion");
    }
    
    public void erou()
    {
       AudioControl.PlayWrong();
       Debug.Log("erou");
       StartCoroutine("waitnewQuestion");
    }

    IEnumerator waitnewQuestion()
    {
        yield return new WaitForSeconds(1f);
        newQuestion();
    }

    public void UpdateHealthBar()
    {
        health -=1 * Time.deltaTime;
        if(health > healthMax)
        {
           health = healthMax;
        }
        if(health < 0f)
        {
           health = 0f;
        }
        healthBar.fillAmount = health/healthMax;
    }

    public void playerDeath()
    {
       if(health == 0 & isDead == false)
       {
          isDead = true;
          FindObjectOfType<Final>().GameFinish();
          if (pontuacao >= 45)
          {
              AudioControl.PlayWon();
          } else
          AudioControl.PlayLose();
       }
    }

   public void ChangeSpeed()
   {
        //diminuindo a velocidade
        if(pontuacao == 10)
        {
           healthMax = 18f;
        }
        if(pontuacao == 15)
        {
           healthMax = 16f;
        }
        if(pontuacao == 20 && Aplauso == 0)
        {
           Aplauso = 10;
           AudioControl.PLayAplauso();
           healthMax = 14f;
        }
        if(pontuacao == 25)
        {
           healthMax = 10f;
        }
        if(pontuacao == 30)
        {
           healthMax = 6f;
        }
        if(pontuacao == 45 && Aplauso == 10)
        {
           Aplauso = 20;
           AudioControl.PLayAplauso();
           healthMax = 3f;
        }
        if(pontuacao == 80 && Aplauso == 20)
        {
           Aplauso = 30;
           AudioControl.PLayAplauso();
        }
   }

}
