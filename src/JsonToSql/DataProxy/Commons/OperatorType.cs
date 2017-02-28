using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonToSql
{
    public enum OperateType
    {
        Default,
        MutipleSelect,
        SingleSelect,
        Delete,
        Insert,
        Update,
        NA
    }
}
