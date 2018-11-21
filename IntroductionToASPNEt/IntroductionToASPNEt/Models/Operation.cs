using IntroductionToASPNEt.Resources;
using System.ComponentModel.DataAnnotations;

namespace IntroductionToASPNEt.Models
{
    public enum Operation
    {
        [Display(Name = "Add", ResourceType = typeof(CalcResources))]
        Add,

        [Display(Name = "Divide", ResourceType = typeof(CalcResources))]
        Divide,

        [Display(Name = "Logarithm", ResourceType = typeof(CalcResources))]
        Logarithm,

        [Display(Name = "Multiplication", ResourceType = typeof(CalcResources))]
        Multiplication,

        [Display(Name = "Subtraction", ResourceType = typeof(CalcResources))]
        Subtraction,

        [Display(Name = "Power", ResourceType = typeof(CalcResources))]
        Power
    }    
}