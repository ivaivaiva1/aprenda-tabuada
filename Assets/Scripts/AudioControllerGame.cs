using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerGame : MonoBehaviour
{
  
  public AudioSource Question, Wrong, Correct, Won, Lose, Aplauso;

  public void PlayQuestion()
  {
    Question.Play(); 
  }

  public void PlayWrong()
  {
    Wrong.Play(); 
  }

  public void PlayCorrect()
  {
    Correct.Play(); 
  }

  public void PlayWon()
  {
    Won.Play(); 
  }

  public void PlayLose()
  {
    Lose.Play(); 
  }

  public void PLayAplauso()
  {
    Aplauso.Play(); 
  }


}
