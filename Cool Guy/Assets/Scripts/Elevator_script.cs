using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Elevator_script : MonoBehaviour
{
    GameObject Button;
    GameObject Elevator;
    Animator buttonAnimator;
    Animator elevatorAnimator;
    public Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        buttonText.enabled = false;
        Button = GameObject.Find("Button");
        Elevator = GameObject.Find("Elevator");
        buttonAnimator = Button.GetComponent<Animator>();
        elevatorAnimator = Elevator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay()
    {
        buttonText.enabled = true;
        if (Input.GetKey("E"))
        {
            buttonAnimator.SetTrigger("butttonPressed");
            elevatorAnimator.SetTrigger("buttonUpPressed");
        }
    }
}