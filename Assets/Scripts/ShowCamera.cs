using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCamera : MonoBehaviour
{

    [SerializeField] private Vector3 supermanPosition;
  //  [SerializeField] private Quaternion supermanPosition;
    [SerializeField] private Vector3 billiardPosition;
    [SerializeField] private Vector3 blastingPosition;

    [SerializeField] private Button backButton;
    [SerializeField] private Button nextButton;

    [SerializeField] private Button supermanButton;
    [SerializeField] private Button billiardButton;
    [SerializeField] private Button blastingButton;

    private int numberPosition = 1;
    private bool backButtonClick = false;
    private bool nextButtonClick = false;


    private void Update()
    {
        TrueFalseButtons();
    }

    public void ClickBackButton()
    {
        backButtonClick = true;
        numberPosition--;
    }

    public void ClickNextButton()
    {
        nextButtonClick = true;
        numberPosition++;
    }

    private void TrueFalseButtons()
    {
        if (numberPosition == 1)
        {
            transform.position = supermanPosition;

            nextButton.interactable = true;
            backButton.interactable = false;

            supermanButton.interactable = true;
            billiardButton.interactable = false;
            blastingButton.interactable = false;

        } else if (numberPosition == 2)
        {
            transform.position = billiardPosition;

            nextButton.interactable = true;
            backButton.interactable = true;

            supermanButton.interactable = false;
            billiardButton.interactable = true;
            blastingButton.interactable = false;

        } else if (numberPosition == 3) 
        {
            transform.position = blastingPosition;
           // transform.rotation = blastingPosition;

            nextButton.interactable = false;
            backButton.interactable = true;

            supermanButton.interactable = false;
            billiardButton.interactable = false;
            blastingButton.interactable = true;
        }
    }

}
