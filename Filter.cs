namespace ProgmanCodeChallenge
{
    public class Filter : Part
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }


        public override string ToString()
        {
            return base.ToString() + $" Filter: Property1: {Property1}, Property2: {Property2}.";
        }

    }
}