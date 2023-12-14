using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    private enum Operations
    {
        Sum,
        Substraction,
        Multiplication,
        Division
    }

    [Header("Enter numbers and select the type of calculation")]
    [SerializeField] private float _number1 = 10f;
    [SerializeField] private float _number2 = 2f;
    [SerializeField] private Operations _TypeOfCalculation;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Operation result = {Calculate(_number1, _number2)}");
    }
    
        private float Calculate(float number1, float number2)
    {
        if (_TypeOfCalculation == Operations.Sum)
        {
            return Sum(number1, number2);
        }
        else if (_TypeOfCalculation == Operations.Substraction)
        {
            return Substraction(number1, number2);
        }
        else if (_TypeOfCalculation == Operations.Multiplication)
        {
            return Multiplication(number1, number2);
        }
        else
        {
            return Division(number1, number2);
        }
    }

    private float Sum(float number1, float number2)
    {
        return number1 + number2;
    }

    private float Substraction(float number1, float number2)
    {
        return number1 - number2;
    }

    private float Multiplication(float number1, float number2)
    {
        return number1 * number2;
    }

    private float Division(float number1, float number2)
    {
        return number1 / number2;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
