﻿using System;

namespace TP2
{
    public class Carre : Rectangle
    {
        public override int Largeur => Longueur;

        public override string ToString()
        {
            //return "Carré de coté = " + Longueur + Environment.NewLine + base.ToString(true);
            return $"Carré de coté={Longueur}" + Environment.NewLine + base.ToString(true);
        }
    }
}