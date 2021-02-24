using System;
using System.Collections.Generic;
using System.Text;

//17.Implement at least one extension method
namespace CTIS479_Homework_1
{
    public static class ExtensionMethods
    {
        public static bool UseBus(this double value)
        {
            if (300 > value)
                return false;
            else
                return true;
        }
    }
}