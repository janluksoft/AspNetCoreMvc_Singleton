
namespace PMvcMyLay73.Models
{
    //public partial class Stuff
    public class Stuff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }


        public Stuff()
        {
            Id = 1;
            Name = string.Empty; // "Bag";
            Symbol = string.Empty;// "Bg01";
        }
    }

    public interface IStuffService
    {
        //User? GetUser(int id);
        Stuff? GetStuff();
        Stuff? GetStuff(int xNum);
    }


    public class StuffService : IStuffService
    {
        private Stuff caStuff;
        public StuffService()
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
                    SetStuffS(0, "void", "void");
                    break;
                case 1:
                    SetStuffS(1, "Table", "t03");
                    break;
                case 2:
                    SetStuffS(2, "Blanket", "b11");
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