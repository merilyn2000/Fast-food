namespace FastFood
{
    class Menu
    {
        string nume;
        bool bauturaInclusa;
        bool sosInclus;
        double pret;
        int valoareaEnergetica;
        int stoc;

        public Menu()
        {

        }

        public Menu(string nume, bool bautura, bool sos, double pret, int val, int stoc)
        {
            this.nume = nume;
            this.bauturaInclusa = bautura;
            this.sosInclus = sos;
            this.pret = pret;
            this.valoareaEnergetica = val;
            this.stoc = stoc;
        }

        public string Nume { get; set; }
        public bool BauturaInclusa { get; set; }
        public bool SosInclus { get; set; }
        public double Pret { get; set; }
        public int ValoareaEnergetica { get; set; }
        public int Stoc { get; set; }
    }
}

