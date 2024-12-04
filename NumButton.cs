using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumButton : MonoBehaviour
{
    [SerializeField] float num;
    [SerializeField] CalDirector director;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact(){
    if(director.ReturnIsPushedOperator()){
        Debug.Log("演算子on");
        if(director.ReturnIsFirstCal()){
            director.FalseIsFirstCal();
        }
        director.SaveTMP();
        director.FalseIsPushedOperator();
        director.reset_cal_result();
    }
    if(director.ReturnIsPushedEqual()){
        Debug.Log("Equal");
        director.reset_result();
        director.FalseIsPushedEqual();
    }
        director.addNum(num);
        director.set_cal_result();
        Debug.Log("Clicked on " + num+"cal_result="+director.get_cal_result());
    }
}
