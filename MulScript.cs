using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulScript : MonoBehaviour
{
    [SerializeField] private CalDirector director;
    void Start(){
        director.FalseMultiplicity();
    }

    // Update is called once per frame
    public void Interact(){
        if(!director.ReturnIsFirstCal()&& !director.ReturnIsPushedOperator()&& !director.ReturnIsPushedEqual()){
            director.calculation();
        }
        director.FalseIsPushedEqual();
        director.TrueMultiplicity();
        director.FalseAdd();
        director.FalseSubtraction();
        director.FalseDivision();
        director.TrueIsPushedOperator();
    }
}
