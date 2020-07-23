using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialsLibrary
{
    public interface IPaper
    {
        Color Color { get; set; }
        bool IsColoredAgain { get; set; }
        void Paint(Color color);
    }
}
