using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    string FirstName = "Irakli";
    string LastName = "Patsia";
    int MyAge = 18;
    string MyHobby = "playing video games";



    void Update()
    {

        float vertical = Input.GetAxisRaw("Vertical");

        if (vertical == 1)
        {
            string fullbio = GetFullBio(FirstName, LastName, MyAge, MyHobby);
            Debug.Log(fullbio);

        }


        float horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal == 1)
        {
            string fullname = GetFullName(FirstName, LastName);
            Debug.Log(fullname);


        }


    }

    string GetFullBio(string firstname, string lastname, int myage, string myhobby)
    {
        string fullbio = firstname + " " + lastname + " " + myage + " " + myhobby;
        return fullbio;

    }

    string GetFullName(string firstname, string lastname) 
    {
        string fullname = firstname + " " + lastname;
        return fullname;



    }






}
