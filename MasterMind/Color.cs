using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Color
    {
        public ColorName Couleur { get; set; }
        public Color(Random rand)
        {            
            Array TabEnumColor = Enum.GetValues(typeof(ColorName));
            ColorName ColorSelected = (ColorName)TabEnumColor.GetValue(rand.Next(TabEnumColor.Length));
            this.Couleur = ColorSelected;
        }
    }
    public enum ColorName
    {
        Vert,
        Bleu,
        Rouge,
        Violet,
        Jaune,
        Blanc
    }
}
