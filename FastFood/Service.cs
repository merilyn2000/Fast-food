using System;
using System.Collections.Generic;

namespace FastFood
{
    class Service
    {
        Repository rep;
        public Service(Repository repository)
        {
            this.rep = repository;
        }

        public void add(Menu meniu)
        {
            meniuri.Add(meniu);
        }

        public void remove(int i)
        {
            this.rep.remove(i);
        }

        public List<Menu> meniuri { get; set; } = new List<Menu>();
        public List<Menu> getAll()
        {
            return meniuri;
        }

        public void order(int i)
        {
            List<Menu> meniuri = getAll();
            if(meniuri[i].Stoc==0)
            {
                throw new Exception("Stoc epuizat !");
            }
        }
    }
}
