using System.ComponentModel;
using Lab_12.Models;

namespace Lab_12.Extensions;

public static class OperatorExtensions
{
    public static string Description(this Operator value)
    {
        var attributes = (DescriptionAttribute[])typeof(Operator)
            .GetField(value.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false);

        return attributes[0].Description;
    }
}