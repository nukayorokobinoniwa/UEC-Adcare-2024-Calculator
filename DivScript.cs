using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivScript : MonoBehaviour
{
    [SerializeField] private CalDirector director;
    void Start(){
        director.FalseDivision();
    }

    // Update is called once per frame
    public void Interact(){
        if(!director.ReturnIsFirstCal()&& !director.ReturnIsPushedOperator()&& !director.ReturnIsPushedEqual()){
            director.calculation();
        }
        director.FalseIsPushedEqual();
        director.TrueDivision();
        director.FalseAdd();
        director.FalseSubtraction();
        director.FalseMultiplicity();
        director.TrueIsPushedOperator();
    }
}
