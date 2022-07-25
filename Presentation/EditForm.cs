using FeedTheCat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedTheCat.Presentation
{
    public partial class EditForm : Form
    {
        public int? id;
        Feed feed1 = null;
        public EditForm(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (this.id != null) 
            {
               LoadInfo();
            }
        }
        private void LoadInfo()
        {
            using (FeedTheCatEntities db = new FeedTheCatEntities())
            {
                feed1 = db.Feed.Find(id);
                DescriptionTextBox.Text = feed1.Description;
                CurrentWeightTextBox.Text = feed1.CurrentWeight.ToString();
                FedByComboBox.Text = feed1.CreatedBy;   
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (FeedTheCatEntities db = new FeedTheCatEntities())
            {

                if (id == null)
                {
                    Feed feed = new Feed();

                    feed.Description = DescriptionTextBox.Text;
                    feed.CurrentWeight = Decimal.Parse(CurrentWeightTextBox.Text);
                    feed.CreatedBy = FedByComboBox.Text;
                    feed.CreatedDate = DateTime.Now;

                    db.Feed.Add(feed);
                }
                else
                {
                    feed1.Description = DescriptionTextBox.Text;
                    feed1.CurrentWeight = Decimal.Parse(CurrentWeightTextBox.Text);
                    feed1.CreatedBy = FedByComboBox.Text;
                    feed1.CreatedDate = DateTime.Now;

                    db.Entry(feed1).State = System.Data.Entity.EntityState.Modified;
                }
               
                db.SaveChanges(); 
            this.Close();

            }
        }

     




        private void EditForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
