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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(FeedsDataGridView.Rows[FeedsDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }


        private void LoadInfo()
        {
            using (FeedTheCatEntities db = new FeedTheCatEntities())
            {
                List<Feed> feeds = db.Feed.ToList();
                this.FeedsDataGridView.DataSource = feeds;
            }
        }

        private void NewFeedButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
            LoadInfo();
        }
        private void EditFeedButton_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {

                Presentation.EditForm editForm = new Presentation.EditForm(id);

                editForm.ShowDialog();
                LoadInfo();
            }
        }

        private void DeleteFeedButton_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (FeedTheCatEntities db = new FeedTheCatEntities())
                {
                    Feed feed2 = db.Feed.Find(id);
                    db.Feed.Remove(feed2);


                    db.SaveChanges();
                    LoadInfo();
                }
            }
        }

        private void FeedsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
