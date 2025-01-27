using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string FirstName = "Irakli";
        string LastName = "Patsia";
        int MyAge = 18;
        string MyHobby = "playing video games";
        string GetFullName = (FirstName + " " +  LastName);
        string GetFullBio = ("My name is" + " " + FirstName + "I am" + " " + MyAge + " " + "years old" + " " + "I love" + " " + MyHobby);


        float Horizontal = Input.GetAxisRaw("horizontal");

        float Vertical = Input.GetAxisRaw("vertical");


    }
}
