using System.ComponentModel;

namespace Lab_12.Models;

public class RequestModel
{
    public float FirstNumber { get; init; }
    public float SecondNumber { get; init; }
    public Operator Operator { get; init; }

    public float Result => Operator switch
    {
        Operator.Plus => FirstNumber + SecondNumber,
        Operator.Minus => FirstNumber - SecondNumber,
        Operator.Multiply => FirstNumber * SecondNumber,
        Operator.Divide => FirstNumber / SecondNumber
    };
}

public enum Operator
{
    [Description("+")]
    Plus,
    [Description("-")]
    Minus,
    [Description("*")]
    Multiply,
    [Description("/")]
    Divide
}