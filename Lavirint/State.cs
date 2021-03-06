﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lavirint
{
    public class State
    {
        public static int[,] lavirint;
        State parent;
        public int markI, markJ; //vrsta i kolona
        public double cost;
        public State sledeceStanje(int markI, int markJ)
        {
            State rez = new State();
            rez.markI = markI;
            rez.markJ = markJ;
            rez.parent = this;
            rez.cost = this.cost + 1;
            return rez;
        }
        bool checkPosition(int markI, int markJ)
        {
            if (markI < 0 || markI > 9 || markJ < 0 || markJ > 9 || lavirint[markI, markJ] == 1)
            {
                return false;
            }else
            {
                return true;
            }
        }
        public List<State> stanjaZaKralja()
        {
            List<State> rez = new List<State>();
            if (checkPosition(markI+1, markJ))
            {
                rez.Add(sledeceStanje(markI+1,markJ));
            }
            if (checkPosition(markI, markJ+1))
            {
                rez.Add(sledeceStanje(markI, markJ+1));
            }
            if (checkPosition(markI-1, markJ))
            {
                rez.Add(sledeceStanje(markI-1, markJ));
            }
            if (checkPosition(markI, markJ-1))
            {
                rez.Add(sledeceStanje(markI, markJ-1));
            }
            if (checkPosition(markI-1, markJ-1))
            {
                rez.Add(sledeceStanje(markI-1, markJ-1));
            }
            if (checkPosition(markI-1, markJ+1))
            {
                rez.Add(sledeceStanje(markI-1, markJ+1));
            }
            if (checkPosition(markI+1, markJ+1))
            {
                rez.Add(sledeceStanje(markI+1, markJ+1));
            }
            if (checkPosition(markI+1, markJ-1))
            {
                rez.Add(sledeceStanje(markI+1, markJ-1));
            }
            return rez;
        }
        public List<State> stanjaZaKraljicu()
        {
            int i = 0;
            int j = 0;
            List<State> rez = new List<State>();
            i = 1;
            while (checkPosition(markI + i, markJ))
            {
                rez.Add(sledeceStanje(markI + i, markJ));
                i++;
            }
            j = 1;
           while (checkPosition(markI, markJ + j))
            {
                rez.Add(sledeceStanje(markI, markJ + j));
                j++;
            }
            i = -1;
           while (checkPosition(markI + i, markJ))
            {
                rez.Add(sledeceStanje(markI + i, markJ));
                i--;
            }
            j = -1;
            while(checkPosition(markI, markJ +j))
            {
                rez.Add(sledeceStanje(markI, markJ +j));
                j--;
            }
            i = -1;
            j = -1;
            while (checkPosition(markI +i, markJ +j))
            {
                rez.Add(sledeceStanje(markI +i, markJ +j));
                i--;
                j--;
            }
            i = -1;
            j = 1;
          while(checkPosition(markI +i, markJ + j))
            {
                rez.Add(sledeceStanje(markI +i, markJ + j));
                i--;
                j++;
            }
            i = 1;
            j = 1;
          while(checkPosition(markI + i, markJ + j))
            {
                rez.Add(sledeceStanje(markI + i, markJ + j));
                i++;
                j++;
            }
            i = 1;
            j = -1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(sledeceStanje(markI + i, markJ +j));
                i++;
                j--;
            }
            return rez;
        }
        public List<State> stanjaZaTopa()
        {
            int i = 0;
            int j = 0;
            List<State> rez = new List<State>();
            i = 1;
            while (checkPosition(markI + i, markJ))
            {
                rez.Add(sledeceStanje(markI + i, markJ));
                i++;
            }
            j = 1;
            while (checkPosition(markI, markJ + j))
            {
                rez.Add(sledeceStanje(markI, markJ + j));
                j++;
            }
            i = -1;
            while (checkPosition(markI + i, markJ))
            {
                rez.Add(sledeceStanje(markI + i, markJ));
                i--;
            }
            j = -1;
            while (checkPosition(markI, markJ + j))
            {
                rez.Add(sledeceStanje(markI, markJ + j));
                j--;
            }
            
            return rez;

        }
        public List<State> stanjaZaLovca()
        {
            int i = 0;
            int j = 0;
            List<State> rez = new List<State>();
           
            i = -1;
            j = -1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(sledeceStanje(markI + i, markJ + j));
                i--;
                j--;
            }
            i = -1;
            j = 1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(sledeceStanje(markI + i, markJ + j));
                i--;
                j++;
            }
            i = 1;
            j = 1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(sledeceStanje(markI + i, markJ + j));
                i++;
                j++;
            }
            i = 1;
            j = -1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(sledeceStanje(markI + i, markJ + j));
                i++;
                j--;
            }
            return rez;
        }
        public List<State> stanjaZaKonja()
        {
           
            List<State> rez = new List<State>();
            if (checkPosition(markI + 2, markJ+1))
            {
                rez.Add(sledeceStanje(markI + 2, markJ+1));
            }
            if (checkPosition(markI+1, markJ + 2))
            {
                rez.Add(sledeceStanje(markI+1, markJ +2));
            }
            if (checkPosition(markI - 2, markJ-1))
            {
                rez.Add(sledeceStanje(markI - 2, markJ+1));
            }
            if (checkPosition(markI-1, markJ -2))
            {
                rez.Add(sledeceStanje(markI-1, markJ - 2));
            }
            if (checkPosition(markI + 1, markJ - 2))
            {
                rez.Add(sledeceStanje(markI+1, markJ - 2));
            }
            if (checkPosition(markI - 1, markJ+ 2))
            {
                rez.Add(sledeceStanje(markI-1, markJ +2));
            }
            if (checkPosition(markI - 2, markJ -1))
            {
                rez.Add(sledeceStanje(markI -2, markJ-1));
            }
            if (checkPosition(markI + 2, markJ - 1))
            {
               rez.Add(sledeceStanje(markI + 2, markJ - 1));
            }

                return rez;
        }
        public List<State> mogucaSledecaStanja()
        {
            //TODO1: Implementirati metodu tako da odredjuje dozvoljeno kretanje u lavirintu
            //TODO2: Prosiriti metodu tako da se ne moze prolaziti kroz sive kutije
            return stanjaZaKralja();
        }

        public override int GetHashCode()
        {
            return 100*markI + markJ;
        }

        public bool isKrajnjeStanje()
        {
            return Main.krajnjeStanje.markI == markI && Main.krajnjeStanje.markJ == markJ;
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
