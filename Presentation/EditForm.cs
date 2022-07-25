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
        Feed feed = null;
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
                feed = db.Feed.Find(id);
                DescriptionTextBox.Text = feed.Description;
                CurrentWeightTextBox.Text = feed.CurrentWeight.ToString();
                FedByComboBox.Text = feed.CreatedBy;   
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (FeedTheCatEntities db = new FeedTheCatEntities())
            {
                if (id is null)
                {
                    feed = new Feed();
                }

                feed.Description = DescriptionTextBox.Text;
                feed.CurrentWeight = Decimal.Parse(CurrentWeightTextBox.Text);
                feed.CreatedBy = FedByComboBox.Text;
                feed.CreatedDate = DateTime.Now;

                if (id is null)
                {
                    db.Feed.Add(feed);
                }
                else
                {
                    db.Entry(feed).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
            this.Close();
        }






        private void EditForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
