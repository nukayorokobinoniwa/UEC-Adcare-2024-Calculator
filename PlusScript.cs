using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusScript : MonoBehaviour
{
    [SerializeField] private CalDirector director;
    void Start(){
        director.FalseAdd();
    }

    // Update is called once per frame
    public void Interact(){
        //条件として最初の計算(初期値0の状態)ではない　かつ　演算子が複数回押された状態ではないかつ=が押されていないなら計算を行う
        if(!director.ReturnIsFirstCal()&& !director.ReturnIsPushedOperator()&& !director.ReturnIsPushedEqual()){
            director.calculation();
        }
        director.FalseIsPushedEqual();
        director.TrueAdd();
        director.FalseSubtraction();
        director.FalseMultiplicity();
        director.FalseDivision();
        director.TrueIsPushedOperator();
    }
}
