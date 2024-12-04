using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equal : MonoBehaviour

{
    [SerializeField] CalDirector director;

    public void Interact(){
        if(!director.ReturnIsPushedEqual()){
            director.TrueIsPushedEqual();
            director.calculation();
        }
    }
}
