using System;
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
            stanjaNaObradi.Add(pocetnoStanje);
            Hashtable visited = new Hashtable();
            while (stanjaNaObradi.Count > 0)
            {
                State naObradi = stanjaNaObradi[0];

                if (!visited.ContainsKey(naObradi.GetHashCode()))
                {
                    visited.Add(naObradi.GetHashCode(), naObradi.GetHashCode());
                    naObradi.isKutijaStanje();
                    Main.allSearchStates.Add(naObradi);
                    
                    if (naObradi.isKrajnjeStanje())
                    {
                        return naObradi;
                    }
    
                   
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
