namespace ProgmanCodeChallenge
{
    public class Fan : Part
    {
        public FanTypeSetting FanType { get; set; }
        public FanSpeedSetting FanSpeed { get; set; }

        public enum FanTypeSetting
        {
            Axial,
            Radial
        }

        public enum FanSpeedSetting
        {
            Slow,
            Normal,
            Fast
        }

        public override string ToString()
        {
            return base.ToString() + $" Fan: FanType: {FanType}, FanSpeed: {FanSpeed}.";
        }
    }
}