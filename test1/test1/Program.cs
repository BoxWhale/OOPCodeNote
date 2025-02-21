namespace DefineObject
{
    public class Solidity
    {
        protected float solidity = 0;
        protected float Density = 0;

        protected bool solid
        {
            get { return solidity >= 0.5 && Density > 0; }
        }

        public virtual string ToString()
        {
            return $"Got: {solidity} / {Density} and solid: {solid}";
        }
    }

    public class Shape : Solidity
    {
        string shape
        {
            get { return shape == null || shape == "" ? shape : "Blop"; }
            set { }

        }

        public Shape(string shape)
        {
            this.shape = shape;
        }

        public override string ToString()
        {
            return $"Shape: {shape} Got: {solidity} / {Density} and solid: {solid}";
        }
    }
}