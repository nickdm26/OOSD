/*
 *  Nick Muldrew
 *  OOSD Assignment 1, Gray Scott Simulator.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MULDND1Assignment1
{
    /*
     * The Logic behind what happens when a form event is trigged.
     */
    public partial class Form1 : Form
    {
        public Manager manager;         //Data Fields
        public Graphics canvas;
        public bool displayGrid;

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Form1_Load is used to create a Graphics canvas, Instance of the manager class and to enable the form controls when the form loads.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = panel1.CreateGraphics();
            manager = new Manager(canvas, progressBar1);
            EnableControls();            
        }

        /*
         * btnStop_Click is designed to stop the simulation from running however it does not currently work correctly.
         */
        private void btnStop_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            EnableControls();
            manager.Stop();
        }

        /*
         * btnStart_Click is used to start the simulation.
         * 
         */
        private void btnStart_Click(object sender, EventArgs e)
        {
            DisableControls();                                  //Disable controls so errors are prevented.
            int width = (int)numericUpDownGridHeight.Value;         //gets the values from the various form elements.
            int height = (int)numericUpDownGridHeight.Value;
            int cycles = (int)numericUpDownCycles.Value;
            int timesToReRun = (int)numericUpDownTimes.Value;
            double feedRate = (double)numericUpDownFeedRate.Value;
            double killRate = (double)numericUpDownKillRate.Value;
            double incrementValues = (double)numericUpDownIncrementValues.Value;
            ELaplacianFunctions LapFunc;
            EShadingAlgorthims ShadeAlgorthim;

            if (rbtnConvolution.Checked)                            //LapFunc enum is set based on which radiobutton was checked.
            {
                LapFunc = ELaplacianFunctions.CONVOLUTION;
            }else if (rbtnDelta_Means.Checked)
            {
                LapFunc = ELaplacianFunctions.DELTA_MEANS;
            }
            else
            {
                LapFunc = ELaplacianFunctions.PERPENDICULAR_NEIGHBOURS;
            }

            if (rbtnGrayScale.Checked)                              //ShadeAlgorthim enum is set based which radiobutton was checked.
            {
                ShadeAlgorthim = EShadingAlgorthims.GRAYSCALE;
            }else if (rbtnShortRainbow.Checked)
            {
                ShadeAlgorthim = EShadingAlgorthims.SHORT_RAINBOW;
            }
            else if (rbtnLongRainbow.Checked)
            {
                ShadeAlgorthim = EShadingAlgorthims.LONG_RAINBOW;
            }
            else
            {
                ShadeAlgorthim = EShadingAlgorthims.YELLOW_TO_RED;
            }

            if (rbtnYes.Checked)                                    //the display grid boolean is set depending upon which radiobutton is checked.
            {
                displayGrid = true;
            }
            else
            {
                displayGrid = false;
            }

            if (rbtnReRunYes.Checked)                              //If the ReRun simulation radiobutton is checked.
            {
                for(int times = 0; times < timesToReRun; times++)       //Then the simulation is reRun X times with the feedRate and KillRate being incremented each time.
                {
                    feedRate += incrementValues;
                    killRate += incrementValues;
                    numericUpDownFeedRate.Enabled = true;
                    numericUpDownKillRate.Enabled = true;
                    numericUpDownFeedRate.Value = (decimal)feedRate;
                    numericUpDownKillRate.Value = (decimal)killRate;
                    numericUpDownFeedRate.Enabled = false;
                    numericUpDownKillRate.Enabled = false;

                    manager.RunSimulation(width, height, cycles, feedRate, killRate, LapFunc, ShadeAlgorthim, displayGrid); //RunSimulation is called to start the Simulation.
                }
                
            }else                                               //If ReRun is unchecked then the simulation is only run once.
            {
                manager.RunSimulation(width, height, cycles, feedRate, killRate, LapFunc, ShadeAlgorthim, displayGrid);     //RunSimulation is called to start the Simulation.
            }
            
            EnableControls();       //The Controls are enabled again after the simulation has finshed.
        }

        /*
         * DisableControls is used to disable the form controls when the simulation is running so that possible errors are reduced.
         */
        public void DisableControls()
        {
            numericUpDownFeedRate.Enabled = false;
            numericUpDownKillRate.Enabled = false;
            numericUpDownCycles.Enabled = false;
            numericUpDownGridHeight.Enabled = false;
            numericUpDownIncrementValues.Enabled = false;
            numericUpDownTimes.Enabled = false;

            groupBoxLaplacianFunctions.Enabled = false;
            groupBoxShadingAlgorithm.Enabled = false;
            groupBoxSimulationValues.Enabled = false;
            groupBoxReRunSim.Enabled = false;
            groupBoxDisplayGrid.Enabled = false;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        /*
         * EnableControls is used to enable the form controls when the simulation is not running so diffrent values and parameters may be set.
         */
        public void EnableControls()
        {
            numericUpDownFeedRate.Enabled = true;
            numericUpDownKillRate.Enabled = true;
            numericUpDownCycles.Enabled = true;
            numericUpDownGridHeight.Enabled = true;
            numericUpDownIncrementValues.Enabled = true;
            numericUpDownTimes.Enabled = true;

            groupBoxLaplacianFunctions.Enabled = true;
            groupBoxShadingAlgorithm.Enabled = true;
            groupBoxSimulationValues.Enabled = true;
            groupBoxReRunSim.Enabled = true;
            groupBoxDisplayGrid.Enabled = true;
            
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
