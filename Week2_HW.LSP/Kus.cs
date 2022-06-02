using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.LSP
{
    public abstract class Kus
    {        
        public string Yuru()
        {
            return "Yürüyebilir";
        }
        //public abstract string ses();
        public abstract string Ses();

    }

    public interface IUc
    {
        string Uc();
    }
    public interface IKonus
    {
        string Konus();
    }

    public class Tavuk : Kus
    {
        //public override string ses()
        public override string Ses()
        {
            return "Tavuk sesi";
        }
    }

    public class Ordek : Kus, IUc
    {
        public string Uc()
        {
            return "Ördek uçar";
        }
        public override string Ses()
        {
            return "Ördek sesi";
        }
    }

    public class Papagan : Kus, IKonus, IUc
    {
        public string Konus()
        {
            return "Papağan konuşur";
        }
        public override string Ses()
        {
            return "Papagan sesi";
        }
        public string Uc()
        {
            return "Papağan uçar";
        }
    }
}
