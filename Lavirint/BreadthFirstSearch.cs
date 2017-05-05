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
            while (stanjaNaObradi.Count > 0)
            {
                State naObradi = stanjaNaObradi[0];

                if (!naObradi.predjeniPut.ContainsKey(naObradi.GetHashCode()))
                {
                    naObradi.predjeniPut.Add(naObradi.GetHashCode(), naObradi.GetHashCode());
                    Main.allSearchStates.Add(naObradi);
                    
                    if (naObradi.isKrajnjeStanje())
                    {
                        return naObradi;
                    }
                    naObradi.isKutijaStanje();
                    if (naObradi.predjeniPut.Count > 5)
                    {
                        stanjaNaObradi.Remove(naObradi);
                        continue;
                    }
                    List<State> mogucaSledecaStanja = naObradi.mogucaSledecaStanja();
                    foreach (State sledeceStanje in mogucaSledecaStanja)
                    {
                        if(!naObradi.predjeniPut.ContainsKey(sledeceStanje.GetHashCode()))
                            stanjaNaObradi.Add(sledeceStanje);
                    }
                }
                stanjaNaObradi.Remove(naObradi);
            }
            return null;
        }
    }
}
