﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.Framework.UI.Grid.Html
{
    public interface IGridCellBuilder //: IGridDecoratableCellBuilder
    {
        IHtmlNode CreateCell();
    }
}