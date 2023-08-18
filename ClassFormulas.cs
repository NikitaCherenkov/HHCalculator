using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHCalculator
{
    internal class ClassFormulas
    {
        public static double CraftSmith(double QualityAnvil, double QualityHammer, double QualityIngridients)
        {
            return (QualityAnvil * 4 + QualityHammer * 3 + QualityIngridients * 9) / 16;
        }
        public static double BoiledInCauldron(double QualityCauldron, double QualityWater, double QualityIngridients)
        {
            return (QualityIngridients * 2 + QualityCauldron + QualityWater) / 4;
        }
    }
}
