using System.Collections.Generic;

namespace FastFood
{
    class Repository
    {
        public List<Menu> meniuri { get; set; } = new List<Menu>();

        public List<Menu> getAll()
        {
            return meniuri;
        }

        public void add(Menu meniu)
        {
            meniuri.Add(meniu);
        }

        public void remove(int i)
        {
            meniuri.RemoveAt(i);
        }

        public void order(int i)
        {
            meniuri[i].Stoc--;
        }
    }
}
