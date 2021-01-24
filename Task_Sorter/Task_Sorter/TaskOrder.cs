using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

/// <summary>
/// Created by: Oligert Crroj
/// Assignment: Lab 2 
/// Info: i have follow the lecture on week 6 and week 7 .if you would check on primryqueu class i have similiar code as you example.
/// Thanks to you lecture i was able to understand how linked list would work.I have tried to do everything with my ideas.I hope amount of 
/// code taken from week6demo is not a problem
/// Enjoye :)
/// </summary>

namespace Lab2_OligertCrroj
{
    public partial class TaskOrder : Form
    {

        PrimaryQueue primaryQueue = new PrimaryQueue();
        int countd = 0;
        public TaskOrder()
        {
            InitializeComponent();
            #region Creating the values of ddl
            cbPriority.Items.Add("Critical");
            cbPriority.Items.Add("Important");
            cbPriority.Items.Add("Normal");
            cbPriority.Items.Add("Low");
            #endregion

            #region Creating and adding element on the list
            //Creating the task item 
            Task a1 = new Task("Put out fire", "Critical");
            Task b1 = new Task("Stop robbery", "Important");
            Task b2 = new Task( "Finish Lab", "Important");
            Task c1= new Task("Watch movie", "Normal");
            Task c2= new Task("Eat lunch", "Normal");
            Task c3= new Task("Brush teeth", "Normal");
            Task d1 = new Task(  "Weed garden", "Low");
            Task d2 = new Task("Dust bookshelf", "Low");

            //Adding the task items on the list
            primaryQueue.Add(d2);
            primaryQueue.Add(d1);
            primaryQueue.Add(c3);
            primaryQueue.Add(c2);
            primaryQueue.Add(c1);
            primaryQueue.Add(b2);
            primaryQueue.Add(b1);
            primaryQueue.Add(a1);
            #endregion

            //Created a function because i have used this
            //type of loop really often
            listUpdate();

        }

        public void listUpdate()
        {
            foreach (Task i in primaryQueue)
            {
              string name = i.Name + "  ----- " + i.Dificultys;
              listView1.Items.Add(name);
            }
        }


        private void BtnShow_Click(object sender, EventArgs e)
            {
            //Clearing the list so i could update with proper value
            listView1.Clear();
            //converting the user value to proper fortmat (string)
            string TaskTextb = txtTask.Text.ToString();
            string priorityCbTask = this.cbPriority.GetItemText(this.cbPriority.SelectedItem).ToString();

            #region New item category choosen
            //based on ddl adding it on the right place
            //Low Level
            if (priorityCbTask == "Low")
                primaryQueue.Enqueue(1, TaskTextb, priorityCbTask);
            //Normal Level
            if (priorityCbTask == "Normal")
                primaryQueue.Enqueue(2, TaskTextb, priorityCbTask);
            //Important Level
            if (priorityCbTask == "Important")
                 primaryQueue.Enqueue(3, TaskTextb, priorityCbTask);
            //Crititcal Level
            if (priorityCbTask == "Critical")
              primaryQueue.Enqueue(4, TaskTextb, priorityCbTask);
            #endregion

            //Updating the list with foor loop
            //making sure is proper formated
            listUpdate();
            //using the count funtion created we check how many items is on the list 
            lblTotalTask.Text = "Tasks Completed:" +primaryQueue.Count.ToString();

        }


        #region Exit and cancel button to refresh or exit the form
            private void BtnExit_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void BtnCancel_Click(object sender, EventArgs e)
            {
            txtTask.Clear();
            listView1.Clear();
            cbPriority.ResetText();
            }

            private void BtnDelete_Click(object sender, EventArgs e)
            {
            MessageBox.Show( "You are about to delete first item on the list", "Alert!! ", MessageBoxButtons.OK);
            primaryQueue.Dequeuee();
            listView1.Clear();
            listUpdate();
            countd++;
            lblTaskCompleted.Text = $"Tasks Completed: {countd}";
         }
        #endregion


        private void btnPeek_Click(object sender, EventArgs e)
        {
            //Showing the user the first item on the list
            DialogResult result = MessageBox.Show(primaryQueue.Peek().ToString()+ "\n\n Did You finish this Task?","Upcoming Task ", MessageBoxButtons.YesNoCancel);
            //Extra Feature- if user click yes you remove it 
            if (result == DialogResult.Yes)
            {
                primaryQueue.Dequeuee();
                listView1.Clear();
                listUpdate();
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            primaryQueue.Clear();
            listView1.Items.Clear();
        }

        //Event to create the line in the middle
        private void Lab2_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen (Color.DodgerBlue, 4);
            l.DrawLine(p, 400, 0, 400, 700);


        }
    }

}
