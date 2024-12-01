﻿using System;
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
    public partial class FrmNewLocation : Form
    {
        public FrmNewLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities1 db = new EgitimKampiEfTravelDbEntities1();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;  
        }

        private void FrmNewLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new

            {
                FullName=x.GuideName + " " + x.GuiderSurname,
                x.GuideId
            }).ToList();

            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapicity = byte.Parse(nudCapacity.Value.ToString());
            location.LocationCity=txtCity.Text;
            location.LocationCountry=txtCountry.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.DayNight=txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.DayNight= txtDayNight.Text;    
            updatedValue.LocationPrice=decimal.Parse(txtPrice.Text);
            updatedValue.LocationCapicity=byte.Parse(nudCapacity.Value.ToString());
            updatedValue.LocationCity= txtCity.Text;
            updatedValue.LocationCountry= txtCountry.Text;
            updatedValue.GuideId=int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");

        }
    }
}
