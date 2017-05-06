using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lavirint
{
    public class State
    {
        public static int[,] lavirint;
        public State parent;
        List<Kutija> plaveKutije;
        public int markI, markJ; //vrsta i 
        public Hashtable predjeniPut = new Hashtable();
        public double cost;
        PositionGenerator positionGenerator;
        public State sledeceStanje(int markI, int markJ)
        {
            State rez = new State();
            foreach (Kutija i in plaveKutije)
            {
                rez.plaveKutije.Add(i);
            }
            foreach (DictionaryEntry pair in predjeniPut)
            {
                rez.predjeniPut.Add(pair.Key, pair.Value);
            }
            rez.markI = markI;
            rez.markJ = markJ;
            rez.parent = this;
            rez.cost = this.cost + 1;
            return rez;
        }
        public State()
        {
            positionGenerator = new PositionGenerator(markI, markJ, plaveKutije, predjeniPut,this);
            plaveKutije = new List<Kutija>();
        }
        public List<State> mogucaSledecaStanja()
        {
            //TODO1: Implementirati metodu tako da odredjuje dozvoljeno kretanje u lavirintu
            //TODO2: Prosiriti metodu tako da se ne moze prolaziti kroz sive kutije
            return positionGenerator.stanjaZaKralja();
        }

        public override int GetHashCode()
        {
            if(plaveKutije.Count != 0)
            {
                return 100 * markI + markJ + (plaveKutije[0].ID+1) * 1000;
            }
            return 100 * markI + markJ;

        }
        public bool isKutijaStanje()
        {
            if (lavirint[markI,markJ] == 4)
            {
                foreach (Kutija i in plaveKutije)
                {
                    if (i.X == markI && i.Y == markJ)
                        return false;
                }
                plaveKutije.Add(new Kutija(markI,markJ,markI+markJ*10));
                return true;
            }
            return false;
            
        }
        public bool isKrajnjeStanje()
        {
            return Main.krajnjeStanje.markI == markI && Main.krajnjeStanje.markJ == markJ && plaveKutije.Count >= 1;
        }

        public List<State> path()
        {
            List<State> putanja = new List<State>();
            State tt = this;
            while (tt != null)
            {
                putanja.Insert(0, tt);
                tt = tt.parent;
            }
            return putanja;
        }

        
    }
}
