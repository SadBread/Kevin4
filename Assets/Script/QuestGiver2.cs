using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver2 : MonoBehaviour
{
    [SerializeField] private GameObject textPopUpImage;
    [SerializeField] private GameObject textPopUp1;
    [SerializeField] private GameObject textPopUp2;
    [SerializeField] private GameObject textPopUp3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            textPopUpImage.SetActive(true);

            if (Info.mushroomsCollected < 20)
            {
                // Under 20
                textPopUp1.SetActive(true);
            }
            else if (Info.mushroomsCollected < 45)
            {
                // Över 20 men under 45
                textPopUp2.SetActive(true);
            }
            else if (Info.mushroomsCollected >= 45)
            {
                // Alla
                textPopUp3.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            textPopUpImage.SetActive(false);
            textPopUp1.SetActive(false);
            textPopUp2.SetActive(false);
            textPopUp3.SetActive(false);
        }
    }
}
