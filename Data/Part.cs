namespace ProgmanCodeChallenge
{

    public class Part
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"ProductCode: {ProductCode}, Description: {Description}";
        }

    }
}