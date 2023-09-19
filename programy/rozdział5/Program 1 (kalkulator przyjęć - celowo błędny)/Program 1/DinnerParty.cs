using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class DinnerParty
    {
        public int NumberOfPeople;
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;

        public void SetHealthyOption(bool value)
        {
            if (value)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }
        public void CalculateCostOfDecorations(bool fantazyjne)
        {
            if (fantazyjne) {
                CostOfDecorations = (15.00M * NumberOfPeople) + 50M;
            }
            else
            {
                CostOfDecorations = (7.50M * NumberOfPeople) + 30M;
            }
        }
        public decimal CalculateCost(bool healthy)
        {
            decimal cost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (healthy)
            {
                return cost * .95M;
            }
            else
            {
                return cost;
            }
        }
    }
}
