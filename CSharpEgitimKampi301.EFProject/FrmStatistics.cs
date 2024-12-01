using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities1 db= new EgitimKampiEfTravelDbEntities1();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {

            

        
            lblLocationCount.Text = db.Location.Count().ToString();   
            lblSumCapacity.Text = db.Location.Sum(x=> x.LocationCapicity).ToString();
            lblGuideCount.Text= db.Guide.Count().ToString();
            lblAverageCapacity.Text= db.Location.Average(x=>(decimal?)x.LocationCapicity)?.ToString("0.00");
            lblAvgLocationPrice.Text=db.Location.Average(x=>(decimal?)x.LocationPrice)?.ToString("0,00")+"TL";

            int lastCountryId = db.Location.Max(x => x.LocationId);

            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.LocationCountry).FirstOrDefault();

            lblCapLocationCapacity.Text = db.Location.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapicity).FirstOrDefault().ToString();
            lblTurkeyAvgCapacity.Text = db.Location.Where(x => x.LocationCountry == "Türkiye").Average(y => y.LocationCapicity).ToString();

          
            var romeGuideId = db.Location.Where(x => x.LocationCity == "Roma Turislik").Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuiderSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.LocationCapicity);
            lblMaxCapacity.Text=db.Location.Where(x=>x.LocationCapicity== maxCapacity).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.LocationPrice);
            lblMostExpensivePrice.Text=db.Location.Where(x=>x.LocationPrice==maxPrice).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var guideIdByNameAysegulCinar=db.Guide.Where(x=>x.GuideName=="Ayşegül"&& x.GuiderSurname=="Çınar").Select(y=>y.GuideId).FirstOrDefault();
            lblAysCınarLocationCount.Text=db.Location.Where(x=>x.GuideId==guideIdByNameAysegulCinar).Count().ToString();


        }
    }
}
