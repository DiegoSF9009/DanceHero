using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;




public class Timer : MonoBehaviour
{  
    [SerializeField]

    private Text timerText;
    [SerializeField]

    private UnityEvent onTimeEnded;
    [SerializeField]

    private UnityEvent OnSecondPassed;

    private float seconds;

    private void StartTimer(float duration) 
    {

        seconds = duration;
        StartCoroutine(RunTimer());

    } 


    private IEnumerator RunTimer()

    {
        timerText.text = seconds.ToString();
        yield return new WaitForSeconds(1);
        seconds--;
        if (seconds <= 0) 
        {

            onTimeEnded.Invoke();

        }
        else 
        {

            OnSecondPassed.Invoke();
            StartCoroutine(RunTimer());
            
        }



    }



}
