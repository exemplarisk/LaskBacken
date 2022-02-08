namespace AddToArray
{
    public class SodaCrate
    {
        public List<Soda> sodas = new List<Soda>();

        public void Add(Soda soda)
        {
            sodas.Add(soda);
        }
        public void Remove(int index)
        {
            sodas.RemoveAt(index);
        }
        public void PrintCrate()
        {
            Console.WriteLine("----------DIN BACK----------");
            foreach(Soda soda in sodas)
            {
                int index = sodas.IndexOf(soda);
                Console.WriteLine(index + ":" + soda.Name);
            }

        }
    }
}