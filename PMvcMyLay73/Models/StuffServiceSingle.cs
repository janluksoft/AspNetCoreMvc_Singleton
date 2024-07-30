
namespace PMvcMyLay73.Models
{
    //public partial class Stuff

    public interface IStuffServiceSingle
    {
        //User? GetUser(int id);
        Stuff? GetStuff();
        Stuff? GetStuff(int xNum);
    }


    public class StuffServiceSingle : IStuffServiceSingle
    {
        private Stuff caStuff;
        public StuffServiceSingle()
        {
            caStuff = new Stuff();
            SetStuff(0); //First change data of Stuff class
        }
        public Stuff GetStuff()
        {
            return caStuff;
        }

        public Stuff GetStuff(int xNum)
        {
            if(xNum > 0)
                SetStuff(xNum); //First change data of Stuff class

            return caStuff; //Return New, actual data 
        }

        public void SetStuff(int xNum)
        {
            switch (xNum)
            {
                case 0:
                    SetStuffS(0, "none", "none");
                    break;
                case 1:
                    SetStuffS(1, "Kettle", "kt12");
                    break;
                case 2:
                    SetStuffS(2, "Mug", "m04");
                    break;
                default:
                    break;

            }
        }

        public void SetStuffS(int xId, string xName, string xSymbol)
        {
            caStuff.Id = xId;
            caStuff.Name = xName;
            caStuff.Symbol = xSymbol;
        }

    }

}