using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalManager : MonoBehaviour
{
    public GameObject Contact;
    bool isContact = false;
    public GameObject Language;
    bool isLanguage = false;
    public GameObject Rate;
    bool isRate = false;
    // Start is called before the first frame update
    public void ContactUs()
    {
        isContact = !isContact;
        Contact.SetActive(isContact);
    }
    public void LanguageChange()
    {
        isLanguage = !isLanguage;
        Language.SetActive(isLanguage);
    }
    public void RateUs()
    {
        isRate = !isRate;
        Rate.SetActive(isRate);
    }

}
