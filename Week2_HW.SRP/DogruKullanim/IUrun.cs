using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_HW.SRP
{
    public interface IUrun
    {
        decimal OranUygula(decimal a, int b);
        decimal KesintiUygula(decimal a, decimal b);
    }
}
