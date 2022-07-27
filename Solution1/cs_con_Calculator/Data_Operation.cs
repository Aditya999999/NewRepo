using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Calculator
{
    enum TypeOfMathematicalOperations
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }
    public abstract class Data_Operation
    {


        public int I1, I2;
        public TypeOfMathematicalOperations OperationType { get; protected set; }

    }
    public class Addition : Data_Operation
    {

        public Addition(int input1, int input2, string OperationType)
        {
            base.I1 = input1;
            base.I2 = input2;
            base.OperationType = TypeOfMathematicalOperations.Addition;

        }
        public int input1
        {
            get
            {
                return base.I1;
            }
        }

        public int input2
        {
            get
            {
                return base.I2;
            }
        }
        public int CalAddition(int input1, int input2)
        {
            return input1 + input2;
        }
    }
    public class Subtraction : Data_Operation
    {

        public Subtraction(int input1, int input2, string OperationType)
        {
            base.I1 = input1;
            base.I2 = input2;
            base.OperationType = TypeOfMathematicalOperations.Subtraction;

        }
        public int input1
        {
            get
            {
                return base.I1;
            }
        }

        public int input2
        {
            get
            {
                return base.I2;
            }
        }
        public int CalSubstraction(int input1, int input2)
        {
            return input1 - input2;
        }
    }
    public class Multiplication : Data_Operation
    {

        public Multiplication(int input1, int input2, string OperationType)
        {
            base.I1 = input1;
            base.I2 = input2;
            base.OperationType = TypeOfMathematicalOperations.Multiplication;

        }
        public int input1
        {
            get
            {
                return base.I1;
            }
        }

        public int input2
        {
            get
            {
                return base.I2;
            }
        }
        public int CalMultiplication(int input1, int input2)
        {
            return input1 * input2;
        }
    }
    public class Division : Data_Operation
    {

        public Division(int input1, int input2, string OperationType)
        {
            base.I1 = input1;
            base.I2 = input2;
            base.OperationType = TypeOfMathematicalOperations.Division;

        }
        public int input1
        {
            get
            {
                return base.I1;
            }
        }

        public int input2
        {
            get
            {
                return base.I2;
            }
        }
        public int CalDivision(int input1, int input2)
        {
            return input1 / input2;
        }

    }
}
