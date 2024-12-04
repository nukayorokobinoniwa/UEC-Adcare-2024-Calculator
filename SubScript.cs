using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubScript : MonoBehaviour
{
    [SerializeField] private CalDirector director;
    void Start(){
        director.FalseSubtraction();
    }

    // Update is called once per frame
    public void Interact(){
        if(!director.ReturnIsFirstCal()&& !director.ReturnIsPushedOperator()&& !director.ReturnIsPushedEqual()){
            director.calculation();
        }
        director.FalseIsPushedEqual();
        director.TrueSubtraction();
        director.FalseAdd();
        director.FalseMultiplicity();
        director.FalseDivision();
        director.TrueIsPushedOperator();
    }
}
