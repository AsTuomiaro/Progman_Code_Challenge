namespace ProgmanCodeChallenge
{

    public class Coil : Part
    {
        public Property1Setting Property1 { get; set; }
        public Property2Setting Property2 { get; set; }

        public enum Property1Setting
        {
            Something,
            Else,
            More
        }

        public enum Property2Setting
        {
            Something,
            More,
            Else
        }

        public override string ToString()
        {
            return base.ToString() + $" Coil: Property1: {Property1}, Property2: {Property2}.";
        }
    }
}