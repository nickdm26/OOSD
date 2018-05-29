/*
 *  Nick Muldrew
 *  OOSD Assignment 1, Gray Scott Simulator.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ENeighbours is not currently being used as i cant figure out how to use it to retrive certain Cell from the array Cellneighbours.
public enum ENeighbours { TOPLEFT, LEFT, BOTTOMLEFT, BOTTOM, BOTTOMRIGHT, RIGHT, TOPRIGHT, TOP}

namespace MULDND1Assignment1
{
    /*
     * Cell is to hold the various Datafields which are later used for simulation.
     */
    public class Cell
    {
        public int XPos { get; set; }               //XPos and YPos are used to quickly get the postion which the cell is at to draw it.
        public int YPos { get; set; }

        public double A { get; set; }               //A and B are used to perform various calulations for the Reaction Diffusion Models.
        public double B { get; set; }

        public const int CellWidth = 1;            //Constant Width and height are also used to draw the Cell
        public const int CellHeight = 1;

        private Cell[] Cellneighbours;             //Cellneighbours array is used to hold the neighbours of the cell.

        /*
         * getCellWidth returns the CellWidth
         */
        public int getCellWidth()
        {
            return CellWidth;
        }

        /*
         * getCellHeight returns the CellHeight
         */
        public int getCellHeight()
        {
            return CellHeight;
        }

        /*
         * Cell constructer is used to set the A and B values when creating the Cell.
         */
        public Cell(double A, double B)
        {
            this.A = A;
            this.B = B;
        }

        /*
         * GetCellneighbour is used to get the current Neighbour of the Cell.
         * I Would like to use a enum instead of int to increase the readablity but im not quite sure how.
         */
        public Cell GetCellneighbour(int cellNeighbour)
        {
            return Cellneighbours[cellNeighbour];
        }

        /*
         * SetCellneighbours is used to set the array Cellneighbours which holds the neighbours surronding the Cell.
         */
        public void SetCellneighbours(Cell[] neighbours)
        {
            Cellneighbours = new Cell[8];

            for(int i = 0; i < neighbours.Length; i++)
            {
                Cellneighbours[i] = neighbours[i];
            }
        }
    }
}
