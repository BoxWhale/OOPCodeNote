using System.Security.Cryptography;

namespace DefineObject
{
    interface ISolidity
    {
        void Defy(string solidarity, string density);
        void Defy(float solidarity, float density);
        string Physicality();
        public string ToString();

    }
    public class Solidity : ISolidity
    {
        protected float solidity = 0;
        protected float density = 0;

        protected bool solid
        {
            get { return solidity >= 0.5 && this.density > 0; }
        }

        public string Physicality()
        {
            return $"solidity: {solidity}\ndensity: {density}";
        }
        
        public virtual void Defy(string solidarity, string density)
        {
            try
            {
                this.solidity = float.Parse(solidarity);
                this.density = float.Parse(density);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public virtual void Defy(float solidarity, float density)
        {
            try
            {
                this.solidity = solidarity;
                this.density = density;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public virtual string ToString()
        {
            return $"Got: {solidity} / {density} and solid = {solid}";
        }
    }

    public class Shape : Solidity
    {
        private string _shape;

        public string shape
        {
            get { return _shape == null || _shape == "" ? "Blop": _shape;
        }
        }
        
        public Shape(string shape)
        {
            _shape = shape;
        }

        public void Reshape(string shape)
        {
            _shape = shape;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {shape} Got: {solidity} / {density} and solid = {solid}";
        }
    }
}