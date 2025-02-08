using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoamSodoku.DataStructures.Cell
{
    public interface ICell
    {
        int _row { get; }
        int _col { get; }
        int _box { get; }
    }
}
