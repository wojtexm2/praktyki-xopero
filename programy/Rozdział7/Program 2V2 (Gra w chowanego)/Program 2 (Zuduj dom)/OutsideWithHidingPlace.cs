using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2__Zuduj_dom_
{
    internal class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            hidingPlaceName = hidingPlaceName;
        }
        public string HidingPlaceName { get; private set; }
        public override string Description
        {
            get { return base.Description + " Ktoś może ukrywać się " + HidingPlaceName + "."; }
        }
    }
}
