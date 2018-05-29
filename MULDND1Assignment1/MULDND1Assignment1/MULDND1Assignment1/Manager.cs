/*
 *  Nick Muldrew
 *  OOSD Assignment 1, Gray Scott Simulator.
 */
using MULDND1Assignment1.Laplacian_Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MULDND1Assignment1
{
    /*
     * Manager class is used to manage the basic function that tie the Application together.
     * Such as Setting the CellGrid and each of the Cells neighbours in it.
     * Settting up the simulation and then running each cycle.
     * Passing the Grid to GridDrawer to save or draw the Grid.
     * Update the ProgressBar
     * Uses a Laplacian Factory to create the correct Laplacian function to be used.
     */
    public class Manager
    {
        //Data Fields
        private ProgressBar progressbar;
        private Graphics canvas;
        private Cell[,] CellGrid;
        private int Width;
        private int Height;
        private ILaplacian LapFunction;
        private LaplacianFactory LapFactory;
        private GridDrawer gridDrawer;
        private double SeedValue;
        private int Cycles;
        private int CurrentCycle;
        private double Diffusion_A;
        private double Diffusion_B;
        private double FeedRate_A;
        private double KillRate_B;
        private ELaplacianFunctions laplacianEnum;
        private EShadingAlgorthims shadingEnum;
        private bool displayGrid;

        /*
         * Manager Constructer
         * Takes in a Graphics object and a progress bar which is used to by the user to track how far along a simulation is.
         */
        public Manager(Graphics canvas, ProgressBar progressbar)
        {
            this.canvas = canvas;
            this.progressbar = progressbar;
        }         

        /*
         * CreateStringName is used to create a String name holding diffrent Parameters that were used in the current simulation cycle.
         * This string is later passed over to the GridDrawer class and used to help name a file correctly when it is saved.
         */
        public string CreateStringName()
        {
            string lapString = "";
            string shadingString = "";

            switch (laplacianEnum)                  //Switch used to create a string from a Enum
            {
                case ELaplacianFunctions.CONVOLUTION:
                    lapString = "Convolution";
                    break;
                case ELaplacianFunctions.DELTA_MEANS:
                    lapString = "Delta";
                    break;
                case ELaplacianFunctions.PERPENDICULAR_NEIGHBOURS:
                    lapString = "Perpendicular";
                    break;
            }

            switch (shadingEnum)                    //Switch used to create a string from a Enum
            {
                case EShadingAlgorthims.GRAYSCALE:
                    shadingString = "GrayScale";
                    break;
                case EShadingAlgorthims.SHORT_RAINBOW:
                    shadingString = "ShortRainbow";
                    break;
                case EShadingAlgorthims.LONG_RAINBOW:
                    shadingString = "LongRainbow";
                    break;
                case EShadingAlgorthims.YELLOW_TO_RED:
                    shadingString = "YellowToRed";
                    break;
            }

            return lapString + "_" + shadingString + "_" + FeedRate_A.ToString() + "_" + KillRate_B.ToString() + "_" + Diffusion_A.ToString() + "_" + Diffusion_B.ToString() + "_" + Width + "_" + CurrentCycle + "_" + Cycles; 
        }
        
        /*
         * Stop is used to stop the current simulation.
         * Currently not working.
         */
        public void Stop()
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(224,224,224));     
            canvas.FillRectangle(brush, 0, 0, Width, Height);                   //Clears the entire canvas.
        }

        /*
         * RunSimulation is used to setup the variables and call the various method to setup the simulation.
         * When the setup is complete it runs a for loop for the amount of Cycles calling the method RunCycle() in each iteration.
         */
        public void RunSimulation(int Width, int Height, int Cycles, double FeedRate_A, double KillRate_B, ELaplacianFunctions laplacianEnum, EShadingAlgorthims shadingEnum, bool displayGrid)
        {
            this.Width = Width;
            this.Height = Height;
            this.Cycles = Cycles;
            this.FeedRate_A = FeedRate_A;
            this.KillRate_B = KillRate_B;
            this.laplacianEnum = laplacianEnum;         //Data Fields are being set
            this.shadingEnum = shadingEnum;
            this.displayGrid = displayGrid;
            CurrentCycle = 0;
            progressbar.Maximum = Cycles;
            progressbar.Value = 0;
            SeedValue = 0.25;

            gridDrawer = new GridDrawer(canvas, Width, Height, shadingEnum);    //Instance of GridDrawer is created which is later used to draw or save the grid.
            LapFactory = new LaplacianFactory();                                
            LapFunction = LapFactory.CreateNewLaplacian(laplacianEnum);         //LapFunction instance is created using the CreateNewLaplacian method from LapFactory.            
            Diffusion_A = LapFunction.GetDiffusion_A();                         //The Diffusion A and B differ depending upon what Lapacian function is used.
            Diffusion_B = LapFunction.GetDiffusion_B();

            SetCellGrid();                                                      //The CellGrid is set and filled up with a seed;
            SetCellNeighbours();                                                //In the entre grid all the cells are passed the Cells neighbouring them.
            Stop();                                                             //Called so the canvas is cleared

            for(int cycleNum = 0; cycleNum < Cycles; cycleNum++)                //Loops through the cycles calling RunCycle each time.
            {
                RunCycle();
            }
        }

        /*
         * RunCycle is used to perform the various calculations and method calls for a simulation cycle.
         * Calculates the future A and B value for each cell and sets them once they have been calculated.
         */
        public void RunCycle()
        {          
            double futureA;
            double futureB;

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)                   //For loop used to go through the grid and calculate the A and B value before setting them.
                {
                    futureA = CalculateFuture_A(CellGrid[row, col]);
                    futureB = CalculateFuture_B(CellGrid[row, col]);
                    CellGrid[row, col].A = futureA;
                    CellGrid[row, col].B = futureB;
                }
            }
            
            CurrentCycle++;                                             //CurrentCycle is incremented to keep track of the current loop.
            gridDrawer.SetGrid(CellGrid);                               //Passes the CellGrid into a instance of GridDrawer

            progressbar.PerformStep();                                  //Increments and updates the progressBar so you can keep track of how far along the simulation is.
            progressbar.Update();

            if (displayGrid)                                            //If the user has set the boolean display grid to true
            {
                gridDrawer.DrawToCanvas();                              //Then the Grid is drawn to the canvas
            }else
            {
                gridDrawer.SaveFile(CreateStringName());                //OtherWise the grid is not drawn and simply saved to a file.
            }
        }

        /*
         * SetCellneighbours is used to set the neighbours for each Cell and then pass them in as a array of cells.
         * Loops through the CellGrid checking which postion the Cell is at eg. in a corner or against the side.
         * If in a corner or agasint a side then it takes the neighbour from the opposite side so as to make the grid wrap around.
         * e.g. making the top and bottom neightbours as well as the left and right.
         * Code is not as nice as how i would like it. I was unable to figure out how to use a Enum to refrence the number in the array instead.
         */
        public void SetCellNeighbours()
        {
            Cell[] cellArrayNeighbours;
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    cellArrayNeighbours = new Cell[8];

                    if (row == 0 && col == 0)                //TOPLeft
                    {
                        cellArrayNeighbours[0] = CellGrid[Height-1, Width-1];       //uniq

                        cellArrayNeighbours[1] = CellGrid[row, Width - 1];        //Left from col
                        cellArrayNeighbours[2] = CellGrid[row + 1, Width - 1];    //Bottomleft from col
                        cellArrayNeighbours[3] = CellGrid[row + 1, col];        //Bottom
                        cellArrayNeighbours[4] = CellGrid[row + 1, col + 1];    //BottomRight
                        cellArrayNeighbours[5] = CellGrid[row, col + 1];        //Right
                        cellArrayNeighbours[6] = CellGrid[Height - 1, col + 1]; //TopRight from row
                        cellArrayNeighbours[7] = CellGrid[Height - 1, col];     //Top  from row
                    }
                    else if (row == Height-1 && col == 0)     //BottomLeft
                    {
                        cellArrayNeighbours[0] = CellGrid[row - 1, Width - 1];    //Topleft from col
                        cellArrayNeighbours[1] = CellGrid[row, Width - 1];        //Left from col

                        cellArrayNeighbours[2] = CellGrid[0, Width-1];          //uniq

                        cellArrayNeighbours[3] = CellGrid[0, col];          //Bottom from row
                        cellArrayNeighbours[4] = CellGrid[0, col + 1];      //BottomRight from row
                        cellArrayNeighbours[5] = CellGrid[row, col + 1];        //Right
                        cellArrayNeighbours[6] = CellGrid[row - 1, col + 1];    //TopRight
                        cellArrayNeighbours[7] = CellGrid[row - 1, col];        //Top
                    }
                    else if (row == Height-1 && col == Width-1) //BottomRight
                    {
                        cellArrayNeighbours[0] = CellGrid[row - 1, col - 1];    //Topleft
                        cellArrayNeighbours[1] = CellGrid[row, col - 1];        //Left
                        cellArrayNeighbours[2] = CellGrid[0, col - 1];      //BottomLeft from row == height
                        cellArrayNeighbours[3] = CellGrid[0, col];          //Bottom from row == height

                        cellArrayNeighbours[4] = CellGrid[0, 0];

                        cellArrayNeighbours[5] = CellGrid[row, 0];        //Right from col == width
                        cellArrayNeighbours[6] = CellGrid[row - 1, 0];    //TopRight from col == width
                        cellArrayNeighbours[7] = CellGrid[row - 1, col];        //Top
                    }
                    else if (row == 0 && col == Width-1)      //TopRight
                    {
                        cellArrayNeighbours[0] = CellGrid[Height - 1, col - 1]; //TopLeft from row ==0
                        cellArrayNeighbours[1] = CellGrid[row, col - 1];        //Left
                        cellArrayNeighbours[2] = CellGrid[row + 1, col - 1];    //Bottomleft
                        cellArrayNeighbours[3] = CellGrid[row + 1, col];        //Bottom
                        cellArrayNeighbours[4] = CellGrid[row + 1, 0];    //BottomRight from col == width
                        cellArrayNeighbours[5] = CellGrid[row, 0];        //Right from col == width

                        cellArrayNeighbours[6] = CellGrid[Height-1, 0];
                        
                        cellArrayNeighbours[7] = CellGrid[Height - 1, col];     //Top from row ==0
                    }
                    else if (row == 0)        //Top
                    {
                        cellArrayNeighbours[0] = CellGrid[Height-1, col - 1]; //TopLeft
                        cellArrayNeighbours[6] = CellGrid[Height-1, col + 1]; //TopRight
                        cellArrayNeighbours[7] = CellGrid[Height-1, col];     //Top

                        cellArrayNeighbours[1] = CellGrid[row, col - 1];        //Left
                        cellArrayNeighbours[2] = CellGrid[row + 1, col - 1];    //Bottomleft
                        cellArrayNeighbours[3] = CellGrid[row + 1, col];        //Bottom
                        cellArrayNeighbours[4] = CellGrid[row + 1, col + 1];    //BottomRight
                        cellArrayNeighbours[5] = CellGrid[row, col + 1];        //Right

                    }
                    else if(row == Height-1)     //Bottom
                    {
                        cellArrayNeighbours[2] = CellGrid[0, col - 1];      //BottomLeft
                        cellArrayNeighbours[3] = CellGrid[0, col];          //Bottom
                        cellArrayNeighbours[4] = CellGrid[0, col + 1];      //BottomRight

                        cellArrayNeighbours[0] = CellGrid[row - 1, col - 1];    //Topleft
                        cellArrayNeighbours[1] = CellGrid[row, col - 1];        //Left
                        cellArrayNeighbours[5] = CellGrid[row, col + 1];        //Right
                        cellArrayNeighbours[6] = CellGrid[row - 1, col + 1];    //TopRight
                        cellArrayNeighbours[7] = CellGrid[row - 1, col];        //Top
                    }
                    else if(col == 0)        //Left
                    {
                        cellArrayNeighbours[0] = CellGrid[row - 1, Width-1];    //Topleft
                        cellArrayNeighbours[1] = CellGrid[row, Width-1];        //Left
                        cellArrayNeighbours[2] = CellGrid[row + 1, Width-1];    //Bottomleft
                                                
                        cellArrayNeighbours[3] = CellGrid[row + 1, col];        //Bottom
                        cellArrayNeighbours[4] = CellGrid[row + 1, col + 1];    //BottomRight
                        cellArrayNeighbours[5] = CellGrid[row, col + 1];        //Right
                        cellArrayNeighbours[6] = CellGrid[row - 1, col + 1];    //TopRight
                        cellArrayNeighbours[7] = CellGrid[row - 1, col];        //Top
                    }
                    else if(col == Width-1)  //Right
                    {
                        cellArrayNeighbours[4] = CellGrid[row + 1, 0];    //BottomRight
                        cellArrayNeighbours[5] = CellGrid[row, 0];        //Right
                        cellArrayNeighbours[6] = CellGrid[row - 1, 0];    //TopRight

                        cellArrayNeighbours[0] = CellGrid[row - 1, col - 1];    //Topleft
                        cellArrayNeighbours[1] = CellGrid[row, col - 1];        //Left
                        cellArrayNeighbours[2] = CellGrid[row + 1, col - 1];    //Bottomleft
                        cellArrayNeighbours[3] = CellGrid[row + 1, col];        //Bottom                        
                        cellArrayNeighbours[7] = CellGrid[row - 1, col];        //Top
                    }
                    else
                    {
                        cellArrayNeighbours[0] = CellGrid[row - 1, col - 1];    //Topleft
                        cellArrayNeighbours[1] = CellGrid[row, col - 1];        //Left
                        cellArrayNeighbours[2] = CellGrid[row + 1, col - 1];    //Bottomleft
                        cellArrayNeighbours[3] = CellGrid[row + 1, col];        //Bottom
                        cellArrayNeighbours[4] = CellGrid[row + 1, col + 1];    //BottomRight
                        cellArrayNeighbours[5] = CellGrid[row, col + 1];        //Right
                        cellArrayNeighbours[6] = CellGrid[row - 1, col + 1];    //TopRight
                        cellArrayNeighbours[7] = CellGrid[row - 1, col];        //Top
                    }                                      

                    CellGrid[row, col].SetCellneighbours(cellArrayNeighbours);      //Sets the current Cells Neighbours by passing it the array cellArrayNeighbours.
                }
            }
        }        

        /*
         * SetCellGrid is used to Fill the CellGrid with Cells
         * it sets A=1, B=0 as default
         * If in the seeded area however it sets A=0, B=1
         * This is so it can actually make patterns.
         */
        public void SetCellGrid()
        {
            CellGrid = new Cell[Width, Height];     //CellGrid is set to the Width and height Specified.
            Cell cell;

            int seedArea = (int)(Width * SeedValue);        
            int seedStart = (Width / 2) - (seedArea / 2);   //Calulates the point at which the seed values should start
            int seedFinsh = (Width / 2) + (seedArea / 2);   //Calulates the point at which the seed values should finsh

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    cell = new Cell(1, 0);                  //Sets A=1, B=0

                    if (row >= seedStart && row <= seedFinsh)
                    {
                        if(col >= seedStart && col <= seedFinsh)    //Between the Seed start and finsh on the row and colums set A=0, B=1
                        {
                            cell = new Cell(0, 1);
                        }
                    }
                    
                    cell.XPos = col;                    //Sets the XPos and YPos of the cell which is later helpful for drawing the grid.
                    cell.YPos = row;
                    CellGrid[row, col] = cell;          //Sets the new cell in the CellGrid
                }
            }
        }

        /*
         * CalculateFuture_A is used to calculate the new A value using the algorthim given then returns the new A value.
         *  LapFunction.CalculateLaplacianValue_A(cell) is used to calculate the new value from the Laplacian Function used.
         */
        public double CalculateFuture_A(Cell cell)
        {
            //A+1 = A + (DiffA * Lap(A)) - AB^2 + (FeedA * (1-A))
            double Future_A = cell.A + (Diffusion_A * LapFunction.CalculateLaplacianValue_A(cell)) - cell.A * Math.Pow(cell.B, 2) + (FeedRate_A * (1-cell.A));
            return Future_A;
        }

        /*
         * CalculateFuture_B is used to calculate the new B value using the algorthim given then returns the new B value.
         * LapFunction.CalculateLaplacianValue_B(cell) is used to calculate the new value from the Laplacian Function used.
         */
        public double CalculateFuture_B(Cell cell)
        {
            //B+1 = B + (DiffB * Lap(B)) + AB^2 - ((KillB + FeedA) * B)
            double Future_B = cell.B + (Diffusion_B * LapFunction.CalculateLaplacianValue_B(cell)) + cell.A * Math.Pow(cell.B, 2) - ((KillRate_B + FeedRate_A) * cell.B);
            return Future_B;
        }
    }
}
