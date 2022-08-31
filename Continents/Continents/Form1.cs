using System;
using System.Windows.Forms;

namespace Continents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ContinentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] AsiaCountries = { "China", "India", "Indonesia", "Pakistan", "Bangladesh", "Japan", "Philippines", "Vietnam", "Iran", "Turkey" };
            string[] AfricaCountries = { "Nigeria", "Ethiopia", "Egypt", "DR Congo", "Tanzania", "South Africa", "Kenya", "Uganda", "Sudan", "Algeria" };
            string[] NACountries = { "United States", "Mexico", "Canada", "Guatemala", "Cuba", "Haiti", "Dominican Republic", "Honduras", "Nicaragua", "El Salvador" };
            string[] SACountries = { "Brazil", "Colombia", "Argentina", "Peru", "Venezuela", "Chile", "Ecuador", "Bolivia", "Paraguay", "Uruguay" };
            string[] EuropeCountries = { "Russia", "Germany", "United Kingdom", "France", "Italy", "Spain", "Ukraine", "Poland", "Romania", "Netherlands" };
            string[] AntarcticaCountries = { "Argentina", "Australia", "Brazil", "Chile", "China", "France", "France/Italy", "Germany", "India", "Japan" };
            string[] AustraliaCountries = { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide", "Gold Coast", "Canberra", "Newcastle", "Wollongong", "Logan City" };
            switch (ContinentList.SelectedIndex)
            {
                case 0:CountryList.Items.Clear();foreach (string Country in AsiaCountries)CountryList.Items.Add(Country);break;
                case 1: CountryList.Items.Clear(); foreach (string Country in AfricaCountries) CountryList.Items.Add(Country); break;
                case 2: CountryList.Items.Clear(); foreach (string Country in NACountries) CountryList.Items.Add(Country); break;
                case 3: CountryList.Items.Clear(); foreach (string Country in SACountries) CountryList.Items.Add(Country); break;
                case 4: CountryList.Items.Clear(); foreach (string Country in AntarcticaCountries) CountryList.Items.Add(Country); break;
                case 5: CountryList.Items.Clear(); foreach (string Country in EuropeCountries) CountryList.Items.Add(Country); break;
                case 6: CountryList.Items.Clear(); foreach (string Country in AustraliaCountries) CountryList.Items.Add(Country); break;
            }
        }
    }
}
