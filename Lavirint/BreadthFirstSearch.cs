﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Lavirint
{
    class BreadthFirstSearch
    {
        public State search(State pocetnoStanje)
        {
            List<State> stanjaNaObradi = new List<State>();
            Hashtable predjeniPut = new Hashtable();
            stanjaNaObradi.Add(pocetnoStanje);
            while (stanjaNaObradi.Count > 0)
            {
                State naObradi = stanjaNaObradi[0];

                if (!predjeniPut.ContainsKey(naObradi.GetHashCode()))
                {
                    predjeniPut.Add(naObradi.GetHashCode(), null);
                    Main.allSearchStates.Add(naObradi);
                    
                    if (naObradi.isKrajnjeStanje())
                    {
                        return naObradi;
                    }
                    //linija 20 proveri ovaj uslov a ovde puca ...
                    naObradi.isKutijaStanje();           
                   
                    List<State> mogucaSledecaStanja = naObradi.mogucaSledecaStanja();
                    foreach (State sledeceStanje in mogucaSledecaStanja)
                    {
                        stanjaNaObradi.Add(sledeceStanje);
                    }
                }
                stanjaNaObradi.Remove(naObradi);
            }
            return null;
        }
    }
}
