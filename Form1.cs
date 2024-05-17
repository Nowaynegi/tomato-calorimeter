namespace tomato_calorimeter
{
    public partial class Form1 : Form
    {
        public static double massOfWater;
        public static double massOfMetal;
        public static double roomTemperature;
        public static double heat;
        public static double tempOfMetal;
        public static double heatMultiplier;
        public static Element typeOfMetal;

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                massOfWater = double.Parse(MassOfWaterTextbox.Text);
                massOfMetal = double.Parse(MassOfMetalTextbox.Text);
                roomTemperature = double.Parse(RoomTemperatureTextbox.Text);
                tempOfMetal = double.Parse(TempOfMetalTextbox.Text);
                typeOfMetal = (Element)Enum.Parse(typeof(Element), MetalComboBox.Text);
                heatMultiplier = GetHeatMultiplier(SpecificUnit.Text);
            }
            catch
            {
                MessageBox.Show("Missing or incorrect value");
            }

            CalculatedHeat.Text = CalculateHeat().ToString();
        }

        public double CalculateHeat()
        {
            heat = massOfMetal * GetSpecificHeatOfMetal(typeOfMetal) * (tempOfMetal - roomTemperature) * heatMultiplier;
            return heat;
        }

        public double GetSpecificHeatOfMetal(Element meow)
        {
            return meow switch
            {
                Element.Tungstun => 0.134,
                Element.Titanium => 0.523,
                Element.Copper => 0.385,
                Element.Zinc => 0.387,
                Element.Iron => 0.449,
                _ => 0.0
            };
        }

        private void SpecificUnit_Click(object sender, EventArgs e)
        {
            if (SpecificUnit.Text == "Joule")
            {
                heatMultiplier = 4.18;
                return;
            }
            heatMultiplier = 1;
        }
        private double GetHeatMultiplier(string unit)
        {
            return unit switch
            {
                "Joule" => 4.18,
                "calorie" => 1
            } ;
        }
    }


}

public enum Element
{
    Tungstun,
    Titanium,
    Copper,
    Zinc,
    Iron
}