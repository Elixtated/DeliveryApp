using CommonModule.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CommonModule
{
    public interface IModule
    {
        Page ModulePage { get; }

        string Name { get;}
    }
}
