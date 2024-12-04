using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalDirector : MonoBehaviour
{
    private float cal_result;
    private float tmp;
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] PlusScript add;
    [SerializeField] SubScript subtract;
    [SerializeField] MulScript multiply;
    [SerializeField] DivScript divide;
    [SerializeField] Equal equal;
    private bool isPushedOperator;//演算子が押された状態かどうかを記録するためのbool;
    private bool isPushedEqual;//等号が押された状態かどうかを記録するためのbool;
    private bool isAdd;//足し算がonかどうか
    private bool isSubtraction;//引き算がonかどうか
    private bool isMultiplicity;//掛け算がonかどうか
    private bool isDivision;//割り算がonかどうか
    private bool isFirstCal;//最初の入力かどうか

    void Start(){
        resultText.text = "0";
        cal_result = 0;//現在の計算結果を保持する。
        tmp = 0;
        isPushedOperator = false;
        isPushedEqual = false;
        isFirstCal = true;
        FalseAdd();
        FalseSubtraction();
        FalseMultiplicity();
        FalseDivision();
    }

    // Update is called once per frame
    void Update(){
        if(isPushedOperator){
            if(isAdd){
                //Debug.Log("足し算on");
                set_cal_result_text("+");
            }else if(isSubtraction){
                //Debug.Log("引き算on");
                set_cal_result_text("-");
            }else if(isMultiplicity){
                //Debug.Log("掛け算on");
                set_cal_result_text("×");
            }else if(isDivision){
                //Debug.Log("割り算on");
                set_cal_result_text("÷");
            }
        }
    }

    public bool ReturnIsFirstCal(){
        return isFirstCal;
    }

    public void TrueIsFirstCal(){
        isFirstCal = true;
    }

    public void FalseIsFirstCal(){
        isFirstCal = false;
    }

    public bool ReturnIsPushedEqual(){
        return isPushedEqual;
    }
    public void TrueIsPushedEqual(){
        isPushedEqual = true;
    }
    public void FalseIsPushedEqual(){
        isPushedEqual = false;
    }

    public bool ReturnIsPushedOperator(){
        return isPushedOperator;
    }
    public void TrueIsPushedOperator(){
        isPushedOperator = true;
    }

    public void FalseIsPushedOperator(){
        isPushedOperator = false;
    }

    public void TrueAdd(){
        isAdd = true;
    }

    public void FalseAdd(){
        isAdd = false;
    }

    public void TrueSubtraction(){
        isSubtraction = true;
    }

    public void FalseSubtraction(){
        isSubtraction = false;
    }

    public void FalseMultiplicity(){
        isMultiplicity = false;
    }

    public void TrueMultiplicity(){
        isMultiplicity = true;
    }

    public void TrueDivision(){
        isDivision = true;
    }

    public void FalseDivision(){
        isDivision = false;
    }

    public void SaveTMP(){
        tmp = cal_result;
    }

    public void set_cal_result(){
        resultText.text = cal_result.ToString();
    }

    public void set_cal_result_text(string text){
        resultText.text = cal_result.ToString() + text;
    }

    public float get_cal_result(){
        return cal_result;
    }

    public void reset_cal_result(){
        cal_result = 0;
    }
    
    public void add_cal_result(float num){
        tmp += num;
        cal_result = tmp;
        set_cal_result();
    }
    
    public void subtract_cal_result(float num){
        tmp -= num;
        cal_result = tmp;
        set_cal_result();
    }
    
    public void multiply_cal_result(float num){
        tmp *= num;
        cal_result = tmp;
        set_cal_result();
    }
    
    public void divide_cal_result(float num){
        if(num!= 0){
            tmp /= num;
            cal_result = tmp;
            set_cal_result();
        }else{
            reset_result();
            resultText.text= "ERROR";
        }
    }

    public void calculation(){
        Debug.Log("tmp" + tmp);
        if(isAdd){
            Debug.Log("足し算チェック");
            add_cal_result(cal_result);
        }else if(isSubtraction){
            Debug.Log("引き算チェック");
            subtract_cal_result(cal_result);
        }else if(isMultiplicity){
            Debug.Log("掛け算チェック");
            multiply_cal_result(cal_result);
        }else if(isDivision){
            Debug.Log("割り算チェック");
            divide_cal_result(cal_result);
        }
    }
    
    public void reset_result(){
        Debug.Log("Resetしてるよ~~~");
        resultText.text = "0";
        cal_result = 0;//現在の計算結果を保持する。
        tmp = 0;
        isPushedOperator = false;
        isPushedEqual = false;
        isFirstCal = true;
        FalseAdd();
        FalseSubtraction();
        FalseMultiplicity();
        FalseDivision();
    }

    public void addNum(float num){
        cal_result = cal_result * 10 + num;
    }
}
