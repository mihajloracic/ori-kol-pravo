using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lavirint
{
    class PositionGenerator
    {
        int markI, markJ;
        State parent;
        List<Kutija> plaveKutije = new List<Kutija>();
        Hashtable predjeniPut = new Hashtable();
        State state;
        public PositionGenerator(int markI,int markJ, List<Kutija> plaveKutije, Hashtable predjeniPut, State state)
        {
            this.markI = markI;
            this.markJ = markJ;
            this.predjeniPut = predjeniPut;
            this.state = state;
            this.plaveKutije = plaveKutije;
        }
        protected bool checkPosition(int markI, int markJ)
        {
            if (markI < 0 || markI > 9 || markJ < 0 || markJ > 9 || State.lavirint[markI, markJ] == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public List<State> stanjaZaKralja()
        {
            List<State> rez = new List<State>();
            if (checkPosition(markI + 1, markJ))
            {
                rez.Add(state.sledeceStanje(markI + 1, markJ));
            }
            if (checkPosition(markI, markJ + 1))
            {
                rez.Add(state.sledeceStanje(markI, markJ + 1));
            }
            if (checkPosition(markI - 1, markJ))
            {
                rez.Add(state.sledeceStanje(markI - 1, markJ));
            }
            if (checkPosition(markI, markJ - 1))
            {
                rez.Add(state.sledeceStanje(markI, markJ - 1));
            }
            if (checkPosition(markI - 1, markJ - 1))
            {
                rez.Add(state.sledeceStanje(markI - 1, markJ - 1));
            }
            if (checkPosition(markI - 1, markJ + 1))
            {
                rez.Add(state.sledeceStanje(markI - 1, markJ + 1));
            }
            if (checkPosition(markI + 1, markJ + 1))
            {
                rez.Add(state.sledeceStanje(markI + 1, markJ + 1));
            }
            if (checkPosition(markI + 1, markJ - 1))
            {
                rez.Add(state.sledeceStanje(markI + 1, markJ - 1));
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
                rez.Add(state.sledeceStanje(markI + i, markJ));
                i++;
            }
            j = 1;
            while (checkPosition(markI, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI, markJ + j));
                j++;
            }
            i = -1;
            while (checkPosition(markI + i, markJ))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ));
                i--;
            }
            j = -1;
            while (checkPosition(markI, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI, markJ + j));
                j--;
            }
            i = -1;
            j = -1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ + j));
                i--;
                j--;
            }
            i = -1;
            j = 1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ + j));
                i--;
                j++;
            }
            i = 1;
            j = 1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ + j));
                i++;
                j++;
            }
            i = 1;
            j = -1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ + j));
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
                rez.Add(state.sledeceStanje(markI + i, markJ));
                i++;
            }
            j = 1;
            while (checkPosition(markI, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI, markJ + j));
                j++;
            }
            i = -1;
            while (checkPosition(markI + i, markJ))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ));
                i--;
            }
            j = -1;
            while (checkPosition(markI, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI, markJ + j));
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
                rez.Add(state.sledeceStanje(markI + i, markJ + j));
                i--;
                j--;
            }
            i = -1;
            j = 1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ + j));
                i--;
                j++;
            }
            i = 1;
            j = 1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ + j));
                i++;
                j++;
            }
            i = 1;
            j = -1;
            while (checkPosition(markI + i, markJ + j))
            {
                rez.Add(state.sledeceStanje(markI + i, markJ + j));
                i++;
                j--;
            }
            return rez;
        }
        public List<State> stanjaZaKonja()
        {

            List<State> rez = new List<State>();
            if (checkPosition(markI + 2, markJ + 1))
            {
                rez.Add(state.sledeceStanje(markI + 2, markJ + 1));
            }
            if (checkPosition(markI + 1, markJ + 2))
            {
                rez.Add(state.sledeceStanje(markI + 1, markJ + 2));
            }
            if (checkPosition(markI - 2, markJ - 1))
            {
                rez.Add(state.sledeceStanje(markI - 2, markJ + 1));
            }
            if (checkPosition(markI - 1, markJ - 2))
            {
                rez.Add(state.sledeceStanje(markI - 1, markJ - 2));
            }
            if (checkPosition(markI + 1, markJ - 2))
            {
                rez.Add(state.sledeceStanje(markI + 1, markJ - 2));
            }
            if (checkPosition(markI - 1, markJ + 2))
            {
                rez.Add(state.sledeceStanje(markI - 1, markJ + 2));
            }
            if (checkPosition(markI - 2, markJ - 1))
            {
                rez.Add(state.sledeceStanje(markI - 2, markJ - 1));
            }
            if (checkPosition(markI + 2, markJ - 1))
            {
                rez.Add(state.sledeceStanje(markI + 2, markJ - 1));
            }

            return rez;
        }
    }
}
